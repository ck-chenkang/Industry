
namespace FanucFocasDemo
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.port = new System.Windows.Forms.TextBox();
            this.ip = new System.Windows.Forms.TextBox();
            this.connection = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCNCModel = new System.Windows.Forms.TextBox();
            this.txtCurrentpg = new System.Windows.Forms.TextBox();
            this.txtMainpg = new System.Windows.Forms.TextBox();
            this.txtDevStatus = new System.Windows.Forms.TextBox();
            this.txtMaxAxis = new System.Windows.Forms.TextBox();
            this.txtCNCType = new System.Windows.Forms.TextBox();
            this.txtFeedOverRide = new System.Windows.Forms.TextBox();
            this.txtSerialNumber = new System.Windows.Forms.TextBox();
            this.txtFeedRate = new System.Windows.Forms.TextBox();
            this.txtSpeed = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txttotalparts = new System.Windows.Forms.TextBox();
            this.txtPartCnt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtPoweOnTime = new System.Windows.Forms.TextBox();
            this.txtworkingTime = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtCutTime = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtYAbsolutely = new System.Windows.Forms.TextBox();
            this.txtXRelative = new System.Windows.Forms.TextBox();
            this.txtXAbsolutely = new System.Windows.Forms.TextBox();
            this.txtYRelative = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "端口";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "IP";
            // 
            // port
            // 
            this.port.Location = new System.Drawing.Point(272, 12);
            this.port.Name = "port";
            this.port.Size = new System.Drawing.Size(100, 25);
            this.port.TabIndex = 3;
            this.port.Text = "8193";
            // 
            // ip
            // 
            this.ip.Location = new System.Drawing.Point(47, 12);
            this.ip.Name = "ip";
            this.ip.Size = new System.Drawing.Size(138, 25);
            this.ip.TabIndex = 4;
            this.ip.Text = "192.168.1.100";
            // 
            // connection
            // 
            this.connection.Location = new System.Drawing.Point(448, 15);
            this.connection.Name = "connection";
            this.connection.Size = new System.Drawing.Size(76, 30);
            this.connection.TabIndex = 7;
            this.connection.Text = "连接";
            this.connection.UseVisualStyleBackColor = true;
            this.connection.Click += new System.EventHandler(this.connection_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(239, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 15);
            this.label6.TabIndex = 29;
            this.label6.Text = "cnc工作模式";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(239, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 27;
            this.label4.Text = "CNC类型";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(239, 251);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 15);
            this.label11.TabIndex = 26;
            this.label11.Text = "进给倍率";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(239, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 15);
            this.label7.TabIndex = 25;
            this.label7.Text = "切削实际速度";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(239, 308);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 15);
            this.label10.TabIndex = 23;
            this.label10.Text = "当前程序号";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(2, 308);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 15);
            this.label9.TabIndex = 22;
            this.label9.Text = "主程序号";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 251);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 15);
            this.label8.TabIndex = 21;
            this.label8.Text = "设备状态";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 20;
            this.label5.Text = "最大轴数";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(4, 137);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 15);
            this.label12.TabIndex = 28;
            this.label12.Text = "CNC型号";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(4, 82);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 15);
            this.label13.TabIndex = 19;
            this.label13.Text = "主轴转速";
            // 
            // txtCNCModel
            // 
            this.txtCNCModel.Location = new System.Drawing.Point(352, 189);
            this.txtCNCModel.Name = "txtCNCModel";
            this.txtCNCModel.Size = new System.Drawing.Size(100, 25);
            this.txtCNCModel.TabIndex = 17;
            // 
            // txtCurrentpg
            // 
            this.txtCurrentpg.Location = new System.Drawing.Point(352, 305);
            this.txtCurrentpg.Name = "txtCurrentpg";
            this.txtCurrentpg.Size = new System.Drawing.Size(100, 25);
            this.txtCurrentpg.TabIndex = 16;
            // 
            // txtMainpg
            // 
            this.txtMainpg.Location = new System.Drawing.Point(100, 308);
            this.txtMainpg.Name = "txtMainpg";
            this.txtMainpg.Size = new System.Drawing.Size(100, 25);
            this.txtMainpg.TabIndex = 15;
            // 
            // txtDevStatus
            // 
            this.txtDevStatus.Location = new System.Drawing.Point(100, 248);
            this.txtDevStatus.Name = "txtDevStatus";
            this.txtDevStatus.Size = new System.Drawing.Size(100, 25);
            this.txtDevStatus.TabIndex = 14;
            // 
            // txtMaxAxis
            // 
            this.txtMaxAxis.Location = new System.Drawing.Point(100, 189);
            this.txtMaxAxis.Name = "txtMaxAxis";
            this.txtMaxAxis.Size = new System.Drawing.Size(100, 25);
            this.txtMaxAxis.TabIndex = 13;
            // 
            // txtCNCType
            // 
            this.txtCNCType.Location = new System.Drawing.Point(352, 134);
            this.txtCNCType.Name = "txtCNCType";
            this.txtCNCType.Size = new System.Drawing.Size(100, 25);
            this.txtCNCType.TabIndex = 12;
            // 
            // txtFeedOverRide
            // 
            this.txtFeedOverRide.Location = new System.Drawing.Point(352, 248);
            this.txtFeedOverRide.Name = "txtFeedOverRide";
            this.txtFeedOverRide.Size = new System.Drawing.Size(100, 25);
            this.txtFeedOverRide.TabIndex = 11;
            // 
            // txtSerialNumber
            // 
            this.txtSerialNumber.Location = new System.Drawing.Point(100, 137);
            this.txtSerialNumber.Name = "txtSerialNumber";
            this.txtSerialNumber.Size = new System.Drawing.Size(100, 25);
            this.txtSerialNumber.TabIndex = 10;
            // 
            // txtFeedRate
            // 
            this.txtFeedRate.Location = new System.Drawing.Point(352, 79);
            this.txtFeedRate.Name = "txtFeedRate";
            this.txtFeedRate.Size = new System.Drawing.Size(100, 25);
            this.txtFeedRate.TabIndex = 9;
            // 
            // txtSpeed
            // 
            this.txtSpeed.Location = new System.Drawing.Point(100, 82);
            this.txtSpeed.Name = "txtSpeed";
            this.txtSpeed.Size = new System.Drawing.Size(100, 25);
            this.txtSpeed.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(589, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 32);
            this.button1.TabIndex = 30;
            this.button1.Text = "采集数据";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txttotalparts
            // 
            this.txttotalparts.Location = new System.Drawing.Point(352, 352);
            this.txttotalparts.Name = "txttotalparts";
            this.txttotalparts.Size = new System.Drawing.Size(100, 25);
            this.txttotalparts.TabIndex = 11;
            // 
            // txtPartCnt
            // 
            this.txtPartCnt.Location = new System.Drawing.Point(100, 352);
            this.txtPartCnt.Name = "txtPartCnt";
            this.txtPartCnt.Size = new System.Drawing.Size(100, 25);
            this.txtPartCnt.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 355);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 21;
            this.label3.Text = "单次加工数";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(239, 355);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 15);
            this.label14.TabIndex = 26;
            this.label14.Text = "工件总数";
            // 
            // txtPoweOnTime
            // 
            this.txtPoweOnTime.Location = new System.Drawing.Point(100, 397);
            this.txtPoweOnTime.Name = "txtPoweOnTime";
            this.txtPoweOnTime.Size = new System.Drawing.Size(100, 25);
            this.txtPoweOnTime.TabIndex = 15;
            // 
            // txtworkingTime
            // 
            this.txtworkingTime.Location = new System.Drawing.Point(352, 404);
            this.txtworkingTime.Name = "txtworkingTime";
            this.txtworkingTime.Size = new System.Drawing.Size(100, 25);
            this.txtworkingTime.TabIndex = 16;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(2, 407);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 15);
            this.label15.TabIndex = 22;
            this.label15.Text = "开机时间";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(239, 407);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(67, 15);
            this.label16.TabIndex = 23;
            this.label16.Text = "运行时间";
            // 
            // txtCutTime
            // 
            this.txtCutTime.Location = new System.Drawing.Point(621, 404);
            this.txtCutTime.Name = "txtCutTime";
            this.txtCutTime.Size = new System.Drawing.Size(100, 25);
            this.txtCutTime.TabIndex = 16;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(508, 407);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(67, 15);
            this.label17.TabIndex = 23;
            this.label17.Text = "切削时间";
            // 
            // txtYAbsolutely
            // 
            this.txtYAbsolutely.Location = new System.Drawing.Point(352, 520);
            this.txtYAbsolutely.Name = "txtYAbsolutely";
            this.txtYAbsolutely.Size = new System.Drawing.Size(100, 25);
            this.txtYAbsolutely.TabIndex = 11;
            // 
            // txtXRelative
            // 
            this.txtXRelative.Location = new System.Drawing.Point(100, 461);
            this.txtXRelative.Name = "txtXRelative";
            this.txtXRelative.Size = new System.Drawing.Size(100, 25);
            this.txtXRelative.TabIndex = 13;
            // 
            // txtXAbsolutely
            // 
            this.txtXAbsolutely.Location = new System.Drawing.Point(100, 520);
            this.txtXAbsolutely.Name = "txtXAbsolutely";
            this.txtXAbsolutely.Size = new System.Drawing.Size(100, 25);
            this.txtXAbsolutely.TabIndex = 14;
            // 
            // txtYRelative
            // 
            this.txtYRelative.Location = new System.Drawing.Point(352, 461);
            this.txtYRelative.Name = "txtYRelative";
            this.txtYRelative.Size = new System.Drawing.Size(100, 25);
            this.txtYRelative.TabIndex = 17;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(4, 464);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(60, 15);
            this.label18.TabIndex = 20;
            this.label18.Text = "X轴坐标";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(4, 523);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(90, 15);
            this.label19.TabIndex = 21;
            this.label19.Text = "X轴绝对坐标";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(239, 523);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(90, 15);
            this.label20.TabIndex = 26;
            this.label20.Text = "Y轴绝对坐标";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(239, 464);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(60, 15);
            this.label21.TabIndex = 29;
            this.label21.Text = "Y轴坐标";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 605);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtYRelative);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtCNCModel);
            this.Controls.Add(this.txtCutTime);
            this.Controls.Add(this.txtworkingTime);
            this.Controls.Add(this.txtPoweOnTime);
            this.Controls.Add(this.txtCurrentpg);
            this.Controls.Add(this.txtMainpg);
            this.Controls.Add(this.txtXAbsolutely);
            this.Controls.Add(this.txtPartCnt);
            this.Controls.Add(this.txtXRelative);
            this.Controls.Add(this.txtDevStatus);
            this.Controls.Add(this.txtMaxAxis);
            this.Controls.Add(this.txtCNCType);
            this.Controls.Add(this.txtYAbsolutely);
            this.Controls.Add(this.txttotalparts);
            this.Controls.Add(this.txtFeedOverRide);
            this.Controls.Add(this.txtSerialNumber);
            this.Controls.Add(this.txtFeedRate);
            this.Controls.Add(this.txtSpeed);
            this.Controls.Add(this.connection);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.port);
            this.Controls.Add(this.ip);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox port;
        private System.Windows.Forms.TextBox ip;
        private System.Windows.Forms.Button connection;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtCNCModel;
        private System.Windows.Forms.TextBox txtCurrentpg;
        private System.Windows.Forms.TextBox txtMainpg;
        private System.Windows.Forms.TextBox txtDevStatus;
        private System.Windows.Forms.TextBox txtMaxAxis;
        private System.Windows.Forms.TextBox txtCNCType;
        private System.Windows.Forms.TextBox txtFeedOverRide;
        private System.Windows.Forms.TextBox txtSerialNumber;
        private System.Windows.Forms.TextBox txtFeedRate;
        private System.Windows.Forms.TextBox txtSpeed;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txttotalparts;
        private System.Windows.Forms.TextBox txtPartCnt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtPoweOnTime;
        private System.Windows.Forms.TextBox txtworkingTime;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtCutTime;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtYAbsolutely;
        private System.Windows.Forms.TextBox txtXRelative;
        private System.Windows.Forms.TextBox txtXAbsolutely;
        private System.Windows.Forms.TextBox txtYRelative;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
    }
}

