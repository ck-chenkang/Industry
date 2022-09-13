# fasca2

focas协议是用来采集fanuc机床的协议，通过以太网进行采集。

### 1. focas1/2的简明教程可以看（稍后我会把所有的资料都上传，这是我从各个地方收集到并整理的）：

这个文档主要介绍了fanuc机床的ip和端口如何配置，能通讯的数据分类，和采集方法的简单介绍

![img](Imag/5b091a9f8d2240f9a3c51c513a0a02fa.png)

如果你按照上面的文档配置，那么你应该就可以连接到机床。[下载](https://download.csdn.net/download/weixin_42415843/85626507)

### 2.利用focas API采集数据

1.按照如下图1路径找到了FWLIB32,记住使用IE浏览器打开

2.如图2点击允许阻止的内容，Connection type选择Ethernet(网口)，Applicable CNCs 选择机床的类型，这里我使用oi-MODEL F(大家可以根据自己的机床类型选择)

3.如图3点击![img](Imag/57d73d32d22a46aebfd5c05c8f976344.png)这时候就会单出功能函数，如图4.相关的函数使用方法和说明文档的中文版，我也打包放一起了。[下载](https://download.csdn.net/download/weixin_42415843/85500213)

![img](Imag/f00135da84c04d18ad127bbfe98811e8.png)

图1

![img](Imag/82efab64a8f84c5ca888e0e35a06cc16.png)



图2

![img](Imag/9990b21b65334e86a671291d4e757d35.png)

图3 

![img](Imag/57a0de1ebbdf48b8babc522123f00806.png)

图4 

### 3.使用C#连接实战

在介绍了机床的IP和端口的配置和focas相关函数的使用以后，接下来我们用C#连接写一下简单的demo

环境准备：

​     1.开发环境：VS2019 winform

​     2.找到fwlib32.dll和fwlib1.dll2个必备的库，如图5

​     3.按照如下路径找到fwlib32.cs复制到项目中，因为focas协议用的是C++写的，这个是官方给我们用C#封装好调用C++的库，直接使用即可，如图6

![img](Imag/0f7527dd696f46ac821410102b83a1df.png)

图5 

![img](Imag/4a347c1ec9f64281a476df2e384a9fa9.png)

图6



项目创建：

​    1.首先创建一个winform起名FanucFocasDemo，然后把fwlib32.dll,fwlib1.dll和fwlib32.cs复制到项目中

​    2.fwlib32.dll和fwlib1.dll2个DLL点击他们的属性，复制到输出目录选择始终复制，如图8。这样我们不管在重新生成项目文件或者清理后生成项目文件，dll都会在Debug/release文件下，这个时候Debug/release下面的可执行程序才可以调用到DLL

![img](Imag/14dc065686e84f87b0f7778a75fe7e00.png)

​                图7 

![img](Imag/2e97abb3bbde494293b9ada1efb77599.png)

​                                图8 

​    3.连接，通过cnc_allclibhndl3方法进行连接

```cs
private void connection_Click(object sender, EventArgs e)
{
    this.ret = Focas1.cnc_allclibhndl3(ip, Convert.ToUInt16(port), Convert.ToInt32(timeout), out h);
    if (this.ret != Focas1.EW_OK)
    {
        //设备未连接上
        MessageBox.Show("设备未连接上");
    }
    else if (this.ret == Focas1.EW_OK)
    {
        MessageBox.Show("设备连接成功");
    }
}
```

 注意：  

我们看下fwlib32.cs函数库的一个枚举（如图9）：focas_ret

所有的数据请求，函数库都会返回一个请求结果（成功or失败）以及ref或者out出来的响应数据（如主轴信息、转速信息、加工信息等。）

请求结果为0代表请求成功，即以下的EW_OK，说明响应数据返回并且正确，负责全部为请求失败，详细问题看英文注释，如

  EW_SOCKET  =   (-16),      /* Windows socket error */代表了tcp Socket套接字错误，说明网络问题。

   EW_NODLL   =   (-15),      /* DLL not exist error */代表DLL未找到，查看是否引用或者程序同级目录有没有我上述讲到的两个dll库。各类原因我不一一解释，可以查阅翻译软件对英文进行翻译
![img](Imag/b3327660719846a1b2b90d2e1072eb99.png)

图9 

  4.采集，这个是我能采集到的数据如图10

![img](Imag/e25478ed66494ba7b508176adbce4088.png)

图10

 坐标：

```cs
Focas1.ODBPOS fos = new Focas1.ODBPOS();
short num = Focas1.MAX_AXIS;
short type = -1;
short ret = Focas1.cnc_rdposition(h, type, ref num, fos);

if (ret == 0)
{
   //绝对
    txtXAbsolutely.Text = (fos.p1.abs.data * Math.Pow(10, -fos.p1.abs.dec)).ToString();
    txtYAbsolutely.Text = (fos.p2.abs.data * Math.Pow(10, -fos.p2.abs.dec)).ToString();
    //相对
    txtXRelative.Text = (fos.p1.rel.data * Math.Pow(10, -fos.p1.rel.dec)).ToString();
    txtYRelative.Text = (fos.p2.rel.data * Math.Pow(10, -fos.p2.rel.dec)).ToString();
}
```

 系统信息：是

```cs
Focas1.ODBSYS k1 = new Focas1.ODBSYS();
ret = Focas1.cnc_sysinfo(h, k1);
if (ret == Focas1.EW_OK)
{
    MaxAxis = k1.max_axis.ToString();//最大轴数 
    this.txtMaxAxis.Text = MaxAxis;
    string type1 = k1.cnc_type[0].ToString() + k1.cnc_type[1].ToString();//CNC类型
    #region 机床系统类型判断
        switch (type1)
        {
            case "15":
                CNCType = "Series 15/15i";
                break;
            case "16":
                CNCType = "Series 16/16i";
                break;
            case "18":
                CNCType = "Series 18/18i";
                break;
            case "21":
                CNCType = "Series 21/21i";
                break;
            case "30":
                CNCType = "Series 30i";
                break;
            case "31":
                CNCType = "Series 31i";
                break;
            case "32":
                CNCType = "Series 32i";
                break;
            case "35":
                CNCType = "Series 35i";
                break;
            case " 0":
                CNCType = "Series 0i";
                break;
            case "PD":
                CNCType = "Power Mate i-D";
                break;
            case "PH":
                CNCType = "Power Mate i-H";
                break;
            case "PM":
                CNCType = "Power Motion i";
                break;
            default:
                CNCType = "其它类型";
                break;
        }
    #endregion
        this.txtCNCType.Text = CNCType;
    MTType = k1.mt_type[0].ToString() + k1.mt_type[1].ToString();
    SerialNumber = k1.series[0].ToString() + k1.series[1].ToString() + k1.series[2].ToString() + k1.series[3].ToString();//CNC型号
    this.txtSerialNumber.Text = SerialNumber;
    Version = k1.version[0].ToString() + k1.version[1].ToString() + k1.version[2].ToString() + k1.version[3].ToString();
    Axis = k1.axes[0].ToString() + k1.axes[1].ToString();
}
```



设备状态和工作模式：

```cs
Focas1.ODBST statinfo = new Focas1.ODBST();
ret = Focas1.cnc_statinfo(h, statinfo);
if (ret == Focas1.EW_OK)
{
    //设备状态的判定方法：如果Alarm不为0则有报警。当没有报警时，如果run=3认为是在运行，其他都为待机



    run = statinfo.run;



    Alarm = statinfo.alarm;



    //MTMode = statinfo.tmmode;



    if (Alarm != 0)



        run = 5;//5为设备报警状态



    this.txtDevStatus.Text = run.ToString();



    #region 工作模式判断



        switch (statinfo.aut)



        {



            case 0:



                CNCModel = "MDI";



                break;



            case 1:



                CNCModel = "MEMory";



                break;



            case 2:



                CNCModel = "Not Defined";



                break;



            case 3:



                CNCModel = "EDIT";



                break;



            case 4:



                CNCModel = "HaNDle";



                break;



            case 5:



                CNCModel = "JOG";



                break;



            case 6:



                CNCModel = "Teach in JOG";



                break;



            case 7:



                CNCModel = "Teach in HaNDle";



                break;



            case 8:



                CNCModel = "INC·feed";



                break;



            case 9:



                CNCModel = "REFerence";



                break;



            case 10:



                CNCModel = "ReMoTe";



                break;



            default:



                CNCModel = "others mode";



                break;



        }



    #endregion



        this.txtCNCModel.Text = CNCModel.ToString();



}
```



报警数据：

```cs
 #region 报警数据



            ret = Focas1.cnc_alarm2(h, out almdsta);//Focas1.cnc_alarm2(h, out almdsta);



            if (ret == Focas1.EW_OK)



            {



                #region 报警判断



                switch (almdsta)



                {



                    case 0:



                        AlarmMessage = "参数开启（SW）";



                        break;



                    case 1:



                        AlarmMessage = "关机参数设置（PW）";



                        break;



                    case 2:



                        AlarmMessage = "I / O错误（IO）";



                        break;



                    case 3:



                        AlarmMessage = "前景P / S（PS";



                        break;



                    case 4:



                        AlarmMessage = "超程，外部数据（OT";



                        break;



                    case 5:



                        AlarmMessage = "过热报警（OH）";



                        break;



                    case 6:



                        AlarmMessage = "伺服报警（SV";



                        break;



                    case 7:



                        AlarmMessage = "数据I / O错误（SR）";



                        break;



                    case 8:



                        AlarmMessage = "宏指令报警（MC";



                        break;



                    case 9:



                        AlarmMessage = "主轴报警（SP）";



                        break;



                    case 10:



                        AlarmMessage = "其他警报（DS）";



                        break;



                    case 11:



                        AlarmMessage = "有关故障防止功能（IE）的警报";



                        break;



                    case 12:



                        AlarmMessage = "背景P / S（BG）";



                        break;



                    case 13:



                        AlarmMessage = "同步错误（SN）";



                        break;



                    case 14:



                        AlarmMessage = "保留";



                        break;



                    case 15:



                        AlarmMessage = "外部报警信息（EX）";



                        break;



                    case 16:



                        AlarmMessage = "正向超程（软限位1）";



                        break;



                    default:



                        AlarmMessage = "未知错误";



                        break;



                }



                #endregion



            }



            #endregion
```

主程序号和子程序号：



```cs
            Focas1.ODBPRO dbpro = new Focas1.ODBPRO();



            if (Focas1.EW_OK == Focas1.cnc_rdprgnum(h, dbpro))



            {



                Mainpg = dbpro.mdata;//主程序号



                this.txtMainpg.Text = Mainpg.ToString();



                Currentpg = dbpro.data;//当前运行程序号（子程序号）



                this.txtCurrentpg.Text = Currentpg.ToString();



 



            }
```

 主轴实际转速：

```cs
            Focas1.ODBACT data = new Focas1.ODBACT();



            ret = Focas1.cnc_acts(h, data);



            if (ret == Focas1.EW_OK)



            {



                Speed = data.data.ToString();



                this.txtSpeed.Text = Speed.ToString();//单位r/min



            }
```

进给率F 切削实际速度：

```cs
            Focas1.ODBACT ff = new Focas1.ODBACT();



            ret = Focas1.cnc_actf(h, ff);



            if (ret == Focas1.EW_OK)



            {



                FeedRate = ff.data; //单位 mm/min



                this.txtFeedRate.Text = FeedRate.ToString();



            }
```

 取刀具号 ，目前我试了没用：

```cs
            //short number = 1;



            //Focas1.IODBTLDT c = new Focas1.IODBTLDT();



            //ret = Focas1.cnc_rdtooldata(h, 1, ref number, c);



            //if (ret == Focas1.EW_OK)



            //{



            //    if (c.data1 != null)



            //    {



            //        Tool_no = c.data1.tool_no;



            //    }



            //}
```

进给倍率：

```cs
            Focas1.IODBPMC0 ig = new Focas1.IODBPMC0();



            ret = Focas1.pmc_rdpmcrng(h, 0, 1, 12, 13, 8 + 1 * 2, ig);



            if (ret == Focas1.EW_OK)



            {



                FeedOverRide = (100 - (ig.cdata[0] - 155)).ToString();//进给倍率   转换成百分比 为什么是155没搞懂，设备不同也可能不是155



                this.txtFeedOverRide.Text = FeedOverRide.ToString();



            }
```

单次工件计数 这个和控制板上的数量相对应  ：

```cs
            Focas1.ODBM bb = new Focas1.ODBM();



            ret = Focas1.cnc_rdmacro(h, 0xf3d, 0x0a, bb);



            if (ret == Focas1.EW_OK)



            {



                string PartCnt = (bb.mcr_val / 100000).ToString();



                this.txtPartCnt.Text = PartCnt.ToString();



            }
```

工件总数：

```cs
            Focas1.IODBPSD_1 param6712 = new Focas1.IODBPSD_1();



            ret = Focas1.cnc_rdparam(h, 6712, 0, 8, param6712);



            if (ret == Focas1.EW_OK)



            {



                int totalparts = param6712.ldata;



                this.txttotalparts.Text = totalparts.ToString();



            }
```

时间：

```cs
            #region 获取切削时间



            Focas1.IODBPSD_1 param6753 = new Focas1.IODBPSD_1();



            Focas1.IODBPSD_1 param6754 = new Focas1.IODBPSD_1();



            ret = Focas1.cnc_rdparam(h, 6753, 0, 8 + 32, param6753);



            if (ret == Focas1.EW_OK)



            {



                int cuttingTimeSec = param6753.ldata / 1000;



                ret = Focas1.cnc_rdparam(h, 6754, 0, 8 + 32, param6754);



                if (ret == Focas1.EW_OK)



                {



                    int cuttingTimeMin = param6754.ldata;



                    int CutTime = cuttingTimeMin * 60 + cuttingTimeSec;



                    this.txtCutTime.Text = CutTime.ToString();



                }



            }



            #endregion



            #region 获取运行时间



            Focas1.IODBPSD_1 param6751 = new Focas1.IODBPSD_1();



            Focas1.IODBPSD_1 param6752 = new Focas1.IODBPSD_1();



            ret = Focas1.cnc_rdparam(h, 6751, 0, 8, param6751);



            if (ret == Focas1.EW_OK)



            {



                int workingTimeSec = param6751.ldata / 1000;



                ret = Focas1.cnc_rdparam(h, 6752, 0, 8, param6752);



                if (ret == Focas1.EW_OK)



                {



                    int workingTimeMin = param6752.ldata;



                    int CycSec = workingTimeMin * 60 + workingTimeSec;



                    this.txtworkingTime.Text = CycSec.ToString();



                }



            }



            #endregion



            #region 获取开机时间



            Focas1.IODBPSD_1 param6750 = new Focas1.IODBPSD_1();



            ret = Focas1.cnc_rdparam(h, 6750, 0, 8 + 32, param6750);



            if (ret == Focas1.EW_OK)



            {



                int PoweOnTime = param6750.ldata * 60;



                this.txtPoweOnTime.Text = PoweOnTime.ToString();



            }
```

特别说明cnc_rdparam这个函数这个函数中的第二个参数要明白其含义，它代表的是机床PARAMETER参数表的序号。这个函数根据第二参数不同可以采集到很多信息，具体那些参数可以参考![img](Imag/1b7ac0243fff4dac9a760109725c6588.png)

[下载](https://download.csdn.net/download/weixin_42415843/85500213)

### 4.在Linux平台使用 

Fwlib32.dll是在windows上运行的，如果你想在linux使用，以linux-arm系统为例。

​    1.把如图11路径中的libfw32lib.so.1.0.1复制到到项目中。重命名为libfw32lib.so

 ![img](Imag/5e2e204b03724c27a1b0262d403c1558.png)

图11 

​    2.现在查找 fwlib32.cs 的行查找所有文本实例fwlib32.dll"替换为libfwlib32.so"

​    3.在 fwlib32.cs中添加cnc_startupprocess和cnc_exitprocess()，如图12

```cs
    /* cnc_startupprocess for linux */



    [DllImport("libfwlib32.so", EntryPoint = "cnc_startupprocess")]



    public static extern void cnc_startupprocess(long level, string filename);



 



    /* cnc_exitprocess for linux */



    [DllImport("libfwlib32.so", EntryPoint = "cnc_exitprocess")]



    public static extern void cnc_exitprocess();
```

 ![img](Imag/30ecdd73980a4e87b315d21322ac8d18.png)

图12

​    4.在调用任何其他 fwlib32.cs 库函数之前调用此函数

```cs
long level = 3; string filename = "focas.log"; Focas1.cnc_startupprocess(level, filename);
```

​    5.调用之后，你可以使用下面的线连接，接下来你可以调用任何库函数最后使用完函数之后别忘了调用cnc_exitprocess函数退出。

```
参考博客：浅谈几种主流数控机床的数据采集技术 - it610.com
```

​         [c++ fanuc cnc数据采集踩过坑_yangxd_ah的博客-CSDN博客](https://blog.csdn.net/yangxd_ah/article/details/107723136)

​         [Linux平台上的Focas fwlib32 CNC库 - IT屋-程序员软件开发技术分享社区](https://www.it1352.com/2859753.html)