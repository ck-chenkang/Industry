[原文](https://www.plctechnical.com/2020/04/Upload-Siemens-S7-200-Program-using-PPI-cable.html)

# Upload Siemens S7-200 Program using PPI cable

Dear PLC Technical members, 

Welcome to our followers on the Blog PLC Technical, today in this article I will introduce you how to **upload Siemens S7-200** Program using the PPI cable point to point interface. I can only now explain this application to you.



[![UPLOAD S7-200 SIEMENS PROGRAM USING PPI](E:\codes\Industry\Siemens\上载\Imag\UPLOAD-S7-200-SIEMENS-PROGRAM-USING-PPI+(1).webp)](https://1.bp.blogspot.com/-xLPF58ApvQM/XxSQdlezo7I/AAAAAAAAIQc/fDurQuVGp2oMDd0uDGu3UiC1Ejet-yKRQCNcBGAsYHQ/s1600/UPLOAD-S7-200-SIEMENS-PROGRAM-USING-PPI%2B%281%29.webp)



## I. Upload Siemens S7-200 Program using PPI cable



In this part, I will guide you how to **upload Siemens S7-200** Program using PPI cable, even though the S7-200 is an old PLC, I wanted to share this article because it still needs revision and fault tracking.





But first I will also explain to you several CPU modules for the S7-200, and let us take a look at USB ,[MPI](https://www.plctechnical.com/2020/03/upload-s7-300-siemens-program-using-MPI-cable.html),[DP](https://www.plctechnical.com/2020/03/upload-s7-300-siemens-program-using-Profibus-DP-cable.html),Point to point adapter cable for Siemens S7-200, NetWork Adapter for S7 System.



### 1. USB adapter cable for Siemens S7-200

USB Adapter Siemens S7-200 PLC programming cable, five meters with communication indicator, direct use the Step7 software, USB adapter, for upload Siemens S7-200 program at the level the PLC Siemens.

***Features:*** 

- Support the Siemens S7-200-300-400 PLC communications
- Support PPI-MPI-DP communications
- Install drive, without generating serial, directly select USB



[![the siemens PPI câble](E:\codes\Industry\Siemens\上载\Imag\the-siemens-PPI-câble.webp)](https://1.bp.blogspot.com/-iCpCAjJowN0/Xo2zDjTomtI/AAAAAAAAHoI/KMe0N1WwIdcsJVqTwoOVr7UZvaJGGb0dwCNcBGAsYHQ/s1600/the-siemens-PPI-c%C3%A2ble.webp)





### 2. CPU modules

**CPU221:**

6 digital inputs4 digital outputsNot expandable with modulesSiemens article number: 6ES7211-0BA22-0XB0

**CPU222:**

8 digital inputs6 digital outputsUp to 2 expansion modulesSiemens article number: 6ES7212-1AB22-0XB0

**CPU224:**

14 digital inputs10 digital outputsMax. 7 expansion modulesSiemens article number: 6ES7214-1BD22-0XB0

**CPU224XP:**

14 digital inputs10 digital outputs2 analog inputs1 analog outputUp to 7 expansion modulesSiemens article number: 6ES7214-2AD23-0XB0

**CPU226:**
24 digital inputs16 digital outpusMaximum 7 expansion modulesSiemens article number: 6ES7216-2BD22-0XB0

[![Control Cabinet PLC S7-200](E:\codes\Industry\Siemens\上载\Imag\Control-Cabinet-PLC-S7-200.webp)](https://1.bp.blogspot.com/-UBfiwV_9CMk/Xo267qkrKBI/AAAAAAAAHoU/DB_kD39mJpsC7SOhFHD4bnNpwXrPMm_owCNcBGAsYHQ/s1600/Control-Cabinet-PLC-S7-200.webp)

| [![CPU 224 SIMATIC S7-200](E:\codes\Industry\Siemens\上载\Imag\CPU-224-SIMATIC-S7-200.webp)](https://1.bp.blogspot.com/-jg7t66eJCPM/Xo27aVnqxrI/AAAAAAAAHoc/WJPxArS529II5u61uPQxesSgcnet_yDugCNcBGAsYHQ/s1600/CPU-224-SIMATIC-S7-200.webp) |
| ------------------------------------------------------------ |
| CPU 224 SIMATIC S7-200                                       |

###  3. HOW TO UPLOAD S7-200 PROGRAM FROM CPU 224 TO PC



Create a new projectCommunication: interface parameter assignments used select PC/PPI cable. PPIShould be USB if you are connecting with a PPI to PCThe Read button reads PLC and selects it from the drop down list for uploadUpload program from CPU 224 to PC: Press upload the PC will read the PLCThe Program uploads successfully




Have a gander at this article to see the software used STEP7-Micro/WIN for **uploading the program SIMATIC S7-200** CPU 224.using the Siemens PPI câble.





Starting [STEP 7-Micro/WIN](https://365electricalvn.com/step-7-microwin-v4-on-windows-10/) Open the Micro/win STEP7 programming, click " settings PG/PC interfaces " fasten and choose " PC/PPI cable (PPI)" After you click on the " Properties " button, appeared in the accompanying figure:



 [![PC adapter PPI](E:\codes\Industry\Siemens\上载\Imag\PC-adapter-PPI.webp)](https://1.bp.blogspot.com/-PSEHx15SmX8/Xo72ygdBpDI/AAAAAAAAHoo/r349gGLFwfwRk-clDi_cr6RMXh81-XUnwCNcBGAsYHQ/s1600/PC-adapter-PPI.webp) Set the neighborhood sequential number in the interface and mark off the" modem association: USB or COM.   [![Properties PC/PPI](E:\codes\Industry\Siemens\上载\Imag\Propertiers+PC.PPI+cable.webp)](https://1.bp.blogspot.com/-KqiIm-CxHKo/Xo8B_TfWjuI/AAAAAAAAHp4/OtGkQ5XGOygFUBZrYciJVknk6BIQusetgCNcBGAsYHQ/s1600/Propertiers%2BPC.PPI%2Bcable.webp)  **Checking the communication Parameters for Micro/WIN:** Check that the location of the PC/PPI link in the Interchanges discourse box is set to 0.Check that the interface for the arrange parameter is set for PC/PPI cable(COM4).Check that the transmission rate is set to 9.6 kbps [![communication Parameters for Micro/WIN](E:\codes\Industry\Siemens\上载\Imag\communication-PC.PPI.webp)](https://1.bp.blogspot.com/-oFNbaNbylew/Xo75HZa3IjI/AAAAAAAAHo4/XZW48dE6bYIs8VlraV3-42DUzSu0HDZewCNcBGAsYHQ/s1600/communication-PC.PPI.webp)  Double tap the " connection ", the accompanying figure: [![CPU 224 REL](E:\codes\Industry\Siemens\上载\Imag\CPU-224-REL.webp)](https://1.bp.blogspot.com/-yT8lDarBmJM/Xo76Aaax6DI/AAAAAAAAHpA/-8MHsHWnRpsoaBwOiIzATDypDa_qYIgsACNcBGAsYHQ/s1600/CPU-224-REL.webp) [![Upload Siemens S7-200 Program](E:\codes\Industry\Siemens\上载\Imag\upload-button-CPU-224.webp)](https://1.bp.blogspot.com/-_43awWbXBOg/Xo77OiyvEaI/AAAAAAAAHpM/R0Js67gS_hMQTW7uI-rOGrc0vgHu5aF8gCNcBGAsYHQ/s1600/upload-button-CPU-224.webp)At the point when you transfer a project to your PC utilizing Micro/WIN, the S7-200 transfers the program and memory.  To transfer your Project from a S7-200 CPU: Select the File > Upload menu order. Snap the Upload Button. [![Upload Siemens S7-200 Program](E:\codes\Industry\Siemens\上载\Imag\upload+CPU+224.webp)](https://1.bp.blogspot.com/-qEsSANQJhTA/Xo78ltn6t2I/AAAAAAAAHpY/DRwKJMLO7245ACjsjoZg7o_R9HbJngckACNcBGAsYHQ/s1600/upload%2BCPU%2B224.webp) The program is being uploaded to the PC [![program S7-200 is being uploaded to the PC](E:\codes\Industry\Siemens\上载\Imag\uploading+start+for+CPU+224.webp)](https://1.bp.blogspot.com/-Fl6p3-rq3rE/Xo7-W7I8PxI/AAAAAAAAHpk/ZqNbL2Tb5n8lOyUlXttGSP0U05t4F3UuQCNcBGAsYHQ/s1600/uploading%2Bstart%2Bfor%2BCPU%2B224.webp)  The Program uploads successfully [![Program S7-200 uploads successfully](E:\codes\Industry\Siemens\上载\Imag\program+CPU+224.webp)](https://1.bp.blogspot.com/-Kf7ociPj4Ps/Xo7-_kyBXGI/AAAAAAAAHps/8BNzCDEC-wwYtvhwRZis0wBIh7VU7tVdQCNcBGAsYHQ/s1600/program%2BCPU%2B224.webp)     From here we have finished the subject of the **upload Siemens S7-200** Program using PPI cable from PLC to PC, if you like it, please share it with friends until it benefits, and then meet on a new topic on blog PLC Technical. Regards,PLC Technical