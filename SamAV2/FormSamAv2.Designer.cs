namespace SamAV2
{
    partial class FormSamAv2
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改這個方法的內容。
        ///
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSamAv2));
            this.txtProtocol = new System.Windows.Forms.TextBox();
            this.lblProtocol = new System.Windows.Forms.Label();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtATR = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboReaders = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClearMessage = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabMinimal = new System.Windows.Forms.TabPage();
            this.btnDumpAllKeyEntries = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKeyNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGetKeyEntry = new System.Windows.Forms.Button();
            this.btnGetVersion = new System.Windows.Forms.Button();
            this.tabDES = new System.Windows.Forms.TabPage();
            this.txtRandomNumber = new System.Windows.Forms.TextBox();
            this.btnGenRandom = new System.Windows.Forms.Button();
            this.btnDesDecryption = new System.Windows.Forms.Button();
            this.btnDesEncryption = new System.Windows.Forms.Button();
            this.txtDesCypherData = new System.Windows.Forms.TextBox();
            this.txtDesPlainData = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDesCbcIV = new System.Windows.Forms.TextBox();
            this.txtDesKey3 = new System.Windows.Forms.TextBox();
            this.txtDesKey2 = new System.Windows.Forms.TextBox();
            this.txtDesKey1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.chkDesCbcMode = new System.Windows.Forms.CheckBox();
            this.radio3TDEA = new System.Windows.Forms.RadioButton();
            this.radio2TDEA = new System.Windows.Forms.RadioButton();
            this.radioDES = new System.Windows.Forms.RadioButton();
            this.tabTHSRC = new System.Windows.Forms.TabPage();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.btnKillAuthen = new System.Windows.Forms.Button();
            this.grpPiccIssuer = new System.Windows.Forms.GroupBox();
            this.radioIssuerEasyCard = new System.Windows.Forms.RadioButton();
            this.radioIssuerThsrc = new System.Windows.Forms.RadioButton();
            this.grpPiccKeyType = new System.Windows.Forms.GroupBox();
            this.radioPiccKeyB = new System.Windows.Forms.RadioButton();
            this.radioPiccKeyA = new System.Windows.Forms.RadioButton();
            this.btnPiccAuthenAllSecs = new System.Windows.Forms.Button();
            this.txtPiccSN = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnPiccCardRequest = new System.Windows.Forms.Button();
            this.txtPiccWriteData = new System.Windows.Forms.TextBox();
            this.txtPiccReadData = new System.Windows.Forms.TextBox();
            this.btnPiccWrite = new System.Windows.Forms.Button();
            this.btnPiccRead = new System.Windows.Forms.Button();
            this.txtPiccBlockNo = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnPiccAuthen = new System.Windows.Forms.Button();
            this.btnThsrcSamAuthen = new System.Windows.Forms.Button();
            this.txtThsrcKeyFile = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSelectKeyFile = new System.Windows.Forms.Button();
            this.btnSendApdu = new System.Windows.Forms.Button();
            this.txtAPDU = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chkSaveLog = new System.Windows.Forms.CheckBox();
            this.label15 = new System.Windows.Forms.Label();
            this.comboComPorts = new System.Windows.Forms.ComboBox();
            this.txtFwVersion = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnComOpen = new System.Windows.Forms.Button();
            this.btnComClose = new System.Windows.Forms.Button();
            this.txtLibVersion = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabMinimal.SuspendLayout();
            this.tabDES.SuspendLayout();
            this.tabTHSRC.SuspendLayout();
            this.grpPiccIssuer.SuspendLayout();
            this.grpPiccKeyType.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtProtocol
            // 
            this.txtProtocol.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtProtocol.Location = new System.Drawing.Point(767, 36);
            this.txtProtocol.MaxLength = 2;
            this.txtProtocol.Name = "txtProtocol";
            this.txtProtocol.ReadOnly = true;
            this.txtProtocol.Size = new System.Drawing.Size(35, 27);
            this.txtProtocol.TabIndex = 28;
            this.txtProtocol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblProtocol
            // 
            this.lblProtocol.AutoSize = true;
            this.lblProtocol.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblProtocol.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblProtocol.Location = new System.Drawing.Point(765, 22);
            this.lblProtocol.Name = "lblProtocol";
            this.lblProtocol.Size = new System.Drawing.Size(44, 12);
            this.lblProtocol.TabIndex = 27;
            this.lblProtocol.Text = "Protocol";
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Enabled = false;
            this.btnDisconnect.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDisconnect.Location = new System.Drawing.Point(511, 5);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(100, 25);
            this.btnDisconnect.TabIndex = 26;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnConnect.Location = new System.Drawing.Point(394, 5);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(100, 25);
            this.btnConnect.TabIndex = 25;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtATR
            // 
            this.txtATR.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtATR.Location = new System.Drawing.Point(72, 36);
            this.txtATR.Name = "txtATR";
            this.txtATR.ReadOnly = true;
            this.txtATR.Size = new System.Drawing.Size(689, 27);
            this.txtATR.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "ATR: ";
            // 
            // comboReaders
            // 
            this.comboReaders.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboReaders.FormattingEnabled = true;
            this.comboReaders.Location = new System.Drawing.Point(111, 6);
            this.comboReaders.Name = "comboReaders";
            this.comboReaders.Size = new System.Drawing.Size(265, 24);
            this.comboReaders.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "PCSC Reader:";
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(12, 144);
            this.txtMessage.MaxLength = 131072;
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ReadOnly = true;
            this.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMessage.Size = new System.Drawing.Size(913, 241);
            this.txtMessage.TabIndex = 29;
            this.txtMessage.TextChanged += new System.EventHandler(this.txtMessage_TextChanged);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnExit.Location = new System.Drawing.Point(933, 9);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 32);
            this.btnExit.TabIndex = 31;
            this.btnExit.Text = "離開程式";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClearMessage
            // 
            this.btnClearMessage.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClearMessage.Location = new System.Drawing.Point(933, 145);
            this.btnClearMessage.Name = "btnClearMessage";
            this.btnClearMessage.Size = new System.Drawing.Size(94, 30);
            this.btnClearMessage.TabIndex = 30;
            this.btnClearMessage.Text = "清除訊息";
            this.btnClearMessage.UseVisualStyleBackColor = true;
            this.btnClearMessage.Click += new System.EventHandler(this.btnClearMessage_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabMinimal);
            this.tabControl.Controls.Add(this.tabDES);
            this.tabControl.Controls.Add(this.tabTHSRC);
            this.tabControl.Enabled = false;
            this.tabControl.Location = new System.Drawing.Point(12, 393);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(913, 190);
            this.tabControl.TabIndex = 32;
            // 
            // tabMinimal
            // 
            this.tabMinimal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabMinimal.Controls.Add(this.btnDumpAllKeyEntries);
            this.tabMinimal.Controls.Add(this.label5);
            this.tabMinimal.Controls.Add(this.txtKeyNo);
            this.tabMinimal.Controls.Add(this.label4);
            this.tabMinimal.Controls.Add(this.btnGetKeyEntry);
            this.tabMinimal.Controls.Add(this.btnGetVersion);
            this.tabMinimal.Location = new System.Drawing.Point(4, 22);
            this.tabMinimal.Name = "tabMinimal";
            this.tabMinimal.Padding = new System.Windows.Forms.Padding(3);
            this.tabMinimal.Size = new System.Drawing.Size(905, 164);
            this.tabMinimal.TabIndex = 0;
            this.tabMinimal.Text = "Minimal";
            this.tabMinimal.UseVisualStyleBackColor = true;
            // 
            // btnDumpAllKeyEntries
            // 
            this.btnDumpAllKeyEntries.Location = new System.Drawing.Point(259, 57);
            this.btnDumpAllKeyEntries.Name = "btnDumpAllKeyEntries";
            this.btnDumpAllKeyEntries.Size = new System.Drawing.Size(150, 23);
            this.btnDumpAllKeyEntries.TabIndex = 5;
            this.btnDumpAllKeyEntries.Text = "Dump All Key Entries";
            this.btnDumpAllKeyEntries.UseVisualStyleBackColor = true;
            this.btnDumpAllKeyEntries.Click += new System.EventHandler(this.btnDumpAllKeyEntries_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(188, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "(0 ~ 127)";
            // 
            // txtKeyNo
            // 
            this.txtKeyNo.Location = new System.Drawing.Point(149, 57);
            this.txtKeyNo.MaxLength = 3;
            this.txtKeyNo.Name = "txtKeyNo";
            this.txtKeyNo.Size = new System.Drawing.Size(36, 22);
            this.txtKeyNo.TabIndex = 3;
            this.txtKeyNo.Text = "0";
            this.txtKeyNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtKeyNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtKeyNo_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(106, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "KeyNo:";
            // 
            // btnGetKeyEntry
            // 
            this.btnGetKeyEntry.Location = new System.Drawing.Point(6, 55);
            this.btnGetKeyEntry.Name = "btnGetKeyEntry";
            this.btnGetKeyEntry.Size = new System.Drawing.Size(90, 23);
            this.btnGetKeyEntry.TabIndex = 1;
            this.btnGetKeyEntry.Text = "GetKeyEntry";
            this.btnGetKeyEntry.UseVisualStyleBackColor = true;
            this.btnGetKeyEntry.Click += new System.EventHandler(this.btnGetKeyEntry_Click);
            // 
            // btnGetVersion
            // 
            this.btnGetVersion.Location = new System.Drawing.Point(6, 15);
            this.btnGetVersion.Name = "btnGetVersion";
            this.btnGetVersion.Size = new System.Drawing.Size(90, 23);
            this.btnGetVersion.TabIndex = 0;
            this.btnGetVersion.Text = "GetVersion";
            this.btnGetVersion.UseVisualStyleBackColor = true;
            this.btnGetVersion.Click += new System.EventHandler(this.btnGetVersion_Click);
            // 
            // tabDES
            // 
            this.tabDES.Controls.Add(this.txtRandomNumber);
            this.tabDES.Controls.Add(this.btnGenRandom);
            this.tabDES.Controls.Add(this.btnDesDecryption);
            this.tabDES.Controls.Add(this.btnDesEncryption);
            this.tabDES.Controls.Add(this.txtDesCypherData);
            this.tabDES.Controls.Add(this.txtDesPlainData);
            this.tabDES.Controls.Add(this.label12);
            this.tabDES.Controls.Add(this.label11);
            this.tabDES.Controls.Add(this.txtDesCbcIV);
            this.tabDES.Controls.Add(this.txtDesKey3);
            this.tabDES.Controls.Add(this.txtDesKey2);
            this.tabDES.Controls.Add(this.txtDesKey1);
            this.tabDES.Controls.Add(this.label10);
            this.tabDES.Controls.Add(this.label9);
            this.tabDES.Controls.Add(this.label8);
            this.tabDES.Controls.Add(this.label7);
            this.tabDES.Controls.Add(this.chkDesCbcMode);
            this.tabDES.Controls.Add(this.radio3TDEA);
            this.tabDES.Controls.Add(this.radio2TDEA);
            this.tabDES.Controls.Add(this.radioDES);
            this.tabDES.Location = new System.Drawing.Point(4, 22);
            this.tabDES.Name = "tabDES";
            this.tabDES.Padding = new System.Windows.Forms.Padding(3);
            this.tabDES.Size = new System.Drawing.Size(905, 164);
            this.tabDES.TabIndex = 1;
            this.tabDES.Text = "DES";
            this.tabDES.UseVisualStyleBackColor = true;
            // 
            // txtRandomNumber
            // 
            this.txtRandomNumber.Location = new System.Drawing.Point(754, 19);
            this.txtRandomNumber.Name = "txtRandomNumber";
            this.txtRandomNumber.ReadOnly = true;
            this.txtRandomNumber.Size = new System.Drawing.Size(136, 22);
            this.txtRandomNumber.TabIndex = 19;
            // 
            // btnGenRandom
            // 
            this.btnGenRandom.Location = new System.Drawing.Point(667, 18);
            this.btnGenRandom.Name = "btnGenRandom";
            this.btnGenRandom.Size = new System.Drawing.Size(82, 23);
            this.btnGenRandom.TabIndex = 18;
            this.btnGenRandom.Text = "Gen Random";
            this.btnGenRandom.UseVisualStyleBackColor = true;
            this.btnGenRandom.Click += new System.EventHandler(this.btnGenRandom_Click);
            // 
            // btnDesDecryption
            // 
            this.btnDesDecryption.Location = new System.Drawing.Point(494, 18);
            this.btnDesDecryption.Name = "btnDesDecryption";
            this.btnDesDecryption.Size = new System.Drawing.Size(110, 23);
            this.btnDesDecryption.TabIndex = 17;
            this.btnDesDecryption.Text = "Decryption";
            this.btnDesDecryption.UseVisualStyleBackColor = true;
            this.btnDesDecryption.Click += new System.EventHandler(this.btnDesDecryption_Click);
            // 
            // btnDesEncryption
            // 
            this.btnDesEncryption.Location = new System.Drawing.Point(370, 18);
            this.btnDesEncryption.Name = "btnDesEncryption";
            this.btnDesEncryption.Size = new System.Drawing.Size(110, 23);
            this.btnDesEncryption.TabIndex = 16;
            this.btnDesEncryption.Text = "Encryption";
            this.btnDesEncryption.UseVisualStyleBackColor = true;
            this.btnDesEncryption.Click += new System.EventHandler(this.btnDesEncryption_Click);
            // 
            // txtDesCypherData
            // 
            this.txtDesCypherData.Location = new System.Drawing.Point(78, 128);
            this.txtDesCypherData.Name = "txtDesCypherData";
            this.txtDesCypherData.ReadOnly = true;
            this.txtDesCypherData.Size = new System.Drawing.Size(812, 22);
            this.txtDesCypherData.TabIndex = 15;
            // 
            // txtDesPlainData
            // 
            this.txtDesPlainData.Location = new System.Drawing.Point(78, 95);
            this.txtDesPlainData.Name = "txtDesPlainData";
            this.txtDesPlainData.Size = new System.Drawing.Size(812, 22);
            this.txtDesPlainData.TabIndex = 14;
            this.txtDesPlainData.Text = "60 61 62 63 64 65 66 67 68 69 6A 6B 6C 6D 6E 6F";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 131);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 12);
            this.label12.TabIndex = 13;
            this.label12.Text = "Cypher Data:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 99);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 12);
            this.label11.TabIndex = 12;
            this.label11.Text = "Plain Data:";
            // 
            // txtDesCbcIV
            // 
            this.txtDesCbcIV.Location = new System.Drawing.Point(604, 57);
            this.txtDesCbcIV.MaxLength = 48;
            this.txtDesCbcIV.Name = "txtDesCbcIV";
            this.txtDesCbcIV.Size = new System.Drawing.Size(136, 22);
            this.txtDesCbcIV.TabIndex = 11;
            this.txtDesCbcIV.Text = "00 00 00 00 00 00 00 00";
            // 
            // txtDesKey3
            // 
            this.txtDesKey3.Enabled = false;
            this.txtDesKey3.Location = new System.Drawing.Point(428, 57);
            this.txtDesKey3.MaxLength = 24;
            this.txtDesKey3.Name = "txtDesKey3";
            this.txtDesKey3.Size = new System.Drawing.Size(136, 22);
            this.txtDesKey3.TabIndex = 10;
            this.txtDesKey3.Text = "20 21 22 23 24 25 26 27";
            // 
            // txtDesKey2
            // 
            this.txtDesKey2.Location = new System.Drawing.Point(238, 57);
            this.txtDesKey2.MaxLength = 24;
            this.txtDesKey2.Name = "txtDesKey2";
            this.txtDesKey2.Size = new System.Drawing.Size(136, 22);
            this.txtDesKey2.TabIndex = 9;
            this.txtDesKey2.Text = "40 41 42 43 44 45 46 47";
            // 
            // txtDesKey1
            // 
            this.txtDesKey1.Location = new System.Drawing.Point(48, 57);
            this.txtDesKey1.MaxLength = 24;
            this.txtDesKey1.Name = "txtDesKey1";
            this.txtDesKey1.Size = new System.Drawing.Size(136, 22);
            this.txtDesKey1.TabIndex = 8;
            this.txtDesKey1.Text = "30 31 32 33 34 35 36 37";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(580, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 12);
            this.label10.TabIndex = 7;
            this.label10.Text = "IV:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(390, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 12);
            this.label9.TabIndex = 6;
            this.label9.Text = "Key 3:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(200, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 12);
            this.label8.TabIndex = 5;
            this.label8.Text = "Key 2:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 12);
            this.label7.TabIndex = 4;
            this.label7.Text = "Key 1:";
            // 
            // chkDesCbcMode
            // 
            this.chkDesCbcMode.AutoSize = true;
            this.chkDesCbcMode.Checked = true;
            this.chkDesCbcMode.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDesCbcMode.Location = new System.Drawing.Point(270, 21);
            this.chkDesCbcMode.Name = "chkDesCbcMode";
            this.chkDesCbcMode.Size = new System.Drawing.Size(78, 16);
            this.chkDesCbcMode.TabIndex = 3;
            this.chkDesCbcMode.Text = "CBC Mode";
            this.chkDesCbcMode.UseVisualStyleBackColor = true;
            this.chkDesCbcMode.CheckedChanged += new System.EventHandler(this.chkDesCbcMode_CheckedChanged);
            // 
            // radio3TDEA
            // 
            this.radio3TDEA.AutoSize = true;
            this.radio3TDEA.Location = new System.Drawing.Point(180, 21);
            this.radio3TDEA.Name = "radio3TDEA";
            this.radio3TDEA.Size = new System.Drawing.Size(59, 16);
            this.radio3TDEA.TabIndex = 2;
            this.radio3TDEA.Text = "3TDEA";
            this.radio3TDEA.UseVisualStyleBackColor = true;
            this.radio3TDEA.CheckedChanged += new System.EventHandler(this.radio3TDEA_CheckedChanged);
            // 
            // radio2TDEA
            // 
            this.radio2TDEA.AutoSize = true;
            this.radio2TDEA.Checked = true;
            this.radio2TDEA.Location = new System.Drawing.Point(100, 21);
            this.radio2TDEA.Name = "radio2TDEA";
            this.radio2TDEA.Size = new System.Drawing.Size(59, 16);
            this.radio2TDEA.TabIndex = 1;
            this.radio2TDEA.TabStop = true;
            this.radio2TDEA.Text = "2TDEA";
            this.radio2TDEA.UseVisualStyleBackColor = true;
            this.radio2TDEA.CheckedChanged += new System.EventHandler(this.radio2TDEA_CheckedChanged);
            // 
            // radioDES
            // 
            this.radioDES.AutoSize = true;
            this.radioDES.Location = new System.Drawing.Point(30, 21);
            this.radioDES.Name = "radioDES";
            this.radioDES.Size = new System.Drawing.Size(44, 16);
            this.radioDES.TabIndex = 0;
            this.radioDES.Text = "DES";
            this.radioDES.UseVisualStyleBackColor = true;
            this.radioDES.CheckedChanged += new System.EventHandler(this.radioDES_CheckedChanged);
            // 
            // tabTHSRC
            // 
            this.tabTHSRC.Controls.Add(this.label20);
            this.tabTHSRC.Controls.Add(this.label19);
            this.tabTHSRC.Controls.Add(this.label18);
            this.tabTHSRC.Controls.Add(this.label17);
            this.tabTHSRC.Controls.Add(this.btnKillAuthen);
            this.tabTHSRC.Controls.Add(this.grpPiccIssuer);
            this.tabTHSRC.Controls.Add(this.grpPiccKeyType);
            this.tabTHSRC.Controls.Add(this.btnPiccAuthenAllSecs);
            this.tabTHSRC.Controls.Add(this.txtPiccSN);
            this.tabTHSRC.Controls.Add(this.label14);
            this.tabTHSRC.Controls.Add(this.btnPiccCardRequest);
            this.tabTHSRC.Controls.Add(this.txtPiccWriteData);
            this.tabTHSRC.Controls.Add(this.txtPiccReadData);
            this.tabTHSRC.Controls.Add(this.btnPiccWrite);
            this.tabTHSRC.Controls.Add(this.btnPiccRead);
            this.tabTHSRC.Controls.Add(this.txtPiccBlockNo);
            this.tabTHSRC.Controls.Add(this.label13);
            this.tabTHSRC.Controls.Add(this.btnPiccAuthen);
            this.tabTHSRC.Controls.Add(this.btnThsrcSamAuthen);
            this.tabTHSRC.Controls.Add(this.txtThsrcKeyFile);
            this.tabTHSRC.Controls.Add(this.label6);
            this.tabTHSRC.Controls.Add(this.btnSelectKeyFile);
            this.tabTHSRC.Location = new System.Drawing.Point(4, 22);
            this.tabTHSRC.Name = "tabTHSRC";
            this.tabTHSRC.Size = new System.Drawing.Size(905, 164);
            this.tabTHSRC.TabIndex = 2;
            this.tabTHSRC.Text = "THSRC";
            this.tabTHSRC.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.Color.Red;
            this.label20.Location = new System.Drawing.Point(140, 107);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(17, 12);
            this.label20.TabIndex = 23;
            this.label20.Text = "④";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.Color.Red;
            this.label19.Location = new System.Drawing.Point(139, 77);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(17, 12);
            this.label19.TabIndex = 22;
            this.label19.Text = "③";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.Red;
            this.label18.Location = new System.Drawing.Point(139, 48);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(17, 12);
            this.label18.TabIndex = 21;
            this.label18.Text = "②";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.Red;
            this.label17.Location = new System.Drawing.Point(7, 48);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(17, 12);
            this.label17.TabIndex = 20;
            this.label17.Text = "①";
            // 
            // btnKillAuthen
            // 
            this.btnKillAuthen.Location = new System.Drawing.Point(26, 80);
            this.btnKillAuthen.Name = "btnKillAuthen";
            this.btnKillAuthen.Size = new System.Drawing.Size(100, 23);
            this.btnKillAuthen.TabIndex = 19;
            this.btnKillAuthen.Text = "Kill Authen";
            this.btnKillAuthen.UseVisualStyleBackColor = true;
            this.btnKillAuthen.Click += new System.EventHandler(this.btnKillAuthen_Click);
            // 
            // grpPiccIssuer
            // 
            this.grpPiccIssuer.Controls.Add(this.radioIssuerEasyCard);
            this.grpPiccIssuer.Controls.Add(this.radioIssuerThsrc);
            this.grpPiccIssuer.Location = new System.Drawing.Point(718, 44);
            this.grpPiccIssuer.Name = "grpPiccIssuer";
            this.grpPiccIssuer.Size = new System.Drawing.Size(105, 75);
            this.grpPiccIssuer.TabIndex = 18;
            this.grpPiccIssuer.TabStop = false;
            this.grpPiccIssuer.Text = "PICC Issuer";
            // 
            // radioIssuerEasyCard
            // 
            this.radioIssuerEasyCard.AutoSize = true;
            this.radioIssuerEasyCard.Location = new System.Drawing.Point(9, 46);
            this.radioIssuerEasyCard.Name = "radioIssuerEasyCard";
            this.radioIssuerEasyCard.Size = new System.Drawing.Size(71, 16);
            this.radioIssuerEasyCard.TabIndex = 1;
            this.radioIssuerEasyCard.TabStop = true;
            this.radioIssuerEasyCard.Text = "Easy Card";
            this.radioIssuerEasyCard.UseVisualStyleBackColor = true;
            // 
            // radioIssuerThsrc
            // 
            this.radioIssuerThsrc.AutoSize = true;
            this.radioIssuerThsrc.Checked = true;
            this.radioIssuerThsrc.Location = new System.Drawing.Point(9, 21);
            this.radioIssuerThsrc.Name = "radioIssuerThsrc";
            this.radioIssuerThsrc.Size = new System.Drawing.Size(60, 16);
            this.radioIssuerThsrc.TabIndex = 0;
            this.radioIssuerThsrc.TabStop = true;
            this.radioIssuerThsrc.Text = "THSRC";
            this.radioIssuerThsrc.UseVisualStyleBackColor = true;
            // 
            // grpPiccKeyType
            // 
            this.grpPiccKeyType.Controls.Add(this.radioPiccKeyB);
            this.grpPiccKeyType.Controls.Add(this.radioPiccKeyA);
            this.grpPiccKeyType.Location = new System.Drawing.Point(597, 44);
            this.grpPiccKeyType.Name = "grpPiccKeyType";
            this.grpPiccKeyType.Size = new System.Drawing.Size(105, 75);
            this.grpPiccKeyType.TabIndex = 17;
            this.grpPiccKeyType.TabStop = false;
            this.grpPiccKeyType.Text = "PICC Key Type";
            // 
            // radioPiccKeyB
            // 
            this.radioPiccKeyB.AutoSize = true;
            this.radioPiccKeyB.Location = new System.Drawing.Point(9, 46);
            this.radioPiccKeyB.Name = "radioPiccKeyB";
            this.radioPiccKeyB.Size = new System.Drawing.Size(53, 16);
            this.radioPiccKeyB.TabIndex = 8;
            this.radioPiccKeyB.TabStop = true;
            this.radioPiccKeyB.Text = "Key B";
            this.radioPiccKeyB.UseVisualStyleBackColor = true;
            // 
            // radioPiccKeyA
            // 
            this.radioPiccKeyA.AutoSize = true;
            this.radioPiccKeyA.Checked = true;
            this.radioPiccKeyA.Location = new System.Drawing.Point(9, 21);
            this.radioPiccKeyA.Name = "radioPiccKeyA";
            this.radioPiccKeyA.Size = new System.Drawing.Size(53, 16);
            this.radioPiccKeyA.TabIndex = 7;
            this.radioPiccKeyA.TabStop = true;
            this.radioPiccKeyA.Text = "Key A";
            this.radioPiccKeyA.UseVisualStyleBackColor = true;
            // 
            // btnPiccAuthenAllSecs
            // 
            this.btnPiccAuthenAllSecs.Enabled = false;
            this.btnPiccAuthenAllSecs.Location = new System.Drawing.Point(405, 74);
            this.btnPiccAuthenAllSecs.Name = "btnPiccAuthenAllSecs";
            this.btnPiccAuthenAllSecs.Size = new System.Drawing.Size(157, 23);
            this.btnPiccAuthenAllSecs.TabIndex = 16;
            this.btnPiccAuthenAllSecs.Text = "PICC Authen All Secs";
            this.btnPiccAuthenAllSecs.UseVisualStyleBackColor = true;
            this.btnPiccAuthenAllSecs.Click += new System.EventHandler(this.btnPiccAuthenAllSecs_Click);
            // 
            // txtPiccSN
            // 
            this.txtPiccSN.Location = new System.Drawing.Point(355, 44);
            this.txtPiccSN.Name = "txtPiccSN";
            this.txtPiccSN.ReadOnly = true;
            this.txtPiccSN.Size = new System.Drawing.Size(189, 22);
            this.txtPiccSN.TabIndex = 15;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(293, 49);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 12);
            this.label14.TabIndex = 14;
            this.label14.Text = "PICC S/N:";
            // 
            // btnPiccCardRequest
            // 
            this.btnPiccCardRequest.Enabled = false;
            this.btnPiccCardRequest.Location = new System.Drawing.Point(158, 44);
            this.btnPiccCardRequest.Name = "btnPiccCardRequest";
            this.btnPiccCardRequest.Size = new System.Drawing.Size(110, 23);
            this.btnPiccCardRequest.TabIndex = 13;
            this.btnPiccCardRequest.Text = "PICC CardRequest";
            this.btnPiccCardRequest.UseVisualStyleBackColor = true;
            this.btnPiccCardRequest.Click += new System.EventHandler(this.btnPiccCardRequest_Click);
            // 
            // txtPiccWriteData
            // 
            this.txtPiccWriteData.Location = new System.Drawing.Point(291, 132);
            this.txtPiccWriteData.MaxLength = 48;
            this.txtPiccWriteData.Name = "txtPiccWriteData";
            this.txtPiccWriteData.Size = new System.Drawing.Size(284, 22);
            this.txtPiccWriteData.TabIndex = 12;
            this.txtPiccWriteData.Text = "30 31 32 33 34 35 36 37 38 39 3A 3B 3C 3D 3E 3F";
            // 
            // txtPiccReadData
            // 
            this.txtPiccReadData.Location = new System.Drawing.Point(290, 103);
            this.txtPiccReadData.Name = "txtPiccReadData";
            this.txtPiccReadData.ReadOnly = true;
            this.txtPiccReadData.Size = new System.Drawing.Size(285, 22);
            this.txtPiccReadData.TabIndex = 11;
            // 
            // btnPiccWrite
            // 
            this.btnPiccWrite.Enabled = false;
            this.btnPiccWrite.Location = new System.Drawing.Point(158, 131);
            this.btnPiccWrite.Name = "btnPiccWrite";
            this.btnPiccWrite.Size = new System.Drawing.Size(110, 23);
            this.btnPiccWrite.TabIndex = 10;
            this.btnPiccWrite.Text = "PICC Write";
            this.btnPiccWrite.UseVisualStyleBackColor = true;
            this.btnPiccWrite.Click += new System.EventHandler(this.btnPiccWrite_Click);
            // 
            // btnPiccRead
            // 
            this.btnPiccRead.Enabled = false;
            this.btnPiccRead.Location = new System.Drawing.Point(159, 102);
            this.btnPiccRead.Name = "btnPiccRead";
            this.btnPiccRead.Size = new System.Drawing.Size(110, 23);
            this.btnPiccRead.TabIndex = 9;
            this.btnPiccRead.Text = "PICC Read";
            this.btnPiccRead.UseVisualStyleBackColor = true;
            this.btnPiccRead.Click += new System.EventHandler(this.btnPiccRead_Click);
            // 
            // txtPiccBlockNo
            // 
            this.txtPiccBlockNo.Location = new System.Drawing.Point(355, 76);
            this.txtPiccBlockNo.MaxLength = 2;
            this.txtPiccBlockNo.Name = "txtPiccBlockNo";
            this.txtPiccBlockNo.Size = new System.Drawing.Size(29, 22);
            this.txtPiccBlockNo.TabIndex = 6;
            this.txtPiccBlockNo.Text = "4";
            this.txtPiccBlockNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(293, 80);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 12);
            this.label13.TabIndex = 5;
            this.label13.Text = "Block No.:";
            // 
            // btnPiccAuthen
            // 
            this.btnPiccAuthen.Enabled = false;
            this.btnPiccAuthen.Location = new System.Drawing.Point(158, 73);
            this.btnPiccAuthen.Name = "btnPiccAuthen";
            this.btnPiccAuthen.Size = new System.Drawing.Size(110, 23);
            this.btnPiccAuthen.TabIndex = 4;
            this.btnPiccAuthen.Text = "PICC Authen";
            this.btnPiccAuthen.UseVisualStyleBackColor = true;
            this.btnPiccAuthen.Click += new System.EventHandler(this.btnPiccAuthen_Click);
            // 
            // btnThsrcSamAuthen
            // 
            this.btnThsrcSamAuthen.Location = new System.Drawing.Point(26, 44);
            this.btnThsrcSamAuthen.Name = "btnThsrcSamAuthen";
            this.btnThsrcSamAuthen.Size = new System.Drawing.Size(100, 23);
            this.btnThsrcSamAuthen.TabIndex = 3;
            this.btnThsrcSamAuthen.Text = "SAM Authen";
            this.btnThsrcSamAuthen.UseVisualStyleBackColor = true;
            this.btnThsrcSamAuthen.Click += new System.EventHandler(this.btnThsrcSamAuthen_Click);
            // 
            // txtThsrcKeyFile
            // 
            this.txtThsrcKeyFile.Location = new System.Drawing.Point(108, 12);
            this.txtThsrcKeyFile.Name = "txtThsrcKeyFile";
            this.txtThsrcKeyFile.ReadOnly = true;
            this.txtThsrcKeyFile.Size = new System.Drawing.Size(668, 22);
            this.txtThsrcKeyFile.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 12);
            this.label6.TabIndex = 1;
            this.label6.Text = "THSRC Key File:";
            // 
            // btnSelectKeyFile
            // 
            this.btnSelectKeyFile.Location = new System.Drawing.Point(784, 11);
            this.btnSelectKeyFile.Name = "btnSelectKeyFile";
            this.btnSelectKeyFile.Size = new System.Drawing.Size(110, 23);
            this.btnSelectKeyFile.TabIndex = 0;
            this.btnSelectKeyFile.Text = "Change Key File";
            this.btnSelectKeyFile.UseVisualStyleBackColor = true;
            this.btnSelectKeyFile.Click += new System.EventHandler(this.btnSelectKeyFile_Click);
            // 
            // btnSendApdu
            // 
            this.btnSendApdu.Enabled = false;
            this.btnSendApdu.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSendApdu.Location = new System.Drawing.Point(832, 71);
            this.btnSendApdu.Name = "btnSendApdu";
            this.btnSendApdu.Size = new System.Drawing.Size(93, 25);
            this.btnSendApdu.TabIndex = 26;
            this.btnSendApdu.Text = "Send";
            this.btnSendApdu.UseVisualStyleBackColor = true;
            this.btnSendApdu.Click += new System.EventHandler(this.btnSendApdu_Click);
            // 
            // txtAPDU
            // 
            this.txtAPDU.Enabled = false;
            this.txtAPDU.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtAPDU.Location = new System.Drawing.Point(71, 69);
            this.txtAPDU.Name = "txtAPDU";
            this.txtAPDU.Size = new System.Drawing.Size(755, 27);
            this.txtAPDU.TabIndex = 25;
            this.txtAPDU.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAPDU_KeyDown);
            this.txtAPDU.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAPDU_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(12, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "APDU:";
            // 
            // chkSaveLog
            // 
            this.chkSaveLog.AutoSize = true;
            this.chkSaveLog.Checked = true;
            this.chkSaveLog.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSaveLog.Location = new System.Drawing.Point(935, 180);
            this.chkSaveLog.Name = "chkSaveLog";
            this.chkSaveLog.Size = new System.Drawing.Size(68, 16);
            this.chkSaveLog.TabIndex = 63;
            this.chkSaveLog.Text = "Save Log";
            this.chkSaveLog.UseVisualStyleBackColor = true;
            this.chkSaveLog.CheckedChanged += new System.EventHandler(this.chkSaveLog_CheckedChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label15.Location = new System.Drawing.Point(12, 112);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(109, 16);
            this.label15.TabIndex = 64;
            this.label15.Text = "MRD ComPort :";
            // 
            // comboComPorts
            // 
            this.comboComPorts.FormattingEnabled = true;
            this.comboComPorts.Location = new System.Drawing.Point(124, 112);
            this.comboComPorts.Name = "comboComPorts";
            this.comboComPorts.Size = new System.Drawing.Size(91, 20);
            this.comboComPorts.TabIndex = 65;
            // 
            // txtFwVersion
            // 
            this.txtFwVersion.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtFwVersion.Location = new System.Drawing.Point(497, 109);
            this.txtFwVersion.Name = "txtFwVersion";
            this.txtFwVersion.ReadOnly = true;
            this.txtFwVersion.Size = new System.Drawing.Size(97, 27);
            this.txtFwVersion.TabIndex = 67;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label16.Location = new System.Drawing.Point(454, 112);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(38, 16);
            this.label16.TabIndex = 66;
            this.label16.Text = "F/W:";
            // 
            // btnComOpen
            // 
            this.btnComOpen.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnComOpen.Location = new System.Drawing.Point(234, 106);
            this.btnComOpen.Name = "btnComOpen";
            this.btnComOpen.Size = new System.Drawing.Size(90, 30);
            this.btnComOpen.TabIndex = 68;
            this.btnComOpen.Text = "Open";
            this.btnComOpen.UseVisualStyleBackColor = true;
            this.btnComOpen.Click += new System.EventHandler(this.btnComOpen_Click);
            // 
            // btnComClose
            // 
            this.btnComClose.Enabled = false;
            this.btnComClose.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnComClose.Location = new System.Drawing.Point(331, 106);
            this.btnComClose.Name = "btnComClose";
            this.btnComClose.Size = new System.Drawing.Size(90, 30);
            this.btnComClose.TabIndex = 69;
            this.btnComClose.Text = "Close";
            this.btnComClose.UseVisualStyleBackColor = true;
            this.btnComClose.Click += new System.EventHandler(this.btnComClose_Click);
            // 
            // txtLibVersion
            // 
            this.txtLibVersion.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtLibVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtLibVersion.Location = new System.Drawing.Point(709, 109);
            this.txtLibVersion.Name = "txtLibVersion";
            this.txtLibVersion.ReadOnly = true;
            this.txtLibVersion.Size = new System.Drawing.Size(314, 27);
            this.txtLibVersion.TabIndex = 71;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label30.Location = new System.Drawing.Point(626, 112);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(79, 16);
            this.label30.TabIndex = 70;
            this.label30.Text = "MRD DLL:";
            // 
            // FormSamAv2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 589);
            this.Controls.Add(this.txtLibVersion);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.btnComClose);
            this.Controls.Add(this.btnComOpen);
            this.Controls.Add(this.txtFwVersion);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.comboComPorts);
            this.Controls.Add(this.chkSaveLog);
            this.Controls.Add(this.btnSendApdu);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.txtAPDU);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnClearMessage);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.txtProtocol);
            this.Controls.Add(this.lblProtocol);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtATR);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboReaders);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSamAv2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SAM AV2";
            this.Load += new System.EventHandler(this.FormSamAv2_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSamAv2_FormClosing);
            this.tabControl.ResumeLayout(false);
            this.tabMinimal.ResumeLayout(false);
            this.tabMinimal.PerformLayout();
            this.tabDES.ResumeLayout(false);
            this.tabDES.PerformLayout();
            this.tabTHSRC.ResumeLayout(false);
            this.tabTHSRC.PerformLayout();
            this.grpPiccIssuer.ResumeLayout(false);
            this.grpPiccIssuer.PerformLayout();
            this.grpPiccKeyType.ResumeLayout(false);
            this.grpPiccKeyType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtProtocol;
        private System.Windows.Forms.Label lblProtocol;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtATR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboReaders;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClearMessage;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabMinimal;
        private System.Windows.Forms.TabPage tabDES;
        private System.Windows.Forms.Button btnSendApdu;
        private System.Windows.Forms.TextBox txtAPDU;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGetVersion;
        private System.Windows.Forms.Button btnGetKeyEntry;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtKeyNo;
        private System.Windows.Forms.CheckBox chkSaveLog;
        private System.Windows.Forms.Button btnDumpAllKeyEntries;
        private System.Windows.Forms.TabPage tabTHSRC;
        private System.Windows.Forms.TextBox txtThsrcKeyFile;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSelectKeyFile;
        private System.Windows.Forms.RadioButton radio2TDEA;
        private System.Windows.Forms.RadioButton radioDES;
        private System.Windows.Forms.RadioButton radio3TDEA;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chkDesCbcMode;
        private System.Windows.Forms.TextBox txtDesKey3;
        private System.Windows.Forms.TextBox txtDesKey2;
        private System.Windows.Forms.TextBox txtDesKey1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDesCbcIV;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDesPlainData;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtDesCypherData;
        private System.Windows.Forms.Button btnDesEncryption;
        private System.Windows.Forms.Button btnDesDecryption;
        private System.Windows.Forms.Button btnThsrcSamAuthen;
        private System.Windows.Forms.TextBox txtRandomNumber;
        private System.Windows.Forms.Button btnGenRandom;
        private System.Windows.Forms.RadioButton radioPiccKeyB;
        private System.Windows.Forms.RadioButton radioPiccKeyA;
        private System.Windows.Forms.TextBox txtPiccBlockNo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnPiccAuthen;
        private System.Windows.Forms.Button btnPiccWrite;
        private System.Windows.Forms.Button btnPiccRead;
        private System.Windows.Forms.TextBox txtPiccWriteData;
        private System.Windows.Forms.TextBox txtPiccReadData;
        private System.Windows.Forms.Button btnPiccCardRequest;
        private System.Windows.Forms.TextBox txtPiccSN;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox comboComPorts;
        private System.Windows.Forms.TextBox txtFwVersion;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnComOpen;
        private System.Windows.Forms.Button btnComClose;
        private System.Windows.Forms.TextBox txtLibVersion;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Button btnPiccAuthenAllSecs;
        private System.Windows.Forms.GroupBox grpPiccKeyType;
        private System.Windows.Forms.GroupBox grpPiccIssuer;
        private System.Windows.Forms.RadioButton radioIssuerEasyCard;
        private System.Windows.Forms.RadioButton radioIssuerThsrc;
        private System.Windows.Forms.Button btnKillAuthen;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
    }
}

