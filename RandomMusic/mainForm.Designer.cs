
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
            this.btnNext = new Sunny.UI.UISymbolButton();
            this.btnPer = new Sunny.UI.UISymbolButton();
            this.btnStop = new Sunny.UI.UISymbolButton();
            this.btnPlay = new Sunny.UI.UISymbolButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblInf = new Sunny.UI.UILabel();
            this.tmrPlay = new System.Windows.Forms.Timer(this.components);
            this.TimeTrack = new CCWin.SkinControl.SkinTrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeTrack)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNext
            // 
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnNext.Location = new System.Drawing.Point(189, 387);
            this.btnNext.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnNext.Name = "btnNext";
            this.btnNext.RadiusSides = ((Sunny.UI.UICornerRadiusSides)((Sunny.UI.UICornerRadiusSides.RightTop | Sunny.UI.UICornerRadiusSides.RightBottom)));
            this.btnNext.RectSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)(((System.Windows.Forms.ToolStripStatusLabelBorderSides.Top | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.btnNext.Size = new System.Drawing.Size(46, 35);
            this.btnNext.Symbol = 61520;
            this.btnNext.TabIndex = 4;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPer
            // 
            this.btnPer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPer.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnPer.Location = new System.Drawing.Point(143, 387);
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
            this.btnStop.Location = new System.Drawing.Point(97, 387);
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
            this.btnPlay.Location = new System.Drawing.Point(51, 387);
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
            this.pictureBox1.Location = new System.Drawing.Point(48, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            // 
            // lblInf
            // 
            this.lblInf.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lblInf.Location = new System.Drawing.Point(48, 279);
            this.lblInf.Name = "lblInf";
            this.lblInf.Size = new System.Drawing.Size(200, 23);
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
            this.TimeTrack.Location = new System.Drawing.Point(48, 353);
            this.TimeTrack.Name = "TimeTrack";
            this.TimeTrack.Size = new System.Drawing.Size(200, 10);
            this.TimeTrack.TabIndex = 51;
            this.TimeTrack.TickStyle = System.Windows.Forms.TickStyle.None;
            this.TimeTrack.Track = global::RandomMusic.Properties.Resources.Track12;
            this.TimeTrack.Scroll += new System.EventHandler(this.TimeTrack_Scroll);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 458);
            this.Controls.Add(this.TimeTrack);
            this.Controls.Add(this.lblInf);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPer);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnPlay);
            this.Name = "mainForm";
            this.Text = "mainForm";
            this.Load += new System.EventHandler(this.mainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeTrack)).EndInit();
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
    }
}