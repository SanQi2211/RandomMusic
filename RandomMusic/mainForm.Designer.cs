
namespace RandomMusic
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.btnNext = new Sunny.UI.UISymbolButton();
            this.btnPer = new Sunny.UI.UISymbolButton();
            this.btnStop = new Sunny.UI.UISymbolButton();
            this.btnPlay = new Sunny.UI.UISymbolButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblInf = new Sunny.UI.UILabel();
            this.tmrPlay = new System.Windows.Forms.Timer(this.components);
            this.TimeTrack = new CCWin.SkinControl.SkinTrackBar();
            this.SoundTrack = new CCWin.SkinControl.SkinTrackBar();
            this.sound = new Sunny.UI.UISymbolButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SoundTrack)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNext
            // 
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnNext.Location = new System.Drawing.Point(181, 490);
            this.btnNext.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnNext.Name = "btnNext";
            this.btnNext.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.btnNext.Size = new System.Drawing.Size(46, 35);
            this.btnNext.Symbol = 61520;
            this.btnNext.TabIndex = 4;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPer
            // 
            this.btnPer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPer.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnPer.Location = new System.Drawing.Point(135, 490);
            this.btnPer.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnPer.Name = "btnPer";
            this.btnPer.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.btnPer.RectSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)(((System.Windows.Forms.ToolStripStatusLabelBorderSides.Top | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.btnPer.Size = new System.Drawing.Size(46, 35);
            this.btnPer.Symbol = 61513;
            this.btnPer.TabIndex = 3;
            this.btnPer.Click += new System.EventHandler(this.btnPer_Click);
            // 
            // btnStop
            // 
            this.btnStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStop.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnStop.Location = new System.Drawing.Point(89, 490);
            this.btnStop.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnStop.Name = "btnStop";
            this.btnStop.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.btnStop.RectSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)(((System.Windows.Forms.ToolStripStatusLabelBorderSides.Top | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.btnStop.Size = new System.Drawing.Size(46, 35);
            this.btnStop.Symbol = 61517;
            this.btnStop.TabIndex = 2;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlay.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnPlay.Location = new System.Drawing.Point(43, 490);
            this.btnPlay.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.RadiusSides = ((Sunny.UI.UICornerRadiusSides)((Sunny.UI.UICornerRadiusSides.LeftTop | Sunny.UI.UICornerRadiusSides.LeftBottom)));
            this.btnPlay.Size = new System.Drawing.Size(46, 35);
            this.btnPlay.Symbol = 61515;
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(79, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 250);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            // 
            // lblInf
            // 
            this.lblInf.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lblInf.Location = new System.Drawing.Point(79, 351);
            this.lblInf.Name = "lblInf";
            this.lblInf.Size = new System.Drawing.Size(250, 23);
            this.lblInf.TabIndex = 50;
            this.lblInf.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tmrPlay
            // 
            this.tmrPlay.Tick += new System.EventHandler(this.tmrPlay_Tick);
            // 
            // TimeTrack
            // 
            this.TimeTrack.AutoSize = false;
            this.TimeTrack.BackColor = System.Drawing.Color.Transparent;
            this.TimeTrack.Bar = global::RandomMusic.Properties.Resources.Bar1;
            this.TimeTrack.BarStyle = CCWin.SkinControl.HSLTrackBarStyle.Img;
            this.TimeTrack.BaseColor = System.Drawing.Color.DimGray;
            this.TimeTrack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TimeTrack.Location = new System.Drawing.Point(79, 445);
            this.TimeTrack.Name = "TimeTrack";
            this.TimeTrack.Size = new System.Drawing.Size(250, 10);
            this.TimeTrack.TabIndex = 51;
            this.TimeTrack.TickStyle = System.Windows.Forms.TickStyle.None;
            this.TimeTrack.Track = global::RandomMusic.Properties.Resources.Track12;
            this.TimeTrack.Scroll += new System.EventHandler(this.TimeTrack_Scroll);
            // 
            // SoundTrack
            // 
            this.SoundTrack.AutoSize = false;
            this.SoundTrack.BackColor = System.Drawing.Color.Transparent;
            this.SoundTrack.Bar = global::RandomMusic.Properties.Resources.Bar1;
            this.SoundTrack.BarStyle = CCWin.SkinControl.HSLTrackBarStyle.Img;
            this.SoundTrack.BaseColor = System.Drawing.Color.LightGray;
            this.SoundTrack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SoundTrack.Location = new System.Drawing.Point(288, 503);
            this.SoundTrack.Name = "SoundTrack";
            this.SoundTrack.Size = new System.Drawing.Size(88, 10);
            this.SoundTrack.TabIndex = 53;
            this.SoundTrack.TickStyle = System.Windows.Forms.TickStyle.None;
            this.SoundTrack.Track = global::RandomMusic.Properties.Resources.Track12;
            this.SoundTrack.Value = 50;
            this.SoundTrack.Scroll += new System.EventHandler(this.SoundTrack_Scroll);
            this.SoundTrack.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SoundTrack_MouseDown);
            // 
            // sound
            // 
            this.sound.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sound.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.sound.Location = new System.Drawing.Point(227, 490);
            this.sound.MinimumSize = new System.Drawing.Size(1, 1);
            this.sound.Name = "sound";
            this.sound.RadiusSides = ((Sunny.UI.UICornerRadiusSides)((Sunny.UI.UICornerRadiusSides.RightTop | Sunny.UI.UICornerRadiusSides.RightBottom)));
            this.sound.Size = new System.Drawing.Size(46, 35);
            this.sound.Symbol = 57449;
            this.sound.TabIndex = 54;
            this.sound.Click += new System.EventHandler(this.sound_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 560);
            this.Controls.Add(this.sound);
            this.Controls.Add(this.SoundTrack);
            this.Controls.Add(this.TimeTrack);
            this.Controls.Add(this.lblInf);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPer);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnPlay);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainForm";
            this.Text = "mainForm";
            this.Load += new System.EventHandler(this.mainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SoundTrack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UISymbolButton btnNext;
        private Sunny.UI.UISymbolButton btnPer;
        private Sunny.UI.UISymbolButton btnStop;
        private Sunny.UI.UISymbolButton btnPlay;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Sunny.UI.UILabel lblInf;
        private System.Windows.Forms.Timer tmrPlay;
        private CCWin.SkinControl.SkinTrackBar TimeTrack;
        private CCWin.SkinControl.SkinTrackBar SoundTrack;
        private Sunny.UI.UISymbolButton sound;
    }
}