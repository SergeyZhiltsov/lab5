namespace lab05
{
    partial class MainWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.FileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CanvasMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RectangleMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CircleMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.SizeBar = new System.Windows.Forms.TrackBar();
            this.ButtonColor = new System.Windows.Forms.Button();
            this.ColorPickerDialog = new System.Windows.Forms.ColorDialog();
            this.MainMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SizeBar)).BeginInit();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(483, 24);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "menuStrip1";
            // 
            // FileMenuItem
            // 
            this.FileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateMenuItem});
            this.FileMenuItem.Name = "FileMenuItem";
            this.FileMenuItem.Size = new System.Drawing.Size(48, 20);
            this.FileMenuItem.Text = "Файл";
            // 
            // CreateMenuItem
            // 
            this.CreateMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CanvasMenuItem});
            this.CreateMenuItem.Name = "CreateMenuItem";
            this.CreateMenuItem.Size = new System.Drawing.Size(117, 22);
            this.CreateMenuItem.Text = "Создать";
            // 
            // CanvasMenuItem
            // 
            this.CanvasMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RectangleMenuItem,
            this.CircleMenuItem});
            this.CanvasMenuItem.Name = "CanvasMenuItem";
            this.CanvasMenuItem.Size = new System.Drawing.Size(106, 22);
            this.CanvasMenuItem.Text = "Холст";
            // 
            // RectangleMenuItem
            // 
            this.RectangleMenuItem.Name = "RectangleMenuItem";
            this.RectangleMenuItem.Size = new System.Drawing.Size(166, 22);
            this.RectangleMenuItem.Text = "Прямоугольный";
            this.RectangleMenuItem.Click += new System.EventHandler(this.RectangleMenuItem_Click);
            // 
            // CircleMenuItem
            // 
            this.CircleMenuItem.Name = "CircleMenuItem";
            this.CircleMenuItem.Size = new System.Drawing.Size(166, 22);
            this.CircleMenuItem.Text = "Круглый";
            this.CircleMenuItem.Click += new System.EventHandler(this.CircleMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.SizeBar);
            this.panel1.Controls.Add(this.ButtonColor);
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(82, 258);
            this.panel1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Text";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SizeBar
            // 
            this.SizeBar.Location = new System.Drawing.Point(3, 32);
            this.SizeBar.Name = "SizeBar";
            this.SizeBar.Size = new System.Drawing.Size(76, 45);
            this.SizeBar.TabIndex = 3;
            this.SizeBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.SizeBar.ValueChanged += new System.EventHandler(this.SizeBar_ValueChanged);
            // 
            // ButtonColor
            // 
            this.ButtonColor.Location = new System.Drawing.Point(28, 3);
            this.ButtonColor.Name = "ButtonColor";
            this.ButtonColor.Size = new System.Drawing.Size(28, 23);
            this.ButtonColor.TabIndex = 2;
            this.ButtonColor.UseVisualStyleBackColor = true;
            this.ButtonColor.Click += new System.EventHandler(this.ButtonColor_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 286);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MainMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MainMenu;
            this.Name = "MainWindow";
            this.Text = "Paint";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SizeBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem FileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CreateMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CanvasMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RectangleMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CircleMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ButtonColor;
        private System.Windows.Forms.ColorDialog ColorPickerDialog;
        public System.Windows.Forms.TrackBar SizeBar;
        private System.Windows.Forms.Button button1;
    }
}

