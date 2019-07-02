namespace ArmBot
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnSendData = new System.Windows.Forms.Button();
            this.btnReadData = new System.Windows.Forms.Button();
            this.lstData = new System.Windows.Forms.ListBox();
            this.btnRunProgram = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label28 = new System.Windows.Forms.Label();
            this.btnWriteWholeProgram = new System.Windows.Forms.Button();
            this.btnReadWholeProgram = new System.Windows.Forms.Button();
            this.btnInitialPosition = new System.Windows.Forms.Button();
            this.lblProgress = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.pBar = new System.Windows.Forms.ProgressBar();
            this.btnSaveProgram = new System.Windows.Forms.Button();
            this.txtCurrentCommand = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnClearConsole = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSendCommand = new System.Windows.Forms.TextBox();
            this.numGripperGValue = new System.Windows.Forms.NumericUpDown();
            this.numGripperrotValue = new System.Windows.Forms.NumericUpDown();
            this.numGupValue = new System.Windows.Forms.NumericUpDown();
            this.numArmValue = new System.Windows.Forms.NumericUpDown();
            this.numShoulderValue = new System.Windows.Forms.NumericUpDown();
            this.numBodyValue = new System.Windows.Forms.NumericUpDown();
            this.Controller = new System.Windows.Forms.TabPage();
            this.btnCloseGripper = new System.Windows.Forms.Button();
            this.btnRecordStep = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtGripperGrip = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnGripperClose = new System.Windows.Forms.Button();
            this.btnGripperOpen = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtGripperRotate = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnGripperRotateRight = new System.Windows.Forms.Button();
            this.btnGripperRotateLeft = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtGripperLift = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnGripperMoveDown = new System.Windows.Forms.Button();
            this.btnGripperMoveUp = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtArmCoordinate = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnArmMoveUp = new System.Windows.Forms.Button();
            this.btnArmMoveDown = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtShoulderCoordinate = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnShoulderMoveUp = new System.Windows.Forms.Button();
            this.btnShoulderMoveDown = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBodyCoordinate = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnBodyMoveLeft = new System.Windows.Forms.Button();
            this.btnBodyMoveRight = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnConnectionSetup = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtData = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.rdbClientCheck = new System.Windows.Forms.RadioButton();
            this.rdbServerCheck = new System.Windows.Forms.RadioButton();
            this.label26 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtIpAddress = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.btnAboutProject = new System.Windows.Forms.Button();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtArmCharacter = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbBit = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbParity = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbBaudRate = new System.Windows.Forms.ComboBox();
            this.btnRefreshPorts = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPorts = new System.Windows.Forms.ComboBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtSpeed = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.backRunCode = new System.ComponentModel.BackgroundWorker();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGripperGValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGripperrotValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGupValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numArmValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numShoulderValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBodyValue)).BeginInit();
            this.Controller.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSendData
            // 
            this.btnSendData.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSendData.Location = new System.Drawing.Point(74, 363);
            this.btnSendData.Name = "btnSendData";
            this.btnSendData.Size = new System.Drawing.Size(251, 32);
            this.btnSendData.TabIndex = 20;
            this.btnSendData.Text = "SEND";
            this.btnSendData.UseVisualStyleBackColor = false;
            this.btnSendData.Click += new System.EventHandler(this.btnSendData_Click);
            // 
            // btnReadData
            // 
            this.btnReadData.BackColor = System.Drawing.Color.Gold;
            this.btnReadData.Location = new System.Drawing.Point(352, 363);
            this.btnReadData.Name = "btnReadData";
            this.btnReadData.Size = new System.Drawing.Size(281, 32);
            this.btnReadData.TabIndex = 21;
            this.btnReadData.Text = "READ";
            this.btnReadData.UseVisualStyleBackColor = false;
            this.btnReadData.Click += new System.EventHandler(this.btnReadData_Click);
            // 
            // lstData
            // 
            this.lstData.BackColor = System.Drawing.Color.Black;
            this.lstData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstData.ForeColor = System.Drawing.Color.White;
            this.lstData.FormattingEnabled = true;
            this.lstData.Location = new System.Drawing.Point(1, 435);
            this.lstData.Name = "lstData";
            this.lstData.Size = new System.Drawing.Size(986, 223);
            this.lstData.TabIndex = 23;
            this.lstData.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstData_MouseDoubleClick);
            // 
            // btnRunProgram
            // 
            this.btnRunProgram.BackColor = System.Drawing.Color.ForestGreen;
            this.btnRunProgram.Location = new System.Drawing.Point(768, 23);
            this.btnRunProgram.Name = "btnRunProgram";
            this.btnRunProgram.Size = new System.Drawing.Size(162, 32);
            this.btnRunProgram.TabIndex = 25;
            this.btnRunProgram.Text = "RUN";
            this.btnRunProgram.UseVisualStyleBackColor = false;
            this.btnRunProgram.Click += new System.EventHandler(this.btnRunCode_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.DarkCyan;
            this.btnReset.Location = new System.Drawing.Point(481, 23);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(137, 32);
            this.btnReset.TabIndex = 26;
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.Crimson;
            this.btnStop.Location = new System.Drawing.Point(662, 363);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(268, 32);
            this.btnStop.TabIndex = 27;
            this.btnStop.Text = "STOP";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.Controller);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, -4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(975, 433);
            this.tabControl1.TabIndex = 28;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.btnInitialPosition);
            this.tabPage1.Controls.Add(this.lblProgress);
            this.tabPage1.Controls.Add(this.label22);
            this.tabPage1.Controls.Add(this.label21);
            this.tabPage1.Controls.Add(this.label20);
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.pBar);
            this.tabPage1.Controls.Add(this.btnSaveProgram);
            this.tabPage1.Controls.Add(this.txtCurrentCommand);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.btnClearConsole);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtSendCommand);
            this.tabPage1.Controls.Add(this.numGripperGValue);
            this.tabPage1.Controls.Add(this.numGripperrotValue);
            this.tabPage1.Controls.Add(this.numGupValue);
            this.tabPage1.Controls.Add(this.numArmValue);
            this.tabPage1.Controls.Add(this.numShoulderValue);
            this.tabPage1.Controls.Add(this.numBodyValue);
            this.tabPage1.Controls.Add(this.btnStop);
            this.tabPage1.Controls.Add(this.btnReset);
            this.tabPage1.Controls.Add(this.btnRunProgram);
            this.tabPage1.Controls.Add(this.btnReadData);
            this.tabPage1.Controls.Add(this.btnSendData);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(967, 407);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Program";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label28);
            this.groupBox3.Controls.Add(this.btnWriteWholeProgram);
            this.groupBox3.Controls.Add(this.btnReadWholeProgram);
            this.groupBox3.Location = new System.Drawing.Point(10, 23);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(204, 257);
            this.groupBox3.TabIndex = 53;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "IMPORT/EXPORT PROGRAM";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(19, 44);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(72, 13);
            this.label28.TabIndex = 55;
            this.label28.Text = "FROM FILE : ";
            // 
            // btnWriteWholeProgram
            // 
            this.btnWriteWholeProgram.BackColor = System.Drawing.Color.SteelBlue;
            this.btnWriteWholeProgram.ForeColor = System.Drawing.Color.White;
            this.btnWriteWholeProgram.Location = new System.Drawing.Point(22, 66);
            this.btnWriteWholeProgram.Name = "btnWriteWholeProgram";
            this.btnWriteWholeProgram.Size = new System.Drawing.Size(156, 29);
            this.btnWriteWholeProgram.TabIndex = 52;
            this.btnWriteWholeProgram.Text = "WRITE PROGRAM";
            this.btnWriteWholeProgram.UseVisualStyleBackColor = false;
            this.btnWriteWholeProgram.Click += new System.EventHandler(this.btnWriteWholeProgram_Click);
            // 
            // btnReadWholeProgram
            // 
            this.btnReadWholeProgram.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnReadWholeProgram.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnReadWholeProgram.Location = new System.Drawing.Point(22, 113);
            this.btnReadWholeProgram.Name = "btnReadWholeProgram";
            this.btnReadWholeProgram.Size = new System.Drawing.Size(156, 29);
            this.btnReadWholeProgram.TabIndex = 51;
            this.btnReadWholeProgram.Text = "READ PROGRAM";
            this.btnReadWholeProgram.UseVisualStyleBackColor = false;
            this.btnReadWholeProgram.Click += new System.EventHandler(this.btnReadWholeProgram_Click);
            // 
            // btnInitialPosition
            // 
            this.btnInitialPosition.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnInitialPosition.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnInitialPosition.Location = new System.Drawing.Point(624, 23);
            this.btnInitialPosition.Name = "btnInitialPosition";
            this.btnInitialPosition.Size = new System.Drawing.Size(137, 32);
            this.btnInitialPosition.TabIndex = 50;
            this.btnInitialPosition.Text = "INITIAL POSITION";
            this.btnInitialPosition.UseVisualStyleBackColor = false;
            this.btnInitialPosition.Click += new System.EventHandler(this.btnInitialPosition_Click);
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgress.Location = new System.Drawing.Point(479, 4);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(23, 12);
            this.lblProgress.TabIndex = 48;
            this.lblProgress.Text = "0 %";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(681, 248);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(78, 13);
            this.label22.TabIndex = 47;
            this.label22.Text = "GRIPPER IO : ";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(648, 213);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(111, 13);
            this.label21.TabIndex = 46;
            this.label21.Text = "GRIPPER ROTATE : ";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(642, 177);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(117, 13);
            this.label20.TabIndex = 45;
            this.label20.Text = "GRIPPER UPDOWN : ";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(719, 140);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(40, 13);
            this.label19.TabIndex = 44;
            this.label19.Text = "ARM : ";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(686, 105);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(76, 13);
            this.label18.TabIndex = 43;
            this.label18.Text = "SHOULDER : ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(719, 69);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(43, 13);
            this.label17.TabIndex = 42;
            this.label17.Text = "BODY :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(3, 3);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(104, 13);
            this.label16.TabIndex = 41;
            this.label16.Text = "Execution Progress :";
            // 
            // pBar
            // 
            this.pBar.Location = new System.Drawing.Point(104, 3);
            this.pBar.Name = "pBar";
            this.pBar.Size = new System.Drawing.Size(860, 14);
            this.pBar.TabIndex = 40;
        
            // 
            // btnSaveProgram
            // 
            this.btnSaveProgram.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnSaveProgram.Location = new System.Drawing.Point(352, 23);
            this.btnSaveProgram.Name = "btnSaveProgram";
            this.btnSaveProgram.Size = new System.Drawing.Size(122, 32);
            this.btnSaveProgram.TabIndex = 39;
            this.btnSaveProgram.Text = "SAVE PROGRAM";
            this.btnSaveProgram.UseVisualStyleBackColor = false;
            this.btnSaveProgram.Click += new System.EventHandler(this.btnSaveProgram_Click);
            // 
            // txtCurrentCommand
            // 
            this.txtCurrentCommand.Location = new System.Drawing.Point(220, 290);
            this.txtCurrentCommand.Name = "txtCurrentCommand";
            this.txtCurrentCommand.Size = new System.Drawing.Size(710, 20);
            this.txtCurrentCommand.TabIndex = 38;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(71, 293);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(150, 13);
            this.label15.TabIndex = 37;
            this.label15.Text = "CURRENT COORDINATES : ";
            // 
            // btnClearConsole
            // 
            this.btnClearConsole.BackColor = System.Drawing.Color.Black;
            this.btnClearConsole.ForeColor = System.Drawing.Color.White;
            this.btnClearConsole.Location = new System.Drawing.Point(220, 23);
            this.btnClearConsole.Name = "btnClearConsole";
            this.btnClearConsole.Size = new System.Drawing.Size(122, 32);
            this.btnClearConsole.TabIndex = 36;
            this.btnClearConsole.Text = "CLEAR CONSOLE";
            this.btnClearConsole.UseVisualStyleBackColor = false;
            this.btnClearConsole.Click += new System.EventHandler(this.btnClearConsole_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 328);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "TO SEND :";
            // 
            // txtSendCommand
            // 
            this.txtSendCommand.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSendCommand.Location = new System.Drawing.Point(74, 313);
            this.txtSendCommand.Multiline = true;
            this.txtSendCommand.Name = "txtSendCommand";
            this.txtSendCommand.Size = new System.Drawing.Size(856, 44);
            this.txtSendCommand.TabIndex = 34;
            // 
            // numGripperGValue
            // 
            this.numGripperGValue.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numGripperGValue.Location = new System.Drawing.Point(768, 246);
            this.numGripperGValue.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numGripperGValue.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.numGripperGValue.Name = "numGripperGValue";
            this.numGripperGValue.Size = new System.Drawing.Size(162, 20);
            this.numGripperGValue.TabIndex = 28;
            this.numGripperGValue.ValueChanged += new System.EventHandler(this.numGripperGValue_ValueChanged);
            // 
            // numGripperrotValue
            // 
            this.numGripperrotValue.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numGripperrotValue.Location = new System.Drawing.Point(768, 211);
            this.numGripperrotValue.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numGripperrotValue.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.numGripperrotValue.Name = "numGripperrotValue";
            this.numGripperrotValue.Size = new System.Drawing.Size(162, 20);
            this.numGripperrotValue.TabIndex = 29;
            this.numGripperrotValue.ValueChanged += new System.EventHandler(this.numGripperrotValue_ValueChanged);
            // 
            // numGupValue
            // 
            this.numGupValue.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numGupValue.Location = new System.Drawing.Point(768, 175);
            this.numGupValue.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numGupValue.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.numGupValue.Name = "numGupValue";
            this.numGupValue.Size = new System.Drawing.Size(162, 20);
            this.numGupValue.TabIndex = 30;
            this.numGupValue.ValueChanged += new System.EventHandler(this.numGupValue_ValueChanged);
            // 
            // numArmValue
            // 
            this.numArmValue.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numArmValue.Location = new System.Drawing.Point(768, 138);
            this.numArmValue.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numArmValue.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.numArmValue.Name = "numArmValue";
            this.numArmValue.Size = new System.Drawing.Size(162, 20);
            this.numArmValue.TabIndex = 31;
            this.numArmValue.ValueChanged += new System.EventHandler(this.numArmValue_ValueChanged);
            // 
            // numShoulderValue
            // 
            this.numShoulderValue.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numShoulderValue.Location = new System.Drawing.Point(768, 103);
            this.numShoulderValue.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numShoulderValue.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.numShoulderValue.Name = "numShoulderValue";
            this.numShoulderValue.Size = new System.Drawing.Size(162, 20);
            this.numShoulderValue.TabIndex = 32;
            this.numShoulderValue.ValueChanged += new System.EventHandler(this.numShoulderValue_ValueChanged);
            // 
            // numBodyValue
            // 
            this.numBodyValue.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numBodyValue.Location = new System.Drawing.Point(768, 67);
            this.numBodyValue.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numBodyValue.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.numBodyValue.Name = "numBodyValue";
            this.numBodyValue.Size = new System.Drawing.Size(162, 20);
            this.numBodyValue.TabIndex = 33;
            this.numBodyValue.ValueChanged += new System.EventHandler(this.numBodyValue_ValueChanged);
            // 
            // Controller
            // 
            this.Controller.BackColor = System.Drawing.Color.Gainsboro;
            this.Controller.Controls.Add(this.btnCloseGripper);
            this.Controller.Controls.Add(this.btnRecordStep);
            this.Controller.Controls.Add(this.groupBox2);
            this.Controller.Controls.Add(this.panel6);
            this.Controller.Controls.Add(this.panel5);
            this.Controller.Controls.Add(this.panel4);
            this.Controller.Controls.Add(this.panel3);
            this.Controller.Controls.Add(this.panel2);
            this.Controller.Controls.Add(this.panel1);
            this.Controller.Location = new System.Drawing.Point(4, 22);
            this.Controller.Name = "Controller";
            this.Controller.Padding = new System.Windows.Forms.Padding(3);
            this.Controller.Size = new System.Drawing.Size(967, 407);
            this.Controller.TabIndex = 1;
            this.Controller.Text = "Controller";
            // 
            // btnCloseGripper
            // 
            this.btnCloseGripper.BackColor = System.Drawing.Color.DimGray;
            this.btnCloseGripper.ForeColor = System.Drawing.Color.White;
            this.btnCloseGripper.Location = new System.Drawing.Point(35, 361);
            this.btnCloseGripper.Name = "btnCloseGripper";
            this.btnCloseGripper.Size = new System.Drawing.Size(454, 37);
            this.btnCloseGripper.TabIndex = 39;
            this.btnCloseGripper.Text = "CLOSE GRIPPER";
            this.btnCloseGripper.UseVisualStyleBackColor = false;
            this.btnCloseGripper.Click += new System.EventHandler(this.btnCloseGripper_Click);
            // 
            // btnRecordStep
            // 
            this.btnRecordStep.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnRecordStep.Location = new System.Drawing.Point(35, 43);
            this.btnRecordStep.Name = "btnRecordStep";
            this.btnRecordStep.Size = new System.Drawing.Size(454, 315);
            this.btnRecordStep.TabIndex = 38;
            this.btnRecordStep.Text = "RECORD STEP";
            this.btnRecordStep.UseVisualStyleBackColor = false;
            this.btnRecordStep.Click += new System.EventHandler(this.btnRecordStep_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(3, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 48);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Timer";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(70, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "0 : 32 s";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel6.Controls.Add(this.txtGripperGrip);
            this.panel6.Controls.Add(this.label14);
            this.panel6.Controls.Add(this.btnGripperClose);
            this.panel6.Controls.Add(this.btnGripperOpen);
            this.panel6.Location = new System.Drawing.Point(520, 340);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(441, 61);
            this.panel6.TabIndex = 36;
            // 
            // txtGripperGrip
            // 
            this.txtGripperGrip.Location = new System.Drawing.Point(184, 21);
            this.txtGripperGrip.Name = "txtGripperGrip";
            this.txtGripperGrip.Size = new System.Drawing.Size(100, 20);
            this.txtGripperGrip.TabIndex = 5;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(214, 5);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "Gripper";
            // 
            // btnGripperClose
            // 
            this.btnGripperClose.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnGripperClose.Location = new System.Drawing.Point(76, 5);
            this.btnGripperClose.Name = "btnGripperClose";
            this.btnGripperClose.Size = new System.Drawing.Size(75, 53);
            this.btnGripperClose.TabIndex = 0;
            this.btnGripperClose.Text = "CLOSE";
            this.btnGripperClose.UseVisualStyleBackColor = false;
            this.btnGripperClose.Click += new System.EventHandler(this.btnGripperClose_Click);
            // 
            // btnGripperOpen
            // 
            this.btnGripperOpen.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnGripperOpen.Location = new System.Drawing.Point(328, 3);
            this.btnGripperOpen.Name = "btnGripperOpen";
            this.btnGripperOpen.Size = new System.Drawing.Size(75, 55);
            this.btnGripperOpen.TabIndex = 2;
            this.btnGripperOpen.Text = "OPEN";
            this.btnGripperOpen.UseVisualStyleBackColor = false;
            this.btnGripperOpen.Click += new System.EventHandler(this.btnGripperOpen_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel5.Controls.Add(this.txtGripperRotate);
            this.panel5.Controls.Add(this.label13);
            this.panel5.Controls.Add(this.btnGripperRotateRight);
            this.panel5.Controls.Add(this.btnGripperRotateLeft);
            this.panel5.Location = new System.Drawing.Point(520, 272);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(441, 62);
            this.panel5.TabIndex = 35;
            // 
            // txtGripperRotate
            // 
            this.txtGripperRotate.Location = new System.Drawing.Point(184, 20);
            this.txtGripperRotate.Name = "txtGripperRotate";
            this.txtGripperRotate.Size = new System.Drawing.Size(100, 20);
            this.txtGripperRotate.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(198, 4);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "Gripper Rotate";
            // 
            // btnGripperRotateRight
            // 
            this.btnGripperRotateRight.BackColor = System.Drawing.Color.White;
            this.btnGripperRotateRight.Image = ((System.Drawing.Image)(resources.GetObject("btnGripperRotateRight.Image")));
            this.btnGripperRotateRight.Location = new System.Drawing.Point(328, 6);
            this.btnGripperRotateRight.Name = "btnGripperRotateRight";
            this.btnGripperRotateRight.Size = new System.Drawing.Size(75, 47);
            this.btnGripperRotateRight.TabIndex = 2;
            this.btnGripperRotateRight.UseVisualStyleBackColor = false;
            this.btnGripperRotateRight.Click += new System.EventHandler(this.btnGripperRotateRight_Click);
            // 
            // btnGripperRotateLeft
            // 
            this.btnGripperRotateLeft.BackColor = System.Drawing.Color.White;
            this.btnGripperRotateLeft.Image = ((System.Drawing.Image)(resources.GetObject("btnGripperRotateLeft.Image")));
            this.btnGripperRotateLeft.Location = new System.Drawing.Point(76, 6);
            this.btnGripperRotateLeft.Name = "btnGripperRotateLeft";
            this.btnGripperRotateLeft.Size = new System.Drawing.Size(75, 48);
            this.btnGripperRotateLeft.TabIndex = 0;
            this.btnGripperRotateLeft.UseVisualStyleBackColor = false;
            this.btnGripperRotateLeft.Click += new System.EventHandler(this.btnGripperRotateLeft_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel4.Controls.Add(this.txtGripperLift);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.btnGripperMoveDown);
            this.panel4.Controls.Add(this.btnGripperMoveUp);
            this.panel4.Location = new System.Drawing.Point(520, 199);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(441, 67);
            this.panel4.TabIndex = 34;
            // 
            // txtGripperLift
            // 
            this.txtGripperLift.Location = new System.Drawing.Point(184, 16);
            this.txtGripperLift.Name = "txtGripperLift";
            this.txtGripperLift.Size = new System.Drawing.Size(100, 20);
            this.txtGripperLift.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(206, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "Gripper Up";
            // 
            // btnGripperMoveDown
            // 
            this.btnGripperMoveDown.BackColor = System.Drawing.Color.Silver;
            this.btnGripperMoveDown.Location = new System.Drawing.Point(328, 15);
            this.btnGripperMoveDown.Name = "btnGripperMoveDown";
            this.btnGripperMoveDown.Size = new System.Drawing.Size(75, 49);
            this.btnGripperMoveDown.TabIndex = 2;
            this.btnGripperMoveDown.Text = "DOWN";
            this.btnGripperMoveDown.UseVisualStyleBackColor = false;
            this.btnGripperMoveDown.Click += new System.EventHandler(this.btnGripperMoveDown_Click);
            // 
            // btnGripperMoveUp
            // 
            this.btnGripperMoveUp.BackColor = System.Drawing.Color.Silver;
            this.btnGripperMoveUp.Location = new System.Drawing.Point(76, 15);
            this.btnGripperMoveUp.Name = "btnGripperMoveUp";
            this.btnGripperMoveUp.Size = new System.Drawing.Size(75, 49);
            this.btnGripperMoveUp.TabIndex = 0;
            this.btnGripperMoveUp.Text = "UP";
            this.btnGripperMoveUp.UseVisualStyleBackColor = false;
            this.btnGripperMoveUp.Click += new System.EventHandler(this.btnGripperMoveUp_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel3.Controls.Add(this.txtArmCoordinate);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.btnArmMoveUp);
            this.panel3.Controls.Add(this.btnArmMoveDown);
            this.panel3.Location = new System.Drawing.Point(520, 129);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(441, 64);
            this.panel3.TabIndex = 33;
            // 
            // txtArmCoordinate
            // 
            this.txtArmCoordinate.Location = new System.Drawing.Point(184, 20);
            this.txtArmCoordinate.Name = "txtArmCoordinate";
            this.txtArmCoordinate.Size = new System.Drawing.Size(100, 20);
            this.txtArmCoordinate.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(221, 5);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(25, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Arm";
            // 
            // btnArmMoveUp
            // 
            this.btnArmMoveUp.BackColor = System.Drawing.Color.White;
            this.btnArmMoveUp.Image = ((System.Drawing.Image)(resources.GetObject("btnArmMoveUp.Image")));
            this.btnArmMoveUp.Location = new System.Drawing.Point(76, 8);
            this.btnArmMoveUp.Name = "btnArmMoveUp";
            this.btnArmMoveUp.Size = new System.Drawing.Size(75, 53);
            this.btnArmMoveUp.TabIndex = 0;
            this.btnArmMoveUp.UseVisualStyleBackColor = false;
            this.btnArmMoveUp.Click += new System.EventHandler(this.btnArmMoveUp_Click);
            // 
            // btnArmMoveDown
            // 
            this.btnArmMoveDown.BackColor = System.Drawing.Color.White;
            this.btnArmMoveDown.Image = ((System.Drawing.Image)(resources.GetObject("btnArmMoveDown.Image")));
            this.btnArmMoveDown.Location = new System.Drawing.Point(328, 5);
            this.btnArmMoveDown.Name = "btnArmMoveDown";
            this.btnArmMoveDown.Size = new System.Drawing.Size(75, 48);
            this.btnArmMoveDown.TabIndex = 2;
            this.btnArmMoveDown.UseVisualStyleBackColor = false;
            this.btnArmMoveDown.Click += new System.EventHandler(this.btnArmMoveDown_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel2.Controls.Add(this.txtShoulderCoordinate);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.btnShoulderMoveUp);
            this.panel2.Controls.Add(this.btnShoulderMoveDown);
            this.panel2.Location = new System.Drawing.Point(520, 67);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(441, 56);
            this.panel2.TabIndex = 32;
            // 
            // txtShoulderCoordinate
            // 
            this.txtShoulderCoordinate.Location = new System.Drawing.Point(184, 19);
            this.txtShoulderCoordinate.Name = "txtShoulderCoordinate";
            this.txtShoulderCoordinate.Size = new System.Drawing.Size(100, 20);
            this.txtShoulderCoordinate.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(206, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Shoulder";
            // 
            // btnShoulderMoveUp
            // 
            this.btnShoulderMoveUp.BackColor = System.Drawing.Color.FloralWhite;
            this.btnShoulderMoveUp.Image = ((System.Drawing.Image)(resources.GetObject("btnShoulderMoveUp.Image")));
            this.btnShoulderMoveUp.Location = new System.Drawing.Point(76, 2);
            this.btnShoulderMoveUp.Name = "btnShoulderMoveUp";
            this.btnShoulderMoveUp.Size = new System.Drawing.Size(75, 51);
            this.btnShoulderMoveUp.TabIndex = 0;
            this.btnShoulderMoveUp.UseVisualStyleBackColor = false;
            this.btnShoulderMoveUp.Click += new System.EventHandler(this.btnShoulderMoveUp_Click);
            // 
            // btnShoulderMoveDown
            // 
            this.btnShoulderMoveDown.BackColor = System.Drawing.Color.White;
            this.btnShoulderMoveDown.Image = ((System.Drawing.Image)(resources.GetObject("btnShoulderMoveDown.Image")));
            this.btnShoulderMoveDown.Location = new System.Drawing.Point(328, 3);
            this.btnShoulderMoveDown.Name = "btnShoulderMoveDown";
            this.btnShoulderMoveDown.Size = new System.Drawing.Size(75, 51);
            this.btnShoulderMoveDown.TabIndex = 2;
            this.btnShoulderMoveDown.UseVisualStyleBackColor = false;
            this.btnShoulderMoveDown.Click += new System.EventHandler(this.btnShoulderMoveDown_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel1.Controls.Add(this.txtBodyCoordinate);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.btnBodyMoveLeft);
            this.panel1.Controls.Add(this.btnBodyMoveRight);
            this.panel1.Location = new System.Drawing.Point(520, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(441, 55);
            this.panel1.TabIndex = 31;
            // 
            // txtBodyCoordinate
            // 
            this.txtBodyCoordinate.Location = new System.Drawing.Point(184, 23);
            this.txtBodyCoordinate.Name = "txtBodyCoordinate";
            this.txtBodyCoordinate.Size = new System.Drawing.Size(100, 20);
            this.txtBodyCoordinate.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(215, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Body";
            // 
            // btnBodyMoveLeft
            // 
            this.btnBodyMoveLeft.BackColor = System.Drawing.Color.Silver;
            this.btnBodyMoveLeft.Image = ((System.Drawing.Image)(resources.GetObject("btnBodyMoveLeft.Image")));
            this.btnBodyMoveLeft.Location = new System.Drawing.Point(76, 3);
            this.btnBodyMoveLeft.Name = "btnBodyMoveLeft";
            this.btnBodyMoveLeft.Size = new System.Drawing.Size(75, 49);
            this.btnBodyMoveLeft.TabIndex = 0;
            this.btnBodyMoveLeft.UseVisualStyleBackColor = false;
            this.btnBodyMoveLeft.Click += new System.EventHandler(this.btnBodyMoveLeft_Click);
            // 
            // btnBodyMoveRight
            // 
            this.btnBodyMoveRight.BackColor = System.Drawing.Color.Silver;
            this.btnBodyMoveRight.Image = ((System.Drawing.Image)(resources.GetObject("btnBodyMoveRight.Image")));
            this.btnBodyMoveRight.Location = new System.Drawing.Point(328, 3);
            this.btnBodyMoveRight.Name = "btnBodyMoveRight";
            this.btnBodyMoveRight.Size = new System.Drawing.Size(75, 49);
            this.btnBodyMoveRight.TabIndex = 2;
            this.btnBodyMoveRight.UseVisualStyleBackColor = false;
            this.btnBodyMoveRight.Click += new System.EventHandler(this.btnBodyMoveRight_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnConnectionSetup);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.btnAboutProject);
            this.tabPage2.Controls.Add(this.btnSaveSettings);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.cmbBit);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.cmbParity);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.cmbBaudRate);
            this.tabPage2.Controls.Add(this.btnRefreshPorts);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.cmbPorts);
            this.tabPage2.Controls.Add(this.btnConnect);
            this.tabPage2.Controls.Add(this.txtSpeed);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(967, 407);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "Settings";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnConnectionSetup
            // 
            this.btnConnectionSetup.Location = new System.Drawing.Point(20, 364);
            this.btnConnectionSetup.Name = "btnConnectionSetup";
            this.btnConnectionSetup.Size = new System.Drawing.Size(320, 37);
            this.btnConnectionSetup.TabIndex = 4;
            this.btnConnectionSetup.Text = "START CONNECTION";
            this.btnConnectionSetup.UseVisualStyleBackColor = true;
            this.btnConnectionSetup.Click += new System.EventHandler(this.btnConnectionSetup_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Lavender;
            this.groupBox4.Controls.Add(this.txtData);
            this.groupBox4.Controls.Add(this.label27);
            this.groupBox4.Controls.Add(this.rdbClientCheck);
            this.groupBox4.Controls.Add(this.rdbServerCheck);
            this.groupBox4.Controls.Add(this.label26);
            this.groupBox4.Controls.Add(this.txtPort);
            this.groupBox4.Controls.Add(this.txtIpAddress);
            this.groupBox4.Controls.Add(this.label25);
            this.groupBox4.Controls.Add(this.label24);
            this.groupBox4.Location = new System.Drawing.Point(20, 9);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(320, 349);
            this.groupBox4.TabIndex = 35;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "NETWORK SETTINGS";
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(90, 96);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(198, 20);
            this.txtData.TabIndex = 8;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(17, 99);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(36, 13);
            this.label27.TabIndex = 7;
            this.label27.Text = "Data :";
            // 
            // rdbClientCheck
            // 
            this.rdbClientCheck.AutoSize = true;
            this.rdbClientCheck.Location = new System.Drawing.Point(90, 192);
            this.rdbClientCheck.Name = "rdbClientCheck";
            this.rdbClientCheck.Size = new System.Drawing.Size(63, 17);
            this.rdbClientCheck.TabIndex = 6;
            this.rdbClientCheck.TabStop = true;
            this.rdbClientCheck.Text = "CLIENT";
            this.rdbClientCheck.UseVisualStyleBackColor = true;
            // 
            // rdbServerCheck
            // 
            this.rdbServerCheck.AutoSize = true;
            this.rdbServerCheck.Location = new System.Drawing.Point(90, 165);
            this.rdbServerCheck.Name = "rdbServerCheck";
            this.rdbServerCheck.Size = new System.Drawing.Size(69, 17);
            this.rdbServerCheck.TabIndex = 5;
            this.rdbServerCheck.TabStop = true;
            this.rdbServerCheck.Text = "SERVER";
            this.rdbServerCheck.UseVisualStyleBackColor = true;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(87, 136);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(109, 13);
            this.label26.TabIndex = 4;
            this.label26.Text = "RUN PROGRAM AS:";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(90, 64);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(198, 20);
            this.txtPort.TabIndex = 3;
            // 
            // txtIpAddress
            // 
            this.txtIpAddress.Location = new System.Drawing.Point(90, 34);
            this.txtIpAddress.Name = "txtIpAddress";
            this.txtIpAddress.Size = new System.Drawing.Size(198, 20);
            this.txtIpAddress.TabIndex = 2;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(17, 67);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(35, 13);
            this.label25.TabIndex = 1;
            this.label25.Text = "Port : ";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(17, 37);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(67, 13);
            this.label24.TabIndex = 0;
            this.label24.Text = "IP Address : ";
            // 
            // btnAboutProject
            // 
            this.btnAboutProject.Location = new System.Drawing.Point(782, 364);
            this.btnAboutProject.Name = "btnAboutProject";
            this.btnAboutProject.Size = new System.Drawing.Size(182, 37);
            this.btnAboutProject.TabIndex = 34;
            this.btnAboutProject.Text = "ABOUT PROJECT";
            this.btnAboutProject.UseVisualStyleBackColor = true;
            this.btnAboutProject.Click += new System.EventHandler(this.btnAboutProject_Click);
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.Location = new System.Drawing.Point(393, 364);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(302, 37);
            this.btnSaveSettings.TabIndex = 33;
            this.btnSaveSettings.Text = "SAVE";
            this.btnSaveSettings.UseVisualStyleBackColor = true;
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(this.txtArmCharacter);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(393, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 349);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ARM TEACHMOVER";
            // 
            // txtArmCharacter
            // 
            this.txtArmCharacter.Location = new System.Drawing.Point(94, 37);
            this.txtArmCharacter.Name = "txtArmCharacter";
            this.txtArmCharacter.Size = new System.Drawing.Size(186, 20);
            this.txtArmCharacter.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "ARM Character :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(715, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Bit :";
            // 
            // cmbBit
            // 
            this.cmbBit.FormattingEnabled = true;
            this.cmbBit.Location = new System.Drawing.Point(782, 162);
            this.cmbBit.Name = "cmbBit";
            this.cmbBit.Size = new System.Drawing.Size(179, 21);
            this.cmbBit.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(715, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Parity : ";
            // 
            // cmbParity
            // 
            this.cmbParity.FormattingEnabled = true;
            this.cmbParity.Location = new System.Drawing.Point(782, 124);
            this.cmbParity.Name = "cmbParity";
            this.cmbParity.Size = new System.Drawing.Size(179, 21);
            this.cmbParity.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(715, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Baud Rate :";
            // 
            // cmbBaudRate
            // 
            this.cmbBaudRate.FormattingEnabled = true;
            this.cmbBaudRate.Location = new System.Drawing.Point(782, 85);
            this.cmbBaudRate.Name = "cmbBaudRate";
            this.cmbBaudRate.Size = new System.Drawing.Size(179, 21);
            this.cmbBaudRate.TabIndex = 26;
            // 
            // btnRefreshPorts
            // 
            this.btnRefreshPorts.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnRefreshPorts.Location = new System.Drawing.Point(782, 220);
            this.btnRefreshPorts.Name = "btnRefreshPorts";
            this.btnRefreshPorts.Size = new System.Drawing.Size(75, 34);
            this.btnRefreshPorts.TabIndex = 21;
            this.btnRefreshPorts.Text = "REFRESH";
            this.btnRefreshPorts.UseVisualStyleBackColor = false;
            this.btnRefreshPorts.Click += new System.EventHandler(this.btnRefreshPorts_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(715, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Port :";
            // 
            // cmbPorts
            // 
            this.cmbPorts.FormattingEnabled = true;
            this.cmbPorts.Location = new System.Drawing.Point(782, 6);
            this.cmbPorts.Name = "cmbPorts";
            this.cmbPorts.Size = new System.Drawing.Size(179, 21);
            this.cmbPorts.TabIndex = 22;
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnConnect.Location = new System.Drawing.Point(886, 220);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 34);
            this.btnConnect.TabIndex = 23;
            this.btnConnect.Text = "CONNECT";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtSpeed
            // 
            this.txtSpeed.Location = new System.Drawing.Point(782, 47);
            this.txtSpeed.Name = "txtSpeed";
            this.txtSpeed.Size = new System.Drawing.Size(179, 20);
            this.txtSpeed.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(715, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Speed :";
            // 
            // backRunCode
            // 
            this.backRunCode.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backRunCode_DoWork);
            this.backRunCode.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backRunCode_ProgressChanged);
            this.backRunCode.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backRunCode_RunWorkerCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(987, 654);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lstData);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Project Southern Lights";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGripperGValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGripperrotValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGupValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numArmValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numShoulderValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBodyValue)).EndInit();
            this.Controller.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSendData;
        private System.Windows.Forms.Button btnReadData;
        private System.Windows.Forms.ListBox lstData;
        private System.Windows.Forms.Button btnRunProgram;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage Controller;
        private System.Windows.Forms.NumericUpDown numGripperGValue;
        private System.Windows.Forms.NumericUpDown numGripperrotValue;
        private System.Windows.Forms.NumericUpDown numGupValue;
        private System.Windows.Forms.NumericUpDown numArmValue;
        private System.Windows.Forms.NumericUpDown numShoulderValue;
        private System.Windows.Forms.NumericUpDown numBodyValue;
        private System.Windows.Forms.Button btnBodyMoveRight;
        private System.Windows.Forms.Button btnBodyMoveLeft;
        private System.Windows.Forms.Button btnShoulderMoveDown;
        private System.Windows.Forms.Button btnShoulderMoveUp;
        private System.Windows.Forms.Button btnArmMoveDown;
        private System.Windows.Forms.Button btnArmMoveUp;
        private System.Windows.Forms.Button btnGripperMoveDown;
        private System.Windows.Forms.Button btnGripperMoveUp;
        private System.Windows.Forms.Button btnGripperOpen;
        private System.Windows.Forms.Button btnGripperClose;
        private System.Windows.Forms.Button btnGripperRotateRight;
        private System.Windows.Forms.Button btnGripperRotateLeft;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSendCommand;
        private System.Windows.Forms.Button btnRefreshPorts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPorts;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtSpeed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbBaudRate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbParity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbBit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtArmCharacter;
        private System.Windows.Forms.Button btnSaveSettings;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtShoulderCoordinate;
        private System.Windows.Forms.TextBox txtBodyCoordinate;
        private System.Windows.Forms.TextBox txtGripperLift;
        private System.Windows.Forms.TextBox txtArmCoordinate;
        private System.Windows.Forms.TextBox txtGripperRotate;
        private System.Windows.Forms.TextBox txtGripperGrip;
        private System.Windows.Forms.Button btnClearConsole;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtCurrentCommand;
        private System.Windows.Forms.Button btnSaveProgram;
        private System.ComponentModel.BackgroundWorker backRunCode;
        private System.Windows.Forms.ProgressBar pBar;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.Button btnAboutProject;
        private System.Windows.Forms.Button btnRecordStep;
        private System.Windows.Forms.Button btnInitialPosition;
        private System.Windows.Forms.Button btnReadWholeProgram;
        private System.Windows.Forms.Button btnWriteWholeProgram;
        private System.Windows.Forms.Button btnCloseGripper;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtIpAddress;
        private System.Windows.Forms.Button btnConnectionSetup;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.RadioButton rdbClientCheck;
        private System.Windows.Forms.RadioButton rdbServerCheck;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Label label27;
    }
}

