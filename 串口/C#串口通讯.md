# C# 串口通讯

[原文](https://www.cnblogs.com/Traveller-Lee/p/6940221.html)

[源码](https://github.com/ck-chenkang/SerialPortConnection)

因为参加一个小项目，需要对继电器进行串口控制，所以这两天学习了基本的串口编程。同事那边有JAVA的串口通信包，不过是从网上下载的，比较零乱，难以准确掌握串口通信的流程和内含。因此，个人通过学习网上大牛的方法，利用C#实现了基本的串口通信编程。下面对学习成果进行总结归纳，希望对大家有所帮助。

一、串口通信简介

串行接口（串口）是一种可以将接受来自CPU的并行数据字符转换为连续的串行数据流发送出去，同时可将接受的串行数据流转换为并行的数据字符供给CPU的器件。一般完成这种功能的电路，我们称为串行接口电路。

串口通信（Serial Communications）的概念非常简单，串口按位（bit）发送和接收字节。尽管比按字节（byte）的并行通信慢，但是串口可以在使用一根线发送数据的同时用另一根线接收数据。串口通信最重要的参数是波特率、数据位、停止位和奇偶校验。对于两个进行通信的端口，这些参数必须匹配。

1. 波特率：这是一个衡量符号传输速率的参数。指的是信号被调制以后在单位时间内的变化，即单位时间内载波参数变化的次数，如每秒钟传送960个字符，而每个字符格式包含10位（1个起始位，1个停止位，8个数据位），这时的波特率为960Bd，比特率为10位*960个/秒=9600bps。

2. 数据位：这是衡量通信中实际数据位的参数。当计算机发送一个信息包，实际的数据往往不会是8位的，标准的值是6、7和8位。标准的ASCII码是0～127（7位），扩展的ASCII码是0～255（8位）。

3. 停止位：用于表示单个包的最后几位。典型的值为1，1.5和2位。由于数据是在传输线上定时的，并且每一个设备有其自己的时钟，很可能在通信中两台设备间出现了小小的不同步。因此停止位不仅仅是表示传输的结束，并且提供计算机校正时钟同步的机会。

4. 校验位：在串口通信中一种简单的检错方式。有四种检错方式：偶、奇、高和低。当然没有校验位也是可以的。

二、C#串口编程类

从.NET Framework 2.0开始，C#提供了SerialPort类用于实现串口控制。**命名空间:**System.IO.Ports。其中详细成员介绍参看[MSDN文档](https://msdn.microsoft.com/zh-cn/library/system.io.ports.serialport_members(v=vs.80).aspx#mainBody)。下面介绍其常用的字段、方法和事件。

1. 常用字段：

| 名称     | 说明                               |
| -------- | ---------------------------------- |
| PortName | 获取或设置通信端口                 |
| BaudRate | 获取或设置串行波特率               |
| DataBits | 获取或设置每个字节的标准数据位长度 |
| Parity   | 获取或设置奇偶校验检查协议         |
| StopBits | 获取或设置每个字节的标准停止位数   |

2. 常用方法：

| 名称         | 说明                                                         |
| ------------ | ------------------------------------------------------------ |
| Close        | 关闭端口连接，将 IsOpen 属性设置为 **false**，并释放内部 Stream 对象 |
| GetPortNames | 获取当前计算机的串行端口名称数组                             |
| Open         | 打开一个新的串行端口连接                                     |
| Read         | 从 **SerialPort** 输入缓冲区中读取                           |
| Write        | 将数据写入串行端口输出缓冲区                                 |

3. 常用事件：

| 名称         | 说明                                               |
| ------------ | -------------------------------------------------- |
| DataReceived | 表示将处理 **SerialPort** 对象的数据接收事件的方法 |

三、基本用法

下面结合已有的一款继电器给出串口通信的基本用法，以供参考。

```C#
  1 using System;
  2 using System.Windows.Forms;
  3 using System.IO.Ports;
  4 using System.Text;
  5 
  6 namespace Traveller_SerialPortControl
  7 {
  8     public partial class Form1 : Form
  9     {
 10         //定义端口类
 11         private SerialPort ComDevice = new SerialPort();
 12         public Form1()
 13         {
 14             InitializeComponent();
 15             InitralConfig();
 16         }
 17         /// <summary>
 18         /// 配置初始化
 19         /// </summary>
 20         private void InitralConfig()
 21         {
 22             //查询主机上存在的串口
 23             comboBox_Port.Items.AddRange(SerialPort.GetPortNames());
 24 
 25             if (comboBox_Port.Items.Count > 0)
 26             {
 27                 comboBox_Port.SelectedIndex = 0;
 28             }
 29             else
 30             {
 31                 comboBox_Port.Text = "未检测到串口";
 32             }
 33             comboBox_BaudRate.SelectedIndex = 5;
 34             comboBox_DataBits.SelectedIndex = 0;
 35             comboBox_StopBits.SelectedIndex = 0;
 36             comboBox_CheckBits.SelectedIndex = 0;
 37             pictureBox_Status.BackgroundImage = Properties.Resources.red;
 38 
 39             //向ComDevice.DataReceived（是一个事件）注册一个方法Com_DataReceived，当端口类接收到信息时时会自动调用Com_DataReceived方法
 40             ComDevice.DataReceived += new SerialDataReceivedEventHandler(Com_DataReceived);
 41         }
 42 
 43         /// <summary>
 44         /// 一旦ComDevice.DataReceived事件发生，就将从串口接收到的数据显示到接收端对话框
 45         /// </summary>
 46         /// <param name="sender"></param>
 47         /// <param name="e"></param>
 48         private void Com_DataReceived(object sender, SerialDataReceivedEventArgs e)
 49         {
 50             //开辟接收缓冲区
 51             byte[] ReDatas = new byte[ComDevice.BytesToRead];
 52             //从串口读取数据
 53             ComDevice.Read(ReDatas, 0, ReDatas.Length);
 54             //实现数据的解码与显示
 55             AddData(ReDatas);
 56         }
 57 
 58         /// <summary>
 59         /// 解码过程
 60         /// </summary>
 61         /// <param name="data">串口通信的数据编码方式因串口而异，需要查询串口相关信息以获取</param>
 62         public void AddData(byte[] data)
 63         {
 64             if (radioButton_Hex.Checked)
 65             {
 66                 StringBuilder sb = new StringBuilder();
 67                 for (int i = 0; i < data.Length; i++)
 68                 {
 69                     sb.AppendFormat("{0:x2}" + " ", data[i]);
 70                 }
 71                 AddContent(sb.ToString().ToUpper());
 72             }
 73             else if (radioButton_ASCII.Checked)
 74             {
 75                 AddContent(new ASCIIEncoding().GetString(data));
 76             }
 77             else if (radioButton_UTF8.Checked)
 78             {
 79                 AddContent(new UTF8Encoding().GetString(data));
 80             }
 81             else if (radioButton_Unicode.Checked)
 82             {
 83                 AddContent(new UnicodeEncoding().GetString(data));
 84             }
 85             else
 86             {
 87                 StringBuilder sb = new StringBuilder();
 88                 for (int i = 0; i < data.Length; i++)
 89                 {
 90                     sb.AppendFormat("{0:x2}" + " ", data[i]);
 91                 }
 92                 AddContent(sb.ToString().ToUpper());
 93             }
 94         }
 95 
 96         /// <summary>
 97         /// 接收端对话框显示消息
 98         /// </summary>
 99         /// <param name="content"></param>
100         private void AddContent(string content)
101         {
102             BeginInvoke(new MethodInvoker(delegate
103             {              
104                     textBox_Receive.AppendText(content);              
105             }));
106         }
107 
108         /// <summary>
109         /// 串口开关
110         /// </summary>
111         /// <param name="sender"></param>
112         /// <param name="e"></param>
113         private void button_Switch_Click(object sender, EventArgs e)
114         {
115             if (comboBox_Port.Items.Count <= 0)
116             {
117                 MessageBox.Show("未发现可用串口，请检查硬件设备");
118                 return;
119             }
120 
121             if (ComDevice.IsOpen == false)
122             {
123                 //设置串口相关属性
124                 ComDevice.PortName = comboBox_Port.SelectedItem.ToString();
125                 ComDevice.BaudRate = Convert.ToInt32(comboBox_BaudRate.SelectedItem.ToString());
126                 ComDevice.Parity = (Parity)Convert.ToInt32(comboBox_CheckBits.SelectedIndex.ToString());
127                 ComDevice.DataBits = Convert.ToInt32(comboBox_DataBits.SelectedItem.ToString());
128                 ComDevice.StopBits = (StopBits)Convert.ToInt32(comboBox_StopBits.SelectedItem.ToString());
129                 try
130                 {
131                     //开启串口
132                     ComDevice.Open();
133                     button_Send.Enabled = true;
134                 }
135                 catch (Exception ex)
136                 {
137                     MessageBox.Show(ex.Message, "未能成功开启串口", MessageBoxButtons.OK, MessageBoxIcon.Error);
138                     return;
139                 }
140                 button_Switch.Text = "关闭";
141                 pictureBox_Status.BackgroundImage = Properties.Resources.green;
142             }
143             else
144             {
145                 try
146                 {
147                     //关闭串口
148                     ComDevice.Close();
149                     button_Send.Enabled = false;
150                 }
151                 catch (Exception ex)
152                 {
153                     MessageBox.Show(ex.Message, "串口关闭错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
154                 }
155                 button_Switch.Text = "开启";
156                 pictureBox_Status.BackgroundImage = Properties.Resources.red;
157             }
158 
159             comboBox_Port.Enabled = !ComDevice.IsOpen;
160             comboBox_BaudRate.Enabled = !ComDevice.IsOpen;
161             comboBox_DataBits.Enabled = !ComDevice.IsOpen;
162             comboBox_StopBits.Enabled = !ComDevice.IsOpen;
163             comboBox_CheckBits.Enabled = !ComDevice.IsOpen;
164         }
165 
166       
167         /// <summary>
168         /// 将消息编码并发送
169         /// </summary>
170         /// <param name="sender"></param>
171         /// <param name="e"></param>
172         private void button_Send_Click(object sender, EventArgs e)
173         {
174             if (textBox_Receive.Text.Length > 0)
175             {
176                 textBox_Receive.AppendText("\n");
177             }
178 
179             byte[] sendData = null;
180 
181             if (radioButton_Hex.Checked)
182             {
183                 sendData = strToHexByte(textBox_Send.Text.Trim());
184             }
185             else if (radioButton_ASCII.Checked)
186             {
187                 sendData = Encoding.ASCII.GetBytes(textBox_Send.Text.Trim());
188             }
189             else if (radioButton_UTF8.Checked)
190             {
191                 sendData = Encoding.UTF8.GetBytes(textBox_Send.Text.Trim());
192             }
193             else if (radioButton_Unicode.Checked)
194             {
195                 sendData = Encoding.Unicode.GetBytes(textBox_Send.Text.Trim());
196             }
197             else
198             {
199                 sendData = strToHexByte(textBox_Send.Text.Trim());
200             }
201 
202             SendData(sendData);
203         }
204 
205         /// <summary>
206         /// 此函数将编码后的消息传递给串口
207         /// </summary>
208         /// <param name="data"></param>
209         /// <returns></returns>
210         public bool SendData(byte[] data)
211         {
212             if (ComDevice.IsOpen)
213             {
214                 try
215                 {
216                     //将消息传递给串口
217                     ComDevice.Write(data, 0, data.Length);
218                     return true;
219                 }
220                 catch (Exception ex)
221                 {
222                     MessageBox.Show(ex.Message, "发送失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
223                 }
224             }
225             else
226             {
227                 MessageBox.Show("串口未开启", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
228             }
229             return false;
230         }
231 
232         /// <summary>
233         /// 16进制编码
234         /// </summary>
235         /// <param name="hexString"></param>
236         /// <returns></returns>
237         private byte[] strToHexByte(string hexString)
238         {
239             hexString = hexString.Replace(" ", "");
240             if ((hexString.Length % 2) != 0) hexString += " ";
241             byte[] returnBytes = new byte[hexString.Length / 2];
242             for (int i = 0; i < returnBytes.Length; i++)
243                 returnBytes[i] = Convert.ToByte(hexString.Substring(i * 2, 2).Replace(" ", ""), 16);
244             return returnBytes;
245         }
246 
247         //以下两个指令是结合一款继电器而设计的
248         private void button_On_Click(object sender, EventArgs e)
249         {
250             textBox_Send.Text = "005A540001010000B0";
251         }
252 
253         private void button_Off_Click(object sender, EventArgs e)
254         {
255             textBox_Send.Text = "005A540002010000B1";
256         }
257     }
258 }
```

软件实现基本界面

![img](E:\codes\Industry\串口\Imag\774827-20170604130701305-1831782111.png)

![img](E:\codes\Industry\串口\Imag\774827-20170604130836383-1807388911.png)

 