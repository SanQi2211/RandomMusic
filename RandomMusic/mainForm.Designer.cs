
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
            this.uiSymbolButton21 = new Sunny.UI.UISymbolButton();
            this.uiSymbolButton15 = new Sunny.UI.UISymbolButton();
            this.btnStop = new Sunny.UI.UISymbolButton();
            this.btnPlay = new Sunny.UI.UISymbolButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // uiSymbolButton21
            // 
            this.uiSymbolButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton21.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiSymbolButton21.Location = new System.Drawing.Point(191, 329);
            this.uiSymbolButton21.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton21.Name = "uiSymbolButton21";
            this.uiSymbolButton21.RadiusSides = ((Sunny.UI.UICornerRadiusSides)((Sunny.UI.UICornerRadiusSides.RightTop | Sunny.UI.UICornerRadiusSides.RightBottom)));
            this.uiSymbolButton21.RectSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)(((System.Windows.Forms.ToolStripStatusLabelBorderSides.Top | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.uiSymbolButton21.Size = new System.Drawing.Size(46, 35);
            this.uiSymbolButton21.Symbol = 61520;
            this.uiSymbolButton21.TabIndex = 4;
            // 
            // uiSymbolButton15
            // 
            this.uiSymbolButton15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton15.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiSymbolButton15.Location = new System.Drawing.Point(145, 329);
            this.uiSymbolButton15.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton15.Name = "uiSymbolButton15";
            this.uiSymbolButton15.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiSymbolButton15.RectSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)(((System.Windows.Forms.ToolStripStatusLabelBorderSides.Top | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.uiSymbolButton15.Size = new System.Drawing.Size(46, 35);
            this.uiSymbolButton15.Symbol = 61513;
            this.uiSymbolButton15.TabIndex = 3;
            // 
            // btnStop
            // 
            this.btnStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStop.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnStop.Location = new System.Drawing.Point(99, 329);
            this.btnStop.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnStop.Name = "btnStop";
            this.btnStop.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.btnStop.RectSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)(((System.Windows.Forms.ToolStripStatusLabelBorderSides.Top | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.btnStop.Size = new System.Drawing.Size(46, 35);
            this.btnStop.Symbol = 61517;
            this.btnStop.TabIndex = 2;
            // 
            // btnPlay
            // 
            this.btnPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlay.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnPlay.Location = new System.Drawing.Point(53, 329);
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
            this.pictureBox1.Location = new System.Drawing.Point(42, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 400);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.uiSymbolButton21);
            this.Controls.Add(this.uiSymbolButton15);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnPlay);
            this.Name = "mainForm";
            this.Text = "mainForm";
            this.Load += new System.EventHandler(this.mainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UISymbolButton uiSymbolButton21;
        private Sunny.UI.UISymbolButton uiSymbolButton15;
        private Sunny.UI.UISymbolButton btnStop;
        private Sunny.UI.UISymbolButton btnPlay;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}