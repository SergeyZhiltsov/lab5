namespace lab05
{
    partial class DrawWindow
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.DrawBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DrawBox)).BeginInit();
            this.SuspendLayout();
            // 
            // DrawBox
            // 
            this.DrawBox.BackColor = System.Drawing.SystemColors.Window;
            this.DrawBox.Location = new System.Drawing.Point(13, 27);
            this.DrawBox.Name = "DrawBox";
            this.DrawBox.Size = new System.Drawing.Size(231, 217);
            this.DrawBox.TabIndex = 0;
            this.DrawBox.TabStop = false;
            this.DrawBox.Click += new System.EventHandler(this.DrawBox_Click);
            this.DrawBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DrawBox_MouseDown);
            this.DrawBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DrawBox_MouseMove);
            this.DrawBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DrawBox_MouseUp);
            // 
            // DrawWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(256, 256);
            this.Controls.Add(this.DrawBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DrawWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RectangleCanvas";
            this.Load += new System.EventHandler(this.DrawWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DrawBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ColorDialog colorDialog1;
        public System.Windows.Forms.PictureBox DrawBox;
    }
}