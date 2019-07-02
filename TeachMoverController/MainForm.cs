using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO.Ports;
using System.IO;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace ArmBot
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        //NETWORK COMMUNICATION
        Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        public bool clientConnect() // 
        {
            bool c = c = false;
            IPAddress ipAddress = IPAddress.Parse(txtIpAddress.Text);
            int Port = int.Parse(txtPort.Text);
            IPEndPoint iedp = new IPEndPoint(ipAddress, Port);
            socket.Connect(iedp);
            if (socket.Connected)
            {
                c = true;
            }
            return c;
        }

        public bool Send(string message)
        {
            bool c = false;
            if (socket.Connected)
            {
                // connectedi
                lstData.Items.Add("Connected to : "+socket.RemoteEndPoint.ToString());
                socket.Send(Encoding.UTF8.GetBytes(message));

            }

            return c;
        }

        //NETWORK COMMUNICATION

        commandview cm;
        Setting settings = new Setting();
        Controlx controller = new Controlx(); // Controller Value Container
        SerialPort SP = new SerialPort();

        List<string> ListOfCommands = new List<string>(); //stores all commands run by the user
        List<string> ListOfRecordedCommands = new List<string>(); // store commands recorded by the user
        volatile bool RecordProgram=false; 
        volatile bool IsCarrageReturnReceived = false;
        List<string> FinalProgramCommands = new List<string>();// stores formatted final program to be executed.
        List<string> FinalProgramTempF = new List<string>(); // Foward Move Temporary Store
        List<string> FInalProgramTempR = new List<string>(); // reverse move Temporay Store
        string currentDataTempStorage = "";

         public void InitializeSettings()
        {
            backRunCode.WorkerReportsProgress = true;
            settings.ArmCharacter = "@";
            settings.Speed = 232;
            txtSpeed.Text = "232";  
            txtArmCharacter.Text = "@";
            cmbBaudRate.Items.Add("9600");
            cmbBaudRate.Items.Add("10000");
            cmbBaudRate.Items.Add("12600");    
        }

        public void ResetNumericUpDowns()
        {
            numArmValue.Value = 0;
            numBodyValue.Value = 0;
            numShoulderValue.Value = 0;
            numGupValue.Value = 0;
            numGripperGValue.Value = 0;
            numGupValue.Value = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (SP.IsOpen)
            {
                SP.Close();
            }
         
            InitializeSettings();// initializes the settings of the techmover robot
            CheckConnectedDevices(); // checks connected devices on the serial port
        }
    
        private void cmbPorts_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SP.PortName = cmbPorts.SelectedItem.ToString();
        }

        private void SP_ErrorReceived(object sender, SerialErrorReceivedEventArgs e)
        {
            MessageBox.Show("Error: Something Went Wrong "+e.ToString());
        }

        /// <summary>
        ///  TEACH MOVER ROBOTIC ARM
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SP_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            this.Invoke(new EventHandler(PortReader));
        }  
        public void PortReader(object s,EventArgs e)
        {          
            string currentdata = SP.ReadExisting();
            currentDataTempStorage += currentdata;
            if (currentDataTempStorage.EndsWith("\r"))
            {
                IsCarrageReturnReceived = true;
                // done
                if (currentDataTempStorage.Length > 10)
                {
                    if (RecordProgram)
                    {
                        ListOfRecordedCommands.Add("" + currentDataTempStorage.ToString());
                        // mybe write the program to file
                    }
                    ListOfCommands.Add(currentDataTempStorage.ToString());
                    txtCurrentCommand.Text = currentDataTempStorage; // display the current read move coordinates
                }
                lstData.Items.Add(currentDataTempStorage.ToString());
              
                currentDataTempStorage = ""; // reset to null value
            }
        }

        private void btnSendData_Click(object sender, EventArgs e)
        {
            txtSendCommand.Text = "@STEP " + txtSpeed.Text + "," + numBodyValue.Value + "," + numShoulderValue.Value + "," + numArmValue.Value + "," + numGupValue.Value + "," + numGripperrotValue.Value + "," + numGripperGValue.Value + ",\r";
            if (SP.IsOpen)
            {
                SP.Write(txtSendCommand.Text);
            }
            ResetNumericUpDowns();
        }

        private void btnReadData_Click(object sender, EventArgs e)
        {
            txtCurrentCommand.Text = " ";
            if (SP.IsOpen)
            {
                SP.Write("@READ \r");
            }
        }

        private void btnRunCode_Click(object sender, EventArgs e)
        {
            pBar.Value = 0;
            // add Steps to the Commmand
            string line = "";
            if (SP.IsOpen)
            {  
                for (int i = 0; i < ListOfRecordedCommands.Count-1; i++)
                {
                    line = txtArmCharacter.Text + "STEP " + txtSpeed.Text + "" + COordiatesCalculator(ListOfRecordedCommands[i+1],ListOfRecordedCommands[i]).Replace("/r", "").Replace("\r", "") + "\r";
                    FinalProgramCommands.Add(line);// add final code to the machine
                }
                  backRunCode.RunWorkerAsync();
                }
            }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (SP.IsOpen)
            {
                SP.Write("@RESET \r");
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (SP.IsOpen)
            {
                SP.Write("@STOP \r");
            }
        }

        public void CheckConnectedDevices()
        {
            string[] ports = SerialPort.GetPortNames();

            cmbPorts.Items.Clear();
            foreach (var item in ports)
            {
                cmbPorts.Items.Add(item);
            }
        }

        public string COordiatesCalculator(string current,string previous)
        {
            if (current.Split(',')[0].Contains("\r"))
            {
                current = current.Remove(0, 1);
            }

            if (previous.Split(',')[0].Contains("\r"))
            {
                previous = previous.Remove(0, 1);
            }

            string currentBackSPlit = current.Replace("\r","").Replace("/r","");
            string previousBackSplit = previous.Replace("\r","").Replace("/r","");
            string line = "";
            string[] currentArr = currentBackSPlit.Split(',');
            string[] previousArr = previousBackSplit.Split(',');

            double[] data = new double[currentArr.Length];
            for (int i = 0; i < data.Length; i++)
            {   
                data[i] = double.Parse(currentArr[i]) - double.Parse(previousArr[i]);
                line += "," + data[i];         
            }
            return line;
        }

        private void btnRefreshPorts_Click(object sender, EventArgs e)
        {
            CheckConnectedDevices();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            SP.PortName = cmbPorts.SelectedItem.ToString();
            SP.BaudRate = 9600;
            SP.DataBits = 8;
            SP.StopBits = StopBits.One; //added based on thr 7.10 Page DataFormat
            SP.DataReceived += SP_DataReceived;
            SP.ErrorReceived += SP_ErrorReceived;
            if (!SP.IsOpen)
            {
                SP.Open();
                if (SP.IsOpen)
                {
                    lstData.Items.Add("Connected : " + SP.PortName);
                }
            }
        }

        private void numBodyValue_ValueChanged(object sender, EventArgs e)
        {
            // add value to the output
            controller.BodyValue =float.Parse(numBodyValue.Value.ToString());
            controller.CurrentCommand = txtArmCharacter.Text + "STEP " + txtSpeed.Text + "," + controller.BodyValue.ToString() + ", " + controller.ShoulderValue.ToString() + " ," + controller.ArmValue.ToString() + ", " + controller.GripperU.ToString() + "," + controller.GripperRotate.ToString() + ", " + controller.GripperG.ToString()+",\r";
            txtSendCommand.Text = controller.CurrentCommand;
        }

        private void numShoulderValue_ValueChanged(object sender, EventArgs e)
        {
            controller.ShoulderValue = float.Parse(numShoulderValue.Value.ToString());
            controller.CurrentCommand = txtArmCharacter.Text + "STEP " + txtSpeed.Text + "," + controller.BodyValue.ToString() + ", " + controller.ShoulderValue.ToString() + " ," + controller.ArmValue.ToString() + ", " + controller.GripperU.ToString() + "," + controller.GripperRotate.ToString() + ", " + controller.GripperG.ToString() + ",\r";
            txtSendCommand.Text = controller.CurrentCommand;
        }

        private void numArmValue_ValueChanged(object sender, EventArgs e)
        {
            controller.ArmValue = float.Parse(numArmValue.Value.ToString());
            controller.CurrentCommand = txtArmCharacter.Text + "STEP " + txtSpeed.Text + "," + controller.BodyValue.ToString() + ", " + controller.ShoulderValue.ToString() + " ," + controller.ArmValue.ToString() + ", " + controller.GripperU.ToString() + "," + controller.GripperRotate.ToString() + ", " + controller.GripperG.ToString() + ",\r";
            txtSendCommand.Text = controller.CurrentCommand;
        }

        private void numGupValue_ValueChanged(object sender, EventArgs e)
        {
            controller.GripperU = float.Parse(numGupValue.Value.ToString());
            controller.CurrentCommand = txtArmCharacter.Text + "STEP " + txtSpeed.Text + "," + controller.BodyValue.ToString() + ", " + controller.ShoulderValue.ToString() + " ," + controller.ArmValue.ToString() + ", " + controller.GripperU.ToString() + "," + controller.GripperRotate.ToString() + ", " + controller.GripperG.ToString() + ",\r";
            txtSendCommand.Text = controller.CurrentCommand;
        }

        private void numGripperrotValue_ValueChanged(object sender, EventArgs e)
        {
            controller.GripperRotate = float.Parse(numGripperrotValue.Value.ToString());
            controller.CurrentCommand = txtArmCharacter.Text + "STEP " + txtSpeed.Text + "," + controller.BodyValue.ToString() + ", " + controller.ShoulderValue.ToString() + " ," + controller.ArmValue.ToString() + ", " + controller.GripperU.ToString() + "," + controller.GripperRotate.ToString() + ", " + controller.GripperG.ToString() + ",\r";
            txtSendCommand.Text = controller.CurrentCommand;
        }

        private void numGripperGValue_ValueChanged(object sender, EventArgs e)
        {
            controller.GripperG = float.Parse(numGripperGValue.Value.ToString());
            controller.CurrentCommand = txtArmCharacter.Text + "STEP " + txtSpeed.Text + "," + controller.BodyValue.ToString() + ", " + controller.ShoulderValue.ToString() + " ," + controller.ArmValue.ToString() + ", " + controller.GripperU.ToString() + "," + controller.GripperRotate.ToString() + ", " + controller.GripperG.ToString() + ",\r";
            txtSendCommand.Text = controller.CurrentCommand;
        }

        private void btnClearConsole_Click(object sender, EventArgs e)
        {
            lstData.Items.Clear();
            if (cm != null)
            {
                cm.Close();
            } 
        }

        private void btnSaveProgram_Click(object sender, EventArgs e)
        {
            RecordProgram = true;// allow recording of the program
        }

        public void CalclateReverseProgram()
        {
            // Final Program Commands 
            foreach (string command in FinalProgramCommands)
            {
                string[] commandSub = command.Split(',');
                string finalcommandX = "";

                for (int i = 0; i < 8; i++)
                {
                    if(i>1 && i < 8)
                    {
                        double current = double.Parse(commandSub[i]);
                        if (current > 0)
                        {
                            current *= -1;
                            finalcommandX = ","+current.ToString();

                        }
                        if (current > 0)
                        {
                            current *= -1;
                            finalcommandX = "," + current.ToString();
                        }

                    }else
                    {
                        finalcommandX = commandSub[i];
                    }                  
                   
                }
                FInalProgramTempR.Add(command);
            }
            FInalProgramTempR.Reverse();
            FinalProgramCommands = FInalProgramTempR;
        }

        private void backRunCode_DoWork(object sender, DoWorkEventArgs e)
        {
            double progressCounter = 0;
            foreach (var commands in FinalProgramCommands)
            {
                while (IsCarrageReturnReceived == false)
                {
                    Console.WriteLine("Waiting for the Arm to Report Back");
                }
                IsCarrageReturnReceived = false;
                    Thread.Sleep(20);
                    SP.Write(commands); //execute command
                    progressCounter += 100 / FinalProgramCommands.Count;
                    backRunCode.ReportProgress((int)progressCounter);// add pecerntage to each and every command executed
                
            }
            backRunCode.ReportProgress(100);
        }

        private void backRunCode_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pBar.Value = e.ProgressPercentage;
            lblProgress.Text = e.ProgressPercentage.ToString();
        }

        private void backRunCode_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            lstData.Items.Add("Program Successfully Executed the Commands");
        }

        private void lstData_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // open Full Command View
            List<string> listofCMD = new List<string>();
            foreach (var item in lstData.Items)
            {
                listofCMD.Add(item.ToString());
            }
             cm= new commandview(listofCMD);
            cm.Show();
        }

        private void btnAboutProject_Click(object sender, EventArgs e)
        {

            AboutProject aboutForm = new AboutProject();
            aboutForm.Show();
        }

        private void btnBodyMoveLeft_Click(object sender, EventArgs e)
        {
            if (SP.IsOpen)
            {
                SP.Write(txtArmCharacter.Text + "STEP " + txtSpeed.Text + "," + "100,0,0,0,0,0,0,\r");
            }
        }

        private void btnBodyMoveRight_Click(object sender, EventArgs e)
        {
            if (SP.IsOpen)
            {
                SP.Write(txtArmCharacter.Text + "STEP " + txtSpeed.Text + "," + "-100,0,0,0,0,0,0,\r");
            }
        }

        private void btnShoulderMoveUp_Click(object sender, EventArgs e)
        {
            if (SP.IsOpen)
            {
                SP.Write(txtArmCharacter.Text + "STEP " + txtSpeed.Text + "," + "0,-100,0,0,0,0,0,\r");
            }
        }

        private void btnShoulderMoveDown_Click(object sender, EventArgs e)
        {
            if (SP.IsOpen)
            {
                SP.Write(txtArmCharacter.Text + "STEP " + txtSpeed.Text + "," + "0,100,0,0,0,0,0,\r");
            }
        }

        private void btnArmMoveUp_Click(object sender, EventArgs e)
        {
            if (SP.IsOpen)
            {
                SP.Write(txtArmCharacter.Text + "STEP " + txtSpeed.Text + "," + "0,0,-100,0,0,0,0,\r");
            }
        }

        private void btnArmMoveDown_Click(object sender, EventArgs e)
        {
            if (SP.IsOpen)
            {
                SP.Write(txtArmCharacter.Text + "STEP " + txtSpeed.Text + "," + "0,0,100,0,0,0,0,\r");
            }
        }

        private void btnGripperMoveUp_Click(object sender, EventArgs e)
        {
            if (SP.IsOpen)
            {
                SP.Write(txtArmCharacter.Text + "STEP " + txtSpeed.Text + "," + "0,0,0,100,0,0,0,\r");
            }
        }

        private void btnGripperMoveDown_Click(object sender, EventArgs e)
        {
            if (SP.IsOpen)
            {
                SP.Write(txtArmCharacter.Text + "STEP " + txtSpeed.Text + "," + "0,0,0,-100,0,0,0,\r");
            }
        }

        private void btnGripperRotateLeft_Click(object sender, EventArgs e)
        {
            if (SP.IsOpen)
            {
                SP.Write(txtArmCharacter.Text + "STEP " + txtSpeed.Text + "," + "0,0,0,0,-100,0,0,\r");
            }
        }

        private void btnGripperRotateRight_Click(object sender, EventArgs e)
        {
            if (SP.IsOpen)
            {
                SP.Write(txtArmCharacter.Text + "STEP " + txtSpeed.Text + "," + "0,0,0,0,100,0,0,\r");
            }
        }

        private void btnGripperClose_Click(object sender, EventArgs e)
        {
            if (SP.IsOpen)
            {
                SP.Write(txtArmCharacter.Text + "STEP " + txtSpeed.Text + "," + "0,0,0,0,0,-100,0,\r");
            }
        }

        private void btnGripperOpen_Click(object sender, EventArgs e)
        {
            if (SP.IsOpen)
            {
                SP.Write(txtArmCharacter.Text + "STEP " + txtSpeed.Text + "," + "0,0,0,0,0,100,0,\r");
            }
        }

        private void btnRecordStep_Click(object sender, EventArgs e)
        {
            txtCurrentCommand.Text = " ";
            if (SP.IsOpen)
            {
                SP.Write("@READ \r");
            }
        }

        private void btnInitialPosition_Click(object sender, EventArgs e)
        {
            if (!backRunCode.IsBusy)
            {
                if (SP.IsOpen)
                {
                    //reverse to the initial position
                    FinalProgramTempF = FinalProgramCommands;
                    CalclateReverseProgram();
                    backRunCode.RunWorkerAsync();
                }
            }else
            {
               MessageBox.Show("System is Still Executing the Steps..");
            }
        }

        private void btnReadWholeProgram_Click(object sender, EventArgs e)
        {

            if (FinalProgramCommands.Count <1)
            {
                OpenFileDialog openFile = new OpenFileDialog();
                openFile.ShowDialog();
                string filepath = openFile.FileName.ToString();
                if (string.IsNullOrEmpty(filepath))
                {
                    MessageBox.Show("File Not Selected");
                }else
                {
                    List<string> data = FileHandler.ReadProgramFromFile(filepath);
                    if (data.Count<1)
                    {
                        MessageBox.Show("Selected File is Empty.");
                    }else
                    {
                        FinalProgramCommands = null;
                        FinalProgramCommands = data; // new program stored on the textfile
                    }      
                }              
            }else
            {
                MessageBox.Show("Notice! , This action will clear the program stored on Buffer.");
            }
            // read data from the textfile
        }

        private void btnCloseGripper_Click(object sender, EventArgs e)
        {
            if (SP.IsOpen)
            {
                SP.Write("@CLOSE \r");
            }
        }

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            if (SP.IsOpen)
            {
                SP.Write("@ARM " + txtArmCharacter.Text + " \r");
            }
        }

        private void btnWriteWholeProgram_Click(object sender, EventArgs e)
        {
            if (FinalProgramCommands.Count > 0)
            {
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.Title = "Create A File To Save Data Into";
                string filepath = "";    
                saveFile.ShowDialog();
                filepath = saveFile.FileName;
                if (string.IsNullOrEmpty(filepath))
                {
                    MessageBox.Show("Please Create a File to Save the program into");
                }else
                {
                    FileHandler.WriteProgramToFile(filepath,FinalProgramCommands);
                }

            }else
            {
                MessageBox.Show("Oops! , Nothing was Recorded.");
            }
        }

        private void btnConnectionSetup_Click(object sender, EventArgs e)
        {
            if (rdbServerCheck.Checked == true)
            {
                MessageBox.Show("Program Working as a Server..");
                bool innerValue = NetworkConnectivity.Server(txtIpAddress.Text, txtData.Text, txtPort.Text); // plz ,next create server thread
            }

            if (rdbClientCheck.Checked == true)
            {
                MessageBox.Show("Program Working as a Client..");
                bool innerValue = NetworkConnectivity.Client(txtIpAddress.Text, txtData.Text, txtPort.Text); // plz, next create client thread for connection
                if (innerValue)
                {
                    //RUN STEPS
                    MessageBox.Show("Gotta Move !!!!.");
                    // getSteps from the file
                    List<string> data = FileHandler.ReadProgramFromFile("co.txt");
                        if (data.Count < 1)
                        {
                            MessageBox.Show("Selected File is Empty.");
                        }
                        else
                        {
                            FinalProgramCommands = null;
                            FinalProgramCommands = data; // new program stored on the textfile
                        }
                    }

                if (!backRunCode.IsBusy)
                {
                     backRunCode.RunWorkerAsync();
                }
                   
                }
            }
        }
     
    }

