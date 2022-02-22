# 通过OPC采集数据

![image-20220222162756963](Imag/image-20220222162756963.png)

- OPC UA客户机：上位机
- 组合的客户机和服务器：网关、KEPServer
- OPC UA服务器：设备

## 网关

网关作为一个中间服务器，将数据采集到网关，然后网关通过Mqtt、Modbus、OpcServer和上位机/云服务器对接。

## KEP Server

需要安装在windows环境下。

百度搜个破解版，用它来充当网关的功能。



