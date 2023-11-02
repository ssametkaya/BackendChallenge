namespace BackendChallenge
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
            this.panelList = new System.Windows.Forms.Panel();
            this.trackList = new System.Windows.Forms.ListBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.lblVolume = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBarVolume = new System.Windows.Forms.TrackBar();
            this.panelTop = new System.Windows.Forms.Panel();
            this.groupBoxTool = new System.Windows.Forms.GroupBox();
            this.labelEnd = new System.Windows.Forms.Label();
            this.labelStart = new System.Windows.Forms.Label();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.comboBoxSpeed = new System.Windows.Forms.ComboBox();
            this.wmPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.slider = new System.Windows.Forms.PictureBox();
            this.btnforward = new BackendChallenge.RoundButton();
            this.btnbackward = new BackendChallenge.RoundButton();
            this.btnstartpause = new BackendChallenge.RoundButton();
            this.btnstop = new BackendChallenge.RoundButton();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.panelList.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).BeginInit();
            this.groupBoxTool.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wmPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slider)).BeginInit();
            this.SuspendLayout();
            // 
            // panelList
            // 
            this.panelList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelList.Controls.Add(this.trackList);
            this.panelList.Controls.Add(this.btnOpen);
            this.panelList.Controls.Add(this.panelLogo);
            this.panelList.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelList.Location = new System.Drawing.Point(0, 0);
            this.panelList.Name = "panelList";
            this.panelList.Size = new System.Drawing.Size(220, 730);
            this.panelList.TabIndex = 0;
            // 
            // trackList
            // 
            this.trackList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.trackList.Dock = System.Windows.Forms.DockStyle.Left;
            this.trackList.ForeColor = System.Drawing.Color.Transparent;
            this.trackList.FormattingEnabled = true;
            this.trackList.Location = new System.Drawing.Point(0, 111);
            this.trackList.Name = "trackList";
            this.trackList.Size = new System.Drawing.Size(220, 552);
            this.trackList.TabIndex = 2;
            this.trackList.SelectedIndexChanged += new System.EventHandler(this.trackList_SelectedIndexChanged);
            // 
            // btnOpen
            // 
            this.btnOpen.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnOpen.FlatAppearance.BorderSize = 0;
            this.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpen.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpen.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnOpen.Location = new System.Drawing.Point(0, 663);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(220, 67);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Controls.Add(this.lblVolume);
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Controls.Add(this.trackBarVolume);
            this.panelLogo.Controls.Add(this.btnNext);
            this.panelLogo.Controls.Add(this.btnPrevious);
            this.panelLogo.Controls.Add(this.panelTop);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 111);
            this.panelLogo.TabIndex = 0;
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolume.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblVolume.Location = new System.Drawing.Point(155, 66);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(14, 16);
            this.lblVolume.TabIndex = 8;
            this.lblVolume.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(9, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Volume";
            // 
            // trackBarVolume
            // 
            this.trackBarVolume.Location = new System.Drawing.Point(55, 60);
            this.trackBarVolume.Maximum = 100;
            this.trackBarVolume.Name = "trackBarVolume";
            this.trackBarVolume.Size = new System.Drawing.Size(103, 45);
            this.trackBarVolume.TabIndex = 6;
            this.trackBarVolume.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarVolume.Scroll += new System.EventHandler(this.trackBarVolume_Scroll);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panelTop.Location = new System.Drawing.Point(226, 3);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(632, 77);
            this.panelTop.TabIndex = 1;
            // 
            // groupBoxTool
            // 
            this.groupBoxTool.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(51)))));
            this.groupBoxTool.Controls.Add(this.labelEnd);
            this.groupBoxTool.Controls.Add(this.labelStart);
            this.groupBoxTool.Controls.Add(this.slider);
            this.groupBoxTool.Controls.Add(this.lblSpeed);
            this.groupBoxTool.Controls.Add(this.comboBoxSpeed);
            this.groupBoxTool.Controls.Add(this.btnforward);
            this.groupBoxTool.Controls.Add(this.btnbackward);
            this.groupBoxTool.Controls.Add(this.btnstartpause);
            this.groupBoxTool.Controls.Add(this.btnstop);
            this.groupBoxTool.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBoxTool.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTool.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBoxTool.Location = new System.Drawing.Point(220, 657);
            this.groupBoxTool.Name = "groupBoxTool";
            this.groupBoxTool.Size = new System.Drawing.Size(848, 73);
            this.groupBoxTool.TabIndex = 2;
            this.groupBoxTool.TabStop = false;
            this.groupBoxTool.Text = "Controls";
            // 
            // labelEnd
            // 
            this.labelEnd.AutoSize = true;
            this.labelEnd.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelEnd.Location = new System.Drawing.Point(679, 24);
            this.labelEnd.Name = "labelEnd";
            this.labelEnd.Size = new System.Drawing.Size(49, 21);
            this.labelEnd.TabIndex = 8;
            this.labelEnd.Text = "00:00";
            // 
            // labelStart
            // 
            this.labelStart.AutoSize = true;
            this.labelStart.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelStart.Location = new System.Drawing.Point(143, 24);
            this.labelStart.Name = "labelStart";
            this.labelStart.Size = new System.Drawing.Size(49, 21);
            this.labelStart.TabIndex = 7;
            this.labelStart.Text = "00:00";
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblSpeed.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpeed.Location = new System.Drawing.Point(728, 24);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(42, 14);
            this.lblSpeed.TabIndex = 5;
            this.lblSpeed.Text = "Speed ";
            // 
            // comboBoxSpeed
            // 
            this.comboBoxSpeed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.comboBoxSpeed.Dock = System.Windows.Forms.DockStyle.Right;
            this.comboBoxSpeed.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSpeed.ForeColor = System.Drawing.SystemColors.Control;
            this.comboBoxSpeed.FormattingEnabled = true;
            this.comboBoxSpeed.Items.AddRange(new object[] {
            "0,5",
            "1,0",
            "1,5",
            "2,0",
            "4,0",
            "8,0"});
            this.comboBoxSpeed.Location = new System.Drawing.Point(770, 24);
            this.comboBoxSpeed.Name = "comboBoxSpeed";
            this.comboBoxSpeed.Size = new System.Drawing.Size(75, 22);
            this.comboBoxSpeed.TabIndex = 4;
            this.comboBoxSpeed.SelectedIndexChanged += new System.EventHandler(this.comboBoxSpeed_SelectedIndexChanged);
            // 
            // wmPlayer
            // 
            this.wmPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wmPlayer.Enabled = true;
            this.wmPlayer.Location = new System.Drawing.Point(220, 0);
            this.wmPlayer.Name = "wmPlayer";
            this.wmPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmPlayer.OcxState")));
            this.wmPlayer.Size = new System.Drawing.Size(848, 730);
            this.wmPlayer.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // slider
            // 
            this.slider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(51)))));
            this.slider.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.slider.Location = new System.Drawing.Point(143, 56);
            this.slider.Name = "slider";
            this.slider.Size = new System.Drawing.Size(585, 14);
            this.slider.TabIndex = 6;
            this.slider.TabStop = false;
            this.slider.Paint += new System.Windows.Forms.PaintEventHandler(this.slider_Paint);
            this.slider.MouseDown += new System.Windows.Forms.MouseEventHandler(this.slider_MouseDown);
            this.slider.MouseMove += new System.Windows.Forms.MouseEventHandler(this.slider_MouseMove);
            this.slider.MouseUp += new System.Windows.Forms.MouseEventHandler(this.slider_MouseUp);
            // 
            // btnforward
            // 
            this.btnforward.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.btnforward.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnforward.FlatAppearance.BorderSize = 0;
            this.btnforward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnforward.Image = global::BackendChallenge.Properties.Resources.arrow__2_;
            this.btnforward.Location = new System.Drawing.Point(108, 24);
            this.btnforward.Name = "btnforward";
            this.btnforward.Size = new System.Drawing.Size(35, 46);
            this.btnforward.TabIndex = 3;
            this.btnforward.UseVisualStyleBackColor = false;
            this.btnforward.Click += new System.EventHandler(this.btnforward_Click);
            // 
            // btnbackward
            // 
            this.btnbackward.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.btnbackward.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnbackward.FlatAppearance.BorderSize = 0;
            this.btnbackward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbackward.Image = global::BackendChallenge.Properties.Resources.backward;
            this.btnbackward.Location = new System.Drawing.Point(73, 24);
            this.btnbackward.Name = "btnbackward";
            this.btnbackward.Size = new System.Drawing.Size(35, 46);
            this.btnbackward.TabIndex = 2;
            this.btnbackward.UseVisualStyleBackColor = false;
            this.btnbackward.Click += new System.EventHandler(this.btnbackward_Click);
            // 
            // btnstartpause
            // 
            this.btnstartpause.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.btnstartpause.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnstartpause.FlatAppearance.BorderSize = 0;
            this.btnstartpause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnstartpause.Image = global::BackendChallenge.Properties.Resources.pause;
            this.btnstartpause.Location = new System.Drawing.Point(38, 24);
            this.btnstartpause.Name = "btnstartpause";
            this.btnstartpause.Size = new System.Drawing.Size(35, 46);
            this.btnstartpause.TabIndex = 1;
            this.btnstartpause.UseVisualStyleBackColor = false;
            this.btnstartpause.Click += new System.EventHandler(this.btnstartpause_Click);
            // 
            // btnstop
            // 
            this.btnstop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.btnstop.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnstop.FlatAppearance.BorderSize = 0;
            this.btnstop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnstop.Image = global::BackendChallenge.Properties.Resources.stop;
            this.btnstop.Location = new System.Drawing.Point(3, 24);
            this.btnstop.Name = "btnstop";
            this.btnstop.Size = new System.Drawing.Size(35, 46);
            this.btnstop.TabIndex = 0;
            this.btnstop.UseVisualStyleBackColor = false;
            this.btnstop.Click += new System.EventHandler(this.btnstop_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(51)))));
            this.btnNext.Image = global::BackendChallenge.Properties.Resources.next;
            this.btnNext.Location = new System.Drawing.Point(136, 12);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(72, 42);
            this.btnNext.TabIndex = 3;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(51)))));
            this.btnPrevious.FlatAppearance.BorderSize = 0;
            this.btnPrevious.Image = global::BackendChallenge.Properties.Resources.previous;
            this.btnPrevious.Location = new System.Drawing.Point(12, 12);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(72, 42);
            this.btnPrevious.TabIndex = 2;
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 730);
            this.Controls.Add(this.groupBoxTool);
            this.Controls.Add(this.wmPlayer);
            this.Controls.Add(this.panelList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "MediaPlayer";
            this.panelList.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).EndInit();
            this.groupBoxTool.ResumeLayout(false);
            this.groupBoxTool.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wmPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelList;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelTop;
        private AxWMPLib.AxWindowsMediaPlayer wmPlayer;
        private System.Windows.Forms.ListBox trackList;
        private System.Windows.Forms.GroupBox groupBoxTool;
        private RoundButton btnstop;
        private RoundButton btnforward;
        private RoundButton btnbackward;
        private RoundButton btnstartpause;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.ComboBox comboBoxSpeed;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.TrackBar trackBarVolume;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox slider;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelEnd;
        private System.Windows.Forms.Label labelStart;
    }
}

