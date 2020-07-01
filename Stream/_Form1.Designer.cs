namespace Stream
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btPing1 = new System.Windows.Forms.Button();
            this.cbIP1 = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btTEST = new System.Windows.Forms.Button();
            this.btStartStream = new System.Windows.Forms.Button();
            this.btCamTest = new System.Windows.Forms.Button();
            this.btStartVideo = new System.Windows.Forms.Button();
            this.btOeffnen = new System.Windows.Forms.Button();
            this.btSpeichern = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tBSekunden = new System.Windows.Forms.TextBox();
            this.nUpDoZurueck = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nUpDoDauer = new System.Windows.Forms.NumericUpDown();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.Sekunden = new System.Windows.Forms.Timer(this.components);
            this.Uhrzeit = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.tBUhrzeit = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btStreamPfad = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_StreamSyntax = new System.Windows.Forms.ComboBox();
            this.cb_VLCPath = new System.Windows.Forms.ComboBox();
            this.axVLCPluginRechts = new AxAXVLC.AxVLCPlugin2();
            this.axVLCPluginLinks = new AxAXVLC.AxVLCPlugin2();
            this.cbIP2 = new System.Windows.Forms.ComboBox();
            this.btPing2 = new System.Windows.Forms.Button();
            this.btAdd1 = new System.Windows.Forms.Button();
            this.btDel1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDoZurueck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDoDauer)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axVLCPluginRechts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axVLCPluginLinks)).BeginInit();
            this.SuspendLayout();
            // 
            // btPing1
            // 
            this.btPing1.Location = new System.Drawing.Point(189, 9);
            this.btPing1.Name = "btPing1";
            this.btPing1.Size = new System.Drawing.Size(47, 23);
            this.btPing1.TabIndex = 42;
            this.btPing1.Text = "PING";
            this.btPing1.UseVisualStyleBackColor = true;
            // 
            // cbIP1
            // 
            this.cbIP1.FormattingEnabled = true;
            this.cbIP1.Items.AddRange(new object[] {
            "192.168.1.104",
            "192.168.1.222",
            "google.de"});
            this.cbIP1.Location = new System.Drawing.Point(8, 9);
            this.cbIP1.Name = "cbIP1";
            this.cbIP1.Size = new System.Drawing.Size(175, 21);
            this.cbIP1.TabIndex = 41;
            this.cbIP1.Text = "192.168.1.100";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 60);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1121, 540);
            this.tabControl1.TabIndex = 43;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btDel1);
            this.tabPage1.Controls.Add(this.btAdd1);
            this.tabPage1.Controls.Add(this.btPing2);
            this.tabPage1.Controls.Add(this.cbIP2);
            this.tabPage1.Controls.Add(this.btTEST);
            this.tabPage1.Controls.Add(this.btStartStream);
            this.tabPage1.Controls.Add(this.axVLCPluginRechts);
            this.tabPage1.Controls.Add(this.axVLCPluginLinks);
            this.tabPage1.Controls.Add(this.btCamTest);
            this.tabPage1.Controls.Add(this.btStartVideo);
            this.tabPage1.Controls.Add(this.btOeffnen);
            this.tabPage1.Controls.Add(this.btSpeichern);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.tBSekunden);
            this.tabPage1.Controls.Add(this.btPing1);
            this.tabPage1.Controls.Add(this.nUpDoZurueck);
            this.tabPage1.Controls.Add(this.cbIP1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.nUpDoDauer);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1113, 514);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Stream";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btTEST
            // 
            this.btTEST.Location = new System.Drawing.Point(542, 122);
            this.btTEST.Name = "btTEST";
            this.btTEST.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btTEST.Size = new System.Drawing.Size(75, 23);
            this.btTEST.TabIndex = 73;
            this.btTEST.Text = "T E S T";
            this.btTEST.UseVisualStyleBackColor = true;
            this.btTEST.Click += new System.EventHandler(this.btTEST_Click);
            // 
            // btStartStream
            // 
            this.btStartStream.Location = new System.Drawing.Point(542, 96);
            this.btStartStream.Name = "btStartStream";
            this.btStartStream.Size = new System.Drawing.Size(75, 20);
            this.btStartStream.TabIndex = 72;
            this.btStartStream.Text = "Start Stream";
            this.btStartStream.UseVisualStyleBackColor = true;
            this.btStartStream.Click += new System.EventHandler(this.btStartStream_Click);
            // 
            // btCamTest
            // 
            this.btCamTest.Location = new System.Drawing.Point(542, 70);
            this.btCamTest.Name = "btCamTest";
            this.btCamTest.Size = new System.Drawing.Size(75, 20);
            this.btCamTest.TabIndex = 69;
            this.btCamTest.Text = "Kamera Test";
            this.btCamTest.UseVisualStyleBackColor = true;
            this.btCamTest.Click += new System.EventHandler(this.btCamTest_Click);
            // 
            // btStartVideo
            // 
            this.btStartVideo.Location = new System.Drawing.Point(8, 78);
            this.btStartVideo.Name = "btStartVideo";
            this.btStartVideo.Size = new System.Drawing.Size(147, 23);
            this.btStartVideo.TabIndex = 68;
            this.btStartVideo.Text = "Start Video";
            this.btStartVideo.UseVisualStyleBackColor = true;
            // 
            // btOeffnen
            // 
            this.btOeffnen.Location = new System.Drawing.Point(359, 78);
            this.btOeffnen.Name = "btOeffnen";
            this.btOeffnen.Size = new System.Drawing.Size(75, 23);
            this.btOeffnen.TabIndex = 66;
            this.btOeffnen.Text = "Öffnen";
            this.btOeffnen.UseVisualStyleBackColor = true;
            this.btOeffnen.Click += new System.EventHandler(this.btOeffnen_Click);
            // 
            // btSpeichern
            // 
            this.btSpeichern.Location = new System.Drawing.Point(440, 78);
            this.btSpeichern.Name = "btSpeichern";
            this.btSpeichern.Size = new System.Drawing.Size(75, 23);
            this.btSpeichern.TabIndex = 67;
            this.btSpeichern.Text = "Speichern";
            this.btSpeichern.UseVisualStyleBackColor = true;
            this.btSpeichern.Click += new System.EventHandler(this.btSpeichern_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.Location = new System.Drawing.Point(8, 107);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(507, 161);
            this.dataGridView1.TabIndex = 65;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tBSekunden
            // 
            this.tBSekunden.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBSekunden.Location = new System.Drawing.Point(1030, 12);
            this.tBSekunden.Name = "tBSekunden";
            this.tBSekunden.Size = new System.Drawing.Size(67, 35);
            this.tBSekunden.TabIndex = 61;
            // 
            // nUpDoZurueck
            // 
            this.nUpDoZurueck.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.nUpDoZurueck.Location = new System.Drawing.Point(932, 12);
            this.nUpDoZurueck.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nUpDoZurueck.Name = "nUpDoZurueck";
            this.nUpDoZurueck.Size = new System.Drawing.Size(66, 35);
            this.nUpDoZurueck.TabIndex = 64;
            this.nUpDoZurueck.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(651, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 35);
            this.label3.TabIndex = 62;
            this.label3.Text = "Dauer der Aufzeichnung in Sekunden:";
            this.label3.UseCompatibleTextRendering = true;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(838, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 43);
            this.label4.TabIndex = 63;
            this.label4.Text = "Start der Aufzeichnung vor Sekunden:";
            this.label4.UseCompatibleTextRendering = true;
            // 
            // nUpDoDauer
            // 
            this.nUpDoDauer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nUpDoDauer.Location = new System.Drawing.Point(751, 12);
            this.nUpDoDauer.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nUpDoDauer.Name = "nUpDoDauer";
            this.nUpDoDauer.Size = new System.Drawing.Size(66, 35);
            this.nUpDoDauer.TabIndex = 60;
            this.nUpDoDauer.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1113, 514);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(139, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Sekunden
            // 
            this.Sekunden.Interval = 1000;
            this.Sekunden.Tick += new System.EventHandler(this.Sekunden_Tick);
            // 
            // Uhrzeit
            // 
            this.Uhrzeit.Enabled = true;
            this.Uhrzeit.Interval = 1000;
            this.Uhrzeit.Tick += new System.EventHandler(this.Uhrzeit_Tick);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(9, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 59;
            this.label2.Text = "Kamera IP:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tBUhrzeit
            // 
            this.tBUhrzeit.Location = new System.Drawing.Point(1017, 23);
            this.tBUhrzeit.Name = "tBUhrzeit";
            this.tBUhrzeit.Size = new System.Drawing.Size(100, 20);
            this.tBUhrzeit.TabIndex = 57;
            this.tBUhrzeit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "dd.MM.yyyy";
            this.dateTimePicker.Location = new System.Drawing.Point(807, 23);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(195, 20);
            this.dateTimePicker.TabIndex = 60;
            // 
            // btStreamPfad
            // 
            this.btStreamPfad.ForeColor = System.Drawing.Color.Red;
            this.btStreamPfad.Location = new System.Drawing.Point(274, 19);
            this.btStreamPfad.Name = "btStreamPfad";
            this.btStreamPfad.Size = new System.Drawing.Size(205, 23);
            this.btStreamPfad.TabIndex = 61;
            this.btStreamPfad.Text = "Wähle eine Pfad für die Streams";
            this.btStreamPfad.UseVisualStyleBackColor = true;
            this.btStreamPfad.Click += new System.EventHandler(this.btStreamPfad_Click);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(271, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 13);
            this.label5.TabIndex = 62;
            this.label5.Text = "wähle den Projekt Ordner";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(804, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 63;
            this.label6.Text = "Datum";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(1014, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 64;
            this.label1.Text = "Uhrzeit";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cb_StreamSyntax
            // 
            this.cb_StreamSyntax.FormattingEnabled = true;
            this.cb_StreamSyntax.Items.AddRange(new object[] {
            "rtsp://192.168.0.220",
            "rtsp://root:891Xb73!@192.168.1.104:554/axis-media/media.amp"});
            this.cb_StreamSyntax.Location = new System.Drawing.Point(486, 44);
            this.cb_StreamSyntax.Margin = new System.Windows.Forms.Padding(2);
            this.cb_StreamSyntax.Name = "cb_StreamSyntax";
            this.cb_StreamSyntax.Size = new System.Drawing.Size(267, 21);
            this.cb_StreamSyntax.TabIndex = 66;
            this.cb_StreamSyntax.Text = "rtsp://root:891Xb73!@192.168.1.104:554/axis-media/media.amp";
            // 
            // cb_VLCPath
            // 
            this.cb_VLCPath.FormattingEnabled = true;
            this.cb_VLCPath.Items.AddRange(new object[] {
            "C:\\\\Program Files\\\\VideoLAN\\\\VLC\\\\vlc.exe",
            "C:\\\\Program Files (x86)\\\\VideoLAN\\\\VLC\\\\vlc.exe"});
            this.cb_VLCPath.Location = new System.Drawing.Point(486, 19);
            this.cb_VLCPath.Margin = new System.Windows.Forms.Padding(2);
            this.cb_VLCPath.Name = "cb_VLCPath";
            this.cb_VLCPath.Size = new System.Drawing.Size(267, 21);
            this.cb_VLCPath.TabIndex = 65;
            this.cb_VLCPath.Text = "C:\\Program Files (x86)\\VideoLAN\\VLC\\vlc.exe";
            // 
            // axVLCPluginRechts
            // 
            this.axVLCPluginRechts.Enabled = true;
            this.axVLCPluginRechts.Location = new System.Drawing.Point(224, 274);
            this.axVLCPluginRechts.Name = "axVLCPluginRechts";
            this.axVLCPluginRechts.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axVLCPluginRechts.OcxState")));
            this.axVLCPluginRechts.Size = new System.Drawing.Size(217, 193);
            this.axVLCPluginRechts.TabIndex = 71;
            // 
            // axVLCPluginLinks
            // 
            this.axVLCPluginLinks.Enabled = true;
            this.axVLCPluginLinks.Location = new System.Drawing.Point(8, 274);
            this.axVLCPluginLinks.Name = "axVLCPluginLinks";
            this.axVLCPluginLinks.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axVLCPluginLinks.OcxState")));
            this.axVLCPluginLinks.Size = new System.Drawing.Size(217, 193);
            this.axVLCPluginLinks.TabIndex = 70;
            // 
            // cbIP2
            // 
            this.cbIP2.FormattingEnabled = true;
            this.cbIP2.Items.AddRange(new object[] {
            "192.168.1.104",
            "192.168.1.222",
            "google.de"});
            this.cbIP2.Location = new System.Drawing.Point(8, 36);
            this.cbIP2.Name = "cbIP2";
            this.cbIP2.Size = new System.Drawing.Size(175, 21);
            this.cbIP2.TabIndex = 74;
            this.cbIP2.Text = "192.168.1.100";
            // 
            // btPing2
            // 
            this.btPing2.Location = new System.Drawing.Point(189, 34);
            this.btPing2.Name = "btPing2";
            this.btPing2.Size = new System.Drawing.Size(47, 23);
            this.btPing2.TabIndex = 75;
            this.btPing2.Text = "PING";
            this.btPing2.UseVisualStyleBackColor = true;
            // 
            // btAdd1
            // 
            this.btAdd1.Location = new System.Drawing.Point(258, 9);
            this.btAdd1.Name = "btAdd1";
            this.btAdd1.Size = new System.Drawing.Size(47, 23);
            this.btAdd1.TabIndex = 76;
            this.btAdd1.Text = "Add 1";
            this.btAdd1.UseVisualStyleBackColor = true;
            this.btAdd1.Click += new System.EventHandler(this.btAdd1_Click);
            // 
            // btDel1
            // 
            this.btDel1.Location = new System.Drawing.Point(311, 9);
            this.btDel1.Name = "btDel1";
            this.btDel1.Size = new System.Drawing.Size(47, 23);
            this.btDel1.TabIndex = 77;
            this.btDel1.Text = "Del 1";
            this.btDel1.UseVisualStyleBackColor = true;
            this.btDel1.Click += new System.EventHandler(this.btDel1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 612);
            this.Controls.Add(this.cb_StreamSyntax);
            this.Controls.Add(this.cb_VLCPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btStreamPfad);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tBUhrzeit);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDoZurueck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDoDauer)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axVLCPluginRechts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axVLCPluginLinks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btPing1;
        private System.Windows.Forms.ComboBox cbIP1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Timer Sekunden;
        private System.Windows.Forms.Timer Uhrzeit;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox tBSekunden;
        private System.Windows.Forms.NumericUpDown nUpDoZurueck;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nUpDoDauer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBUhrzeit;
        protected System.Windows.Forms.DateTimePicker DateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button btStreamPfad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btCamTest;
        private System.Windows.Forms.Button btStartVideo;
        private System.Windows.Forms.Button btOeffnen;
        private System.Windows.Forms.Button btSpeichern;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private AxAXVLC.AxVLCPlugin2 axVLCPluginRechts;
        private AxAXVLC.AxVLCPlugin2 axVLCPluginLinks;
        internal System.Windows.Forms.ComboBox cb_StreamSyntax;
        internal System.Windows.Forms.ComboBox cb_VLCPath;
        private System.Windows.Forms.Button btStartStream;
        private System.Windows.Forms.Button btTEST;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbIP2;
        private System.Windows.Forms.Button btPing2;
        private System.Windows.Forms.Button btDel1;
        private System.Windows.Forms.Button btAdd1;


        // Globale Variablen von AE
        public static class MyGlobal
        {
            // Varibale für alle Stream
            public static int Sekunden;
            // Variabeln für einen Stream
            public static string VLC;
            //	public static string Stream1;
            public static string StreamFile;
            public static string StreamPara;
            public static string CapFile;
            public static string StrCapFile;
            public static string CapturePara;
            public static string Pfad = @"g:\Stream VI\SVH\";               // Der Pfad welcher durch die DLG Box open Path geöffnet wird
            public static int[] VLCProNr = new int[9];
            public static int[] VLCCaptureProNr = new int[9];
            public static int CaptureCounter = 1;
            public static string CaptureFile = "stream";    // Die Variable beinhalten die Datei in der die Capture Aufrufe aus den einzelen Streams gespeichert werden. 
            public static string CaptureFileFormat = ".csv";    // Die Variable beinhalten die Dateiformate für die Capture Files. 
            public static string TreeInfo;   // Rückgabe der Checked Tree Nodes
            public static string iPhoneFile = "IPhoneCam";
            public static string iPhoneFileFormat = ".csv";
            public static string iPhoneFileHeader = "IP" + ";" + "Text" + ";" + "TEXT2";

        }



    }
}


