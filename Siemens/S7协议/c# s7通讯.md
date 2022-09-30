# c# s7通讯

参考链接：

[C#与西门子PLC S7-1500 S7协议通信(1) 环境搭建](https://www.cnblogs.com/cdjbolg/p/16391195.html)

[C#与西门子PLC S7-1500 S7协议通信(2) 读写数据](https://www.cnblogs.com/cdjbolg/p/16394927.html)

[s7netplus .NET Library](https://github.com/S7NetPlus/s7netplus)

[Siemens S7 Windows](https://github.com/spread679/SiemensS7-Test)

## C#与西门子PLC S7-1500 S7协议通信(1) 环境搭建

1.搭建环境

博图V16

PLC仿真软件.

VS2019

2.创建一个PLC 

![img](E:\codes\Industry\Siemens\S7协议\Imag\1761239-20220619194845966-1548955165.png)

 

 3.使用博图V16连接PLC并写入一些数据用于测试

 1.新建项目

![img](E:\codes\Industry\Siemens\S7协议\Imag\1761239-20220619213438614-1521167033.png)

 

 

 2.打开项目视图

![img](E:\codes\Industry\Siemens\S7协议\Imag\1761239-20220619213521898-795356222.png)

 

3.由于是仿真所以需要打开<块编译时支持仿真>。 路径为 右键项目文件=》属性=》保护=》块编译时支持仿真。 这边记得单独编译一下Main Ob1

![img](E:\codes\Industry\Siemens\S7协议\Imag\1761239-20220619213624516-1326758459.png)

4.添加新设备，选择一个PLC S7-1500 第一个型号就行。

5.选中组态的PLC设备，常规下找到防护与安全，选择允许从远程伙伴使用PUT/GET通信访问

![img](E:\codes\Industry\Siemens\S7协议\Imag\1761239-20220619220525359-1342727518.png)

 

 6.建立的数据块文件，右键属性，需要取消优化的块访问选项，使用绝对地址

![img](E:\codes\Industry\Siemens\S7协议\Imag\1761239-20220619222617406-70149721.png)

7.定义一些数据

![img](E:\codes\Industry\Siemens\S7协议\Imag\1761239-20220620174906323-493953619.png)

 

 8.下载到仿真设备PLC中

![img](E:\codes\Industry\Siemens\S7协议\Imag\1761239-20220620193225027-1391545383.png)

 9.下载完成。环境搭建完成。

## C#与西门子PLC S7-1500 S7协议通信(2) 读写数据

1.类库使用S7netplus

2.连接PLC

```
private Plc plc = null;
//PLC类型 IP地址 机架号 槽号
Plc MyPlc = new Plc(CpuType.S71500, "192.168.1.10", 0, 0);
MyPlc.Open();
if (MyPlc.IsConnected == false)
{
　　MessageBox.Show("PLC连接失败");
}
else
{
　　MessageBox.Show("PLC连接成功");
　　plc = MyPlc;
}                
```

3.读写数据  这边注意:String稍微特殊。参考[S7.Net与西门子PLC通讯——纯新手必看 - Minily - 博客园 (cnblogs.com)](https://www.cnblogs.com/minily/p/13324120.html)

```
　　　　　　 //Bool
            plc.Write("DB1.DBX0.0", true);
            var IsRight = plc.Read("DB1.DBX0.0");
            Console.WriteLine("DB1.DBX0.0: " + IsRight);

            //Int
            plc.Write("DB1.DBW2.0", Convert.ToInt16(1));
            int Score = (ushort)plc.Read("DB1.DBW2.0");
            Console.WriteLine("DB1.DBW2.0: " + Score);

            // Real
            plc.Write("DB1.DBD4.0", Convert.ToSingle(1.1));
            var Money = ((uint)plc.Read("DB1.DBD4.0")).ConvertToFloat();
            Console.WriteLine("DB1.DBD4.0: " + Money);

            //String写入
            var temp = Encoding.ASCII.GetBytes("Chen");   //将val字符串转换为字符数组
            var bytes = S7.Net.Types.S7String.ToByteArray("Chen", temp.Length);
            plc.WriteBytes(DataType.DataBlock, 1, 8, bytes);
            //String读取
            var reservedLength = (byte)plc.Read(DataType.DataBlock, 1, 8, VarType.Byte, 1);//获取字符串长度
            var Name = (string)plc.Read(DataType.DataBlock, 1, 8, VarType.S7String, reservedLength);//获取对应长度的字符串
            Console.WriteLine("DB1.8.0: " + Name);

            // DInt
            plc.Write("DB1.DBD264.0", Convert.ToInt32(20));
            var dIntVar = (uint)plc.Read("DB1.DBD264.0");
            Console.WriteLine("DB1.DBD264.0: " + dIntVar);

            // DWord
            plc.Write("DB1.DBD268.0", 123456);
            var dWordVar = (uint)plc.Read("DB1.DBD268.0");
            Console.WriteLine("DB1.DBD268.0: " + dWordVar);

            // Word
            plc.Write("DB1.DBD270.0", 12345678);
            var wordVar = (uint)plc.Read("DB1.DBD270.0");
            Console.WriteLine("DB1.DBD270.0: " + wordVar);
```



4.测试成功

TIA博图软件 可以在线监视数据

![img](E:\codes\Industry\Siemens\S7协议\Imag\1761239-20220620215705331-385840072.png)