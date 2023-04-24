# 一，数控机床数据采集方式分类

1，采用[SDK开发](https://so.csdn.net/so/search?q=SDK开发&spm=1001.2101.3001.7020)包采集，比如三菱、发那科、海德汉、大卫、华中数控、凯恩帝、沙迪克、牧野电火花、台湾宝元、上海来钠克、精雕等等。

2，[OPC](https://so.csdn.net/so/search?q=OPC&spm=1001.2101.3001.7020) UA/DA，比如西门子、力士乐。

3，直接采集PLC，比如西门子。

4，协议采集，比如西门子、三菱、发那科、海德汉、广数、新代、兄弟、马扎克smart/smooth/640/matrix。

5，IO采集，当某个型号无法用上述方法采集时，可以考虑IO采集，IO采集的数据有限，通常是产量、运转次数、运行时间这类型的生产数据。



# 二，各品牌数控系统数采总体说明

## **1，三菱（MITSUBISHI）** 

型号：M60、M70、M80、C700、C800

方法一般有两种：

（1）通过官方A2 API（也叫EZSocket）进行数据采集，需要安装驱动包（仅适用于windows系统）

（2）通过纯TCP协议方法。该方法不局限于CPU架构（x86、ARM、MIPS等等），不局限操作系统（Windows、Linux、FreeRTOS、RT-Thread、μC/OS、裸机等等均可），不局限编程语言（Java、Python、C/C++、C#、Go等等均可）。

详情可参考

[三菱（MITSUBISHI）CNC数据采集_CNC注塑机PLC专业数采的博客-CSDN博客](https://blog.csdn.net/q22837656/article/details/123979810?spm=1001.2014.3001.5502)

## **2，发那科 / 法兰克（Fanuc）** 

型号：带网卡的系统，没有网卡的也可以加装PCIMCIA卡

方法一般有两种：

（1）通过FOCAS 1/2 开发包进行二次开发采集数据（仅适用于windows系统）

（2）通过纯TCP协议方法。该方法不局限于CPU架构（x86、ARM、MIPS等等），不局限操作系统（Windows、Linux、FreeRTOS、RT-Thread、μC/OS、裸机等等均可），不局限编程语言（Java、Python、C/C++、C#、Go等等均可）。

详情可参考

[发那科 / 法兰克（Fanuc）CNC数据采集_CNC注塑机PLC专业数采的博客-CSDN博客](https://blog.csdn.net/q22837656/article/details/124131978?spm=1001.2014.3001.5502)

## **3，西门子（SIEMENS）** 

型号：802C、802D、802D SL、808D、808D ADVANCE、828D、840D、840SL

方法一般有三种：

（1）直接采集PLC。

（2）开通OPC [UA](https://so.csdn.net/so/search?q=UA&spm=1001.2101.3001.7020)授权。

（3）纯TCP协议方法（免授权）。

PS：西门子需要根据具体型号来区分采集方法，并不是所有型号都可使用上述三种方法来采集。

## **4，马扎克（Mazak）** 

（1）官方开通授权，开启MTConnect协议，授权费比较昂贵，具体可咨询代理商。

（2）Smart和Smooth可通过调用dll方法采集（免授权）。

（3）Smart和Smooth可通过TCP协议方式采集（免授权）。

（4）640和Matrix可通过在机台安装插件，再通过UDP协议方式采集（免授权）。

详情请参考

[马扎克（Mazak）Smart、Smooth系列 CNC数据采集_CNC注塑机PLC专业数采的博客-CSDN博客](https://blog.csdn.net/q22837656/article/details/126026167)



## **5，大隈（Okuma）** 

方法只有一种：

（1）官方开通授权，主要有API和MTConnect协议，授权费比较昂贵，具体可咨询代理商。

## **6，海德汉（HEIDENHAIN）** 

型号：430、530、642、640

方法一般有两种：

（1）官方开通授权，机台和SDK都需要授权，总体授权费比较昂贵，具体可咨询代理商。

（2）LSV2协议（免授权）。

详情参考

[海德汉（HEIDENHAIN）CNC数据采集（可免授权）_CNC注塑机PLC专业数采的博客-CSDN博客](https://blog.csdn.net/q22837656/article/details/124221208)

## **7，兄弟（Brother）** 

方法：

（1）TCP协议。

## **8，广州数控/广数（GSK）** 

型号：有网口的

方法：

（1）官方SDK。

## **9，华中数控/华中（HNC）** 

型号：8系列的有网口的基本都可以

方法一般有：

（1）官方SDK。

## **10，新代（SYNTEC）** 

方法：

（1）官方SDK。

## **11，凯恩帝（KND）** 

方法：

（1）官方SDK。

## **12，沙迪克（Sodick）** 

方法：

（1）官方SDK。

## **13，台湾宝元** 

方法：

（1）官方SDK。

## **14，精雕** 

需授权

方法：

（1）官方SDK。



详细经过实战验证的资料可助您事半功倍！上述CNC，欢迎私聊进行技术交流