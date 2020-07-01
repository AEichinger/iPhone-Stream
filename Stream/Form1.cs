//AE Using Tools

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.Net;
//using AXVLC;
//using AxAXVLC;

// AE Ende Using Tools






namespace Stream
{
    public partial class Form1 : Form
    {
        // Funktion / Methoden von AE *********************************************************************************************************************
        // hier werden eigenen Funktionen verwaltet. Die Funktionen beginnen alle mit func

        // Start PING
        public PingReply funcPing(string IP)
        {
            Ping myPing = new Ping();
            PingReply reply = myPing.Send(IP, 1000);
            return reply;
        }

        // Liest die Systemzeit
        void UhrzeitTick(object sender, EventArgs e)
        {
            tBUhrzeit.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        // Startet ein Programm mit Parameter
        static int funcProgStart(string Prog, string Para)     //Starte ein Programm mit Rückgabe ID
        {
            var myProcess = new Process();
            //	var ProcessStartInfo startInfo = new ProcessStartInfo();
            myProcess.StartInfo.FileName = Prog;
            myProcess.StartInfo.Arguments = Para;
            myProcess.Start();
            var ProgId = myProcess.Id;
            return ProgId;
        }


        // Close Programm
        public void funcProgClose(int ID)                  // Beendet ein Programm
        {
            Process Prog = Process.GetProcessById(ID);
            Prog.Kill();
        }


        // Read CSV Datei
        void ReadCSV(String file)
        {
            Clear_all();
            String rowValue;
            String[] cellValue;

            if (System.IO.File.Exists(file))
            {

                StreamReader streamReader = new StreamReader(file);
                rowValue = streamReader.ReadLine();
                cellValue = rowValue.Split(';');


                for (int i = 0; i <= cellValue.Length - 1; i++)
                {
                    DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();

                    column.Name = cellValue[i];
                    column.HeaderText = cellValue[i];
                    dataGridView1.Columns.Add(column);

                }


                while (streamReader.Peek() != -1)
                {

                    rowValue = streamReader.ReadLine();
                    cellValue = rowValue.Split(';');
                    dataGridView1.Rows.Add(cellValue);
                }

                streamReader.Close();

            }

        }

        //Save CSV
        void SaveCSV(String file)
        {
            StreamWriter streamWriter = new StreamWriter(file, false);
            string strHeader = "";

            for (int i = 0; i <= dataGridView1.Columns.Count - 1; i++)
            {
                strHeader += dataGridView1.Columns[i].HeaderText + ";";

            }
            strHeader = strHeader.TrimEnd(';');
            streamWriter.WriteLine(strHeader);

            for (int m = 0; m < dataGridView1.Rows.Count - 1; m++)
            {
                string strRowValue = "";
                for (int n = 0; n < dataGridView1.Columns.Count; n++)
                {
                    strRowValue += dataGridView1.Rows[m].Cells[n].Value + ";";
                }
                strRowValue = strRowValue.TrimEnd(';');
                streamWriter.WriteLine(strRowValue);

            }
            streamWriter.Close();

        }

        //Clear Datagrid All
        void Clear_all()
        {
            dataGridView1.Columns.Clear();
        }


        // Start iPhone Stream  
        public void funcStartiPHoneStream(int CameraNr, string IP)
        {
            string quote = "\"";
            MyGlobal.VLC = quote + cb_VLCPath.Text + quote;  //64 oder 32 bit Betriebssystem
            MyGlobal.StreamPara = quote + "rtsp://" + IP + ":554" + quote;
            MyGlobal.StreamFile = " --qt-start-minimized :sout=#file{dst=" + quote + MyGlobal.Pfad + cbTeam.Text + " " + dateTimePicker.Text + "stream" + CameraNr + ".avi" + quote + "}";
            //MyGlobal.StreamFile = " --qt-start" ;
            //MessageBox.Show(MyGlobal.StreamPara + MyGlobal.StreamFile);
            MyGlobal.VLCProNr[CameraNr] = funcProgStart(MyGlobal.VLC, MyGlobal.StreamPara + MyGlobal.StreamFile);

        }


        // Ende der Funktionen / Methoden von **************************************************************************************************************







        public Form1()
        {
            InitializeComponent();

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Sekunden_Tick(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)  // Timer Code
        {
            string IP = cbIP1.Text.ToString();
            if (string.IsNullOrEmpty(IP))
            {
                btPing1.BackColor = Color.Red;
            }
            else
            {
                const string From0To199 = "[01]?[0-9][0-9]?";
                const string From200To249 = "2[0-4][0-9]";
                const string From250To255 = "25[0-5]";
                const string OneIPPlace = "(" + From250To255 + "|" + From200To249 + "|" + From0To199 + ")";
                if (System.Text.RegularExpressions.Regex.IsMatch(IP, "\\b(" + OneIPPlace + "\\.){3}" + OneIPPlace + "$\\b"))
                {
                    PingReply P = funcPing(IP);
                    if (P.Status == IPStatus.Success)
                    {
                        btPing1.BackColor = Color.Green;
                    }
                    else
                    {
                        btPing1.BackColor = Color.Orange;
                    }
                }
                else
                {
                    btPing1.BackColor = Color.Blue;
                }
            }

            IP = cbIP2.Text.ToString();
            if (string.IsNullOrEmpty(IP))
            {
                btPing2.BackColor = Color.Red;
            }
            else
            {
                const string From0To199 = "[01]?[0-9][0-9]?";
                const string From200To249 = "2[0-4][0-9]";
                const string From250To255 = "25[0-5]";
                const string OneIPPlace = "(" + From250To255 + "|" + From200To249 + "|" + From0To199 + ")";
                if (System.Text.RegularExpressions.Regex.IsMatch(IP, "\\b(" + OneIPPlace + "\\.){3}" + OneIPPlace + "$\\b"))
                {
                    PingReply P = funcPing(IP);
                    if (P.Status == IPStatus.Success)
                    {
                        btPing2.BackColor = Color.Green;
                    }
                    else
                    {
                        btPing2.BackColor = Color.Orange;
                    }
                }
                else
                {
                    btPing2.BackColor = Color.Blue;
                }
            }

        }

        private void Uhrzeit_Tick(object sender, EventArgs e)
        {
            tBUhrzeit.Text = DateTime.Now.ToString("HH:mm:ss");
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btStreamPfad_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.FolderBrowserDialog objDialog = new FolderBrowserDialog();
            objDialog.Description = "Wohin sollen die Streams and Capturs gespeichert werden?";
            objDialog.SelectedPath = MyGlobal.Pfad;       // Vorgabe Pfad (und danach der gewählte Pfad)
            DialogResult objResult = objDialog.ShowDialog(this);
            if (objResult == DialogResult.OK)
            {
                MyGlobal.Pfad = objDialog.SelectedPath + "\\";
                btStreamPfad.ForeColor = Color.Green;
                btStreamPfad.Text = MyGlobal.Pfad;
            }
            else
            {
                MessageBox.Show("Bitte wählen sie einen Pfad und klicken auf OK!");
                MyGlobal.Pfad = "";
                btStreamPfad.Text = "Wähle eine Pfad für die Streams";
                btStreamPfad.ForeColor = Color.Red;
            }


        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btOeffnen_Click(object sender, EventArgs e)
        {
            //openFileDialog1.ShowDialog();
            //ReadCSV(openFileDialog1.FileName);

            if (File.Exists(MyGlobal.Pfad + MyGlobal.iPhoneFile + MyGlobal.iPhoneFileFormat) == false)    // File nicht vorhanden
            {
                using (StreamWriter sw = File.CreateText(MyGlobal.Pfad + MyGlobal.iPhoneFile + MyGlobal.iPhoneFileFormat))
                {
                    sw.WriteLine(MyGlobal.iPhoneFileHeader);
                }
            }
            ReadCSV(MyGlobal.Pfad + MyGlobal.iPhoneFile + MyGlobal.iPhoneFileFormat);
        }

        private void btSpeichern_Click(object sender, EventArgs e)
        {
            if (File.Exists(MyGlobal.Pfad + MyGlobal.iPhoneFile + MyGlobal.iPhoneFileFormat) == false)    // File nicht vorhanden
            {
                using (StreamWriter sw = File.CreateText(MyGlobal.Pfad + MyGlobal.iPhoneFile + MyGlobal.iPhoneFileFormat))
                {
                    sw.WriteLine(MyGlobal.iPhoneFileHeader);
                }
            }
            SaveCSV(MyGlobal.Pfad + MyGlobal.iPhoneFile + MyGlobal.iPhoneFileFormat);
        }

        private void btCamTest_Click(object sender, EventArgs e)
        {
            string IP1 = cbIP1.SelectedItem.ToString();
            string info = " --zoom 1  ";
            axVLCPluginLinks.playlist.add("rtsp://" + IP1 + ":554", null, info);
            axVLCPluginLinks.playlist.play();

            string IP2 = cbIP2.SelectedItem.ToString();
            axVLCPluginRechts.playlist.add("rtsp://" + IP2 + ":554", null, info);
            axVLCPluginRechts.playlist.play();
         
            //MyGlobal.Sekunden = 0;
            //MyGlobal.CaptureCounter = 0;   // Setzt bei jedem Start den  Capture Counter auf 0
            //Sekunden.Start();

            //var i = 1;
            //var IP = "";
            //foreach (DataGridViewRow dgvRow in dataGridView1.Rows)
            ////			foreach (DataGridViewRow item in dataGridView1.SelectedRows)
            //{
            //    if (dgvRow.Selected)
            //    {
            //        IP = dgvRow.Cells[0].Value.ToString();
            //        //	MessageBox.Show(IP.ToString());
            //        //	MessageBox.Show(i.ToString());
            //        // values[i] = dgv.SelectedCells[i].Value.ToString();
            //        //funcStartShowiPHone(i, IP);

            //        string quote = "\"";

            //        MyGlobal.VLC = quote + cb_VLCPath.Text + quote;  //64 oder 32 bit Betriebssystem
            //                                                         //	 string info = "--network-caching=10000 --withe = 50 --one-instance --no-video-title-show --no-qt-name-in-title ";
            //        string info = " --zoom 0.25  ";


            //        MyGlobal.StreamPara = quote + "rtsp://" + IP + ":554 " + info + quote;
            //        //   		 MyGlobal.StreamFile = ;
            //        // MyGlobal.StreamFile = " --qt-start-minimized :sout=#file{dst=" + quote + MyGlobal.Pfad + cbTeam.Text + " " + DateTimePicker1.Text + "stream"+ CameraNr +".avi" + quote + "}";

            //        // MyGlobal.StreamFile = " --qt-start" ;

            //        MessageBox.Show(MyGlobal.VLC + MyGlobal.StreamPara);
            //        MyGlobal.VLCProNr[i] = funcProgStart(MyGlobal.VLC, MyGlobal.StreamPara);


            //        i = i + 1;
            //    }
            //}
        }

        private void btStartStream_Click(object sender, EventArgs e)
        {
            MyGlobal.Sekunden = 0;
            MyGlobal.CaptureCounter = 0;   // Setzt bei jedem Start den  Capture Counter auf 0
            Sekunden.Start();

            var i = 1;
            var IP = "";
            foreach (DataGridViewRow dgvRow in dataGridView1.Rows)
            //			foreach (DataGridViewRow item in dataGridView1.SelectedRows)
            {
                if (dgvRow.Selected)
                {
                    IP = dgvRow.Cells[0].Value.ToString();
                    //	MessageBox.Show(IP.ToString());
                    //	MessageBox.Show(i.ToString());
                    // values[i] = dgv.SelectedCells[i].Value.ToString();
                    //funcStartShowiPHone(i, IP);

                    string quote = "\"";

                    MyGlobal.VLC = quote + cb_VLCPath.Text + quote;  //64 oder 32 bit Betriebssystem
                                                                     //	 string info = "--network-caching=10000 --withe = 50 --one-instance --no-video-title-show --no-qt-name-in-title ";
                    string info = " --zoom 0.25  ";


                    MyGlobal.StreamPara = quote + "rtsp://" + IP + ":554 " + info + quote;
                    //   		 MyGlobal.StreamFile = ;
                    // MyGlobal.StreamFile = " --qt-start-minimized :sout=#file{dst=" + quote + MyGlobal.Pfad + cbTeam.Text + " " + DateTimePicker1.Text + "stream"+ CameraNr +".avi" + quote + "}";

                    // MyGlobal.StreamFile = " --qt-start" ;

                    //MessageBox.Show(MyGlobal.VLC + MyGlobal.StreamPara);
                    //axVLCPluginLinks.playlist.add(MyGlobal.StreamPara, null, ":sout=#transcode{vcodec=theo,vb=800,acodec=flac,ab=128,channels=2,samplerate=44100}:file{dst=C:\\123.ogg,no-overwrite} :sout-keep");
                    //axVLCPluginLinks.playlist.play();

                    MyGlobal.VLCProNr[i] = funcProgStart(MyGlobal.VLC, MyGlobal.StreamPara);


                    i = i + 1;
                }
            }




        }


        private void btTEST_Click(object sender, EventArgs e)
        {
                    string IP = cbIP1.Text;
              //      string quote = "\"";
              //      string info = " --zoom 0.25  ";
                    MyGlobal.StreamPara = "rtsp://" + IP + ":554 ";
                     MessageBox.Show( MyGlobal.StreamPara);

                    axVLCPluginLinks.playlist.add(MyGlobal.StreamPara);
                    axVLCPluginLinks.playlist.play();
        }



        private void btDel1_Click(object sender, EventArgs e)
        {
            cbIP1.Items.Remove(cbIP1.SelectedItem);
        }

        private void btAdd1_Click(object sender, EventArgs e)
        {
            cbIP1.Items.Add(cbIP1.SelectedItem);
        }

        private void btPing_Click(object sender, EventArgs e)
        {

        }

        private void btAdd1_Click_1(object sender, EventArgs e)
        {
        
        }

        private void btDel1_Click_1(object sender, EventArgs e)
        {
      
        }

        private void button1_Click(object sender, EventArgs e)
        {

                    

        }

        private void cbIP1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void axVLCPluginLinks_Enter(object sender, EventArgs e)
        {

        }

        private void cbIP2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbIP2_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void btPing2_Click(object sender, EventArgs e)
        {

        }

        private void btStartVideo_Click(object sender, EventArgs e)
        {

            MyGlobal.Sekunden = 0;
            MyGlobal.CaptureCounter = 0;   // Setzt bei jedem Start den  Capture Counter auf 0
            Sekunden.Start();

            int Cam = 1;
            string IP = cbIP1.SelectedItem.ToString();
            funcStartiPHoneStream(Cam,IP);
            Cam = 2;
            IP = cbIP2.SelectedItem.ToString();
            funcStartiPHoneStream(Cam, IP);

        }

        private void dateTimePicker_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void btStopAllVLC_Click(object sender, EventArgs e)
        {
            Sekunden.Stop();
            foreach (Process clsProcess in Process.GetProcesses())
            {
                if (clsProcess.ProcessName.StartsWith("vlc"))  // Beendet alle VLC Prozess bzw. Programme
                {
                    clsProcess.Kill();
                }
            }
        }

        private void tBSekunden_TextChanged(object sender, EventArgs e)
        {

        }

        void SekundenTick(object sender, EventArgs e)
        {

            MyGlobal.Sekunden = MyGlobal.Sekunden + 1;
            tBSekunden.Text = MyGlobal.Sekunden.ToString();
        }
    }
}

