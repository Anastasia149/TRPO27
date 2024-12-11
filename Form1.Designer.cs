namespace ТРПО27
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.выбратьФонToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фон1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фон2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фон3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обИгреToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FirstCharF = new System.Windows.Forms.PictureBox();
            this.SecondCharF = new System.Windows.Forms.PictureBox();
            this.ThirdCharF = new System.Windows.Forms.PictureBox();
            this.FourthCharF = new System.Windows.Forms.PictureBox();
            this.FourthCharS = new System.Windows.Forms.PictureBox();
            this.ThirdCharS = new System.Windows.Forms.PictureBox();
            this.SecondCharS = new System.Windows.Forms.PictureBox();
            this.FirstCharS = new System.Windows.Forms.PictureBox();
            this.Start = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FirstCharF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondCharF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThirdCharF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FourthCharF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FourthCharS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThirdCharS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondCharS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirstCharS)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выбратьФонToolStripMenuItem,
            this.обИгреToolStripMenuItem,
            this.помощьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(1414, 73);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked_1);
            // 
            // выбратьФонToolStripMenuItem
            // 
            this.выбратьФонToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.фон1ToolStripMenuItem,
            this.фон2ToolStripMenuItem,
            this.фон3ToolStripMenuItem});
            this.выбратьФонToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.выбратьФонToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.выбратьФонToolStripMenuItem.Name = "выбратьФонToolStripMenuItem";
            this.выбратьФонToolStripMenuItem.Size = new System.Drawing.Size(336, 69);
            this.выбратьФонToolStripMenuItem.Text = "Выбрать фон";
            // 
            // фон1ToolStripMenuItem
            // 
            this.фон1ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.фон1ToolStripMenuItem.Image = global::ТРПО27.Properties.Resources.landscape1;
            this.фон1ToolStripMenuItem.Name = "фон1ToolStripMenuItem";
            this.фон1ToolStripMenuItem.Size = new System.Drawing.Size(359, 74);
            this.фон1ToolStripMenuItem.Text = "фон 1";
            this.фон1ToolStripMenuItem.Click += new System.EventHandler(this.фон1ToolStripMenuItem_Click);
            // 
            // фон2ToolStripMenuItem
            // 
            this.фон2ToolStripMenuItem.Image = global::ТРПО27.Properties.Resources.landscape5;
            this.фон2ToolStripMenuItem.Name = "фон2ToolStripMenuItem";
            this.фон2ToolStripMenuItem.Size = new System.Drawing.Size(359, 74);
            this.фон2ToolStripMenuItem.Text = "Фон 2";
            this.фон2ToolStripMenuItem.Click += new System.EventHandler(this.фон2ToolStripMenuItem_Click);
            // 
            // фон3ToolStripMenuItem
            // 
            this.фон3ToolStripMenuItem.Image = global::ТРПО27.Properties.Resources.landscape3;
            this.фон3ToolStripMenuItem.Name = "фон3ToolStripMenuItem";
            this.фон3ToolStripMenuItem.Size = new System.Drawing.Size(359, 74);
            this.фон3ToolStripMenuItem.Text = "Фон 3";
            this.фон3ToolStripMenuItem.Click += new System.EventHandler(this.фон3ToolStripMenuItem_Click);
            // 
            // обИгреToolStripMenuItem
            // 
            this.обИгреToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.обИгреToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.обИгреToolStripMenuItem.Name = "обИгреToolStripMenuItem";
            this.обИгреToolStripMenuItem.Size = new System.Drawing.Size(224, 69);
            this.обИгреToolStripMenuItem.Text = "Об игре";
            this.обИгреToolStripMenuItem.Click += new System.EventHandler(this.обИгреToolStripMenuItem_Click);
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.помощьToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(236, 69);
            this.помощьToolStripMenuItem.Text = "Помощь";
            this.помощьToolStripMenuItem.Click += new System.EventHandler(this.помощьToolStripMenuItem_Click);
            // 
            // FirstCharF
            // 
            this.FirstCharF.Image = global::ТРПО27.Properties.Resources.photo3;
            this.FirstCharF.Location = new System.Drawing.Point(49, 184);
            this.FirstCharF.Name = "FirstCharF";
            this.FirstCharF.Size = new System.Drawing.Size(135, 135);
            this.FirstCharF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FirstCharF.TabIndex = 1;
            this.FirstCharF.TabStop = false;
            this.FirstCharF.Click += new System.EventHandler(this.FirstCharF_Click);
            // 
            // SecondCharF
            // 
            this.SecondCharF.Image = global::ТРПО27.Properties.Resources.Anya;
            this.SecondCharF.Location = new System.Drawing.Point(313, 184);
            this.SecondCharF.Name = "SecondCharF";
            this.SecondCharF.Size = new System.Drawing.Size(135, 133);
            this.SecondCharF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SecondCharF.TabIndex = 2;
            this.SecondCharF.TabStop = false;
            this.SecondCharF.Click += new System.EventHandler(this.SecondCharF_Click);
            // 
            // ThirdCharF
            // 
            this.ThirdCharF.Image = global::ТРПО27.Properties.Resources.Polina;
            this.ThirdCharF.Location = new System.Drawing.Point(49, 384);
            this.ThirdCharF.Name = "ThirdCharF";
            this.ThirdCharF.Size = new System.Drawing.Size(135, 133);
            this.ThirdCharF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ThirdCharF.TabIndex = 3;
            this.ThirdCharF.TabStop = false;
            this.ThirdCharF.Click += new System.EventHandler(this.ThirdCharF_Click);
            // 
            // FourthCharF
            // 
            this.FourthCharF.Image = global::ТРПО27.Properties.Resources.Liza;
            this.FourthCharF.Location = new System.Drawing.Point(313, 384);
            this.FourthCharF.Name = "FourthCharF";
            this.FourthCharF.Size = new System.Drawing.Size(135, 133);
            this.FourthCharF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FourthCharF.TabIndex = 4;
            this.FourthCharF.TabStop = false;
            this.FourthCharF.Click += new System.EventHandler(this.FourthCharF_Click);
            // 
            // FourthCharS
            // 
            this.FourthCharS.Image = global::ТРПО27.Properties.Resources.Liza;
            this.FourthCharS.Location = new System.Drawing.Point(1196, 384);
            this.FourthCharS.Name = "FourthCharS";
            this.FourthCharS.Size = new System.Drawing.Size(135, 133);
            this.FourthCharS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FourthCharS.TabIndex = 8;
            this.FourthCharS.TabStop = false;
            this.FourthCharS.Click += new System.EventHandler(this.FourthCharS_Click);
            // 
            // ThirdCharS
            // 
            this.ThirdCharS.Image = global::ТРПО27.Properties.Resources.Polina;
            this.ThirdCharS.Location = new System.Drawing.Point(932, 384);
            this.ThirdCharS.Name = "ThirdCharS";
            this.ThirdCharS.Size = new System.Drawing.Size(135, 133);
            this.ThirdCharS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ThirdCharS.TabIndex = 7;
            this.ThirdCharS.TabStop = false;
            this.ThirdCharS.Click += new System.EventHandler(this.ThirdCharS_Click);
            // 
            // SecondCharS
            // 
            this.SecondCharS.Image = global::ТРПО27.Properties.Resources.Anya;
            this.SecondCharS.Location = new System.Drawing.Point(1196, 184);
            this.SecondCharS.Name = "SecondCharS";
            this.SecondCharS.Size = new System.Drawing.Size(135, 133);
            this.SecondCharS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SecondCharS.TabIndex = 6;
            this.SecondCharS.TabStop = false;
            this.SecondCharS.Click += new System.EventHandler(this.SecondCharS_Click);
            // 
            // FirstCharS
            // 
            this.FirstCharS.Image = global::ТРПО27.Properties.Resources.photo3;
            this.FirstCharS.Location = new System.Drawing.Point(932, 184);
            this.FirstCharS.Name = "FirstCharS";
            this.FirstCharS.Size = new System.Drawing.Size(135, 133);
            this.FirstCharS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FirstCharS.TabIndex = 5;
            this.FirstCharS.TabStop = false;
            this.FirstCharS.Click += new System.EventHandler(this.FirstCharS_Click);
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.Color.Transparent;
            this.Start.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Start.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Start.Location = new System.Drawing.Point(495, 646);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(441, 113);
            this.Start.TabIndex = 10;
            this.Start.Text = "Играть";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            this.Start.Paint += new System.Windows.Forms.PaintEventHandler(this.Start_Paint);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackgroundImage = global::ТРПО27.Properties.Resources.landscape1;
            this.ClientSize = new System.Drawing.Size(1414, 829);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.FourthCharS);
            this.Controls.Add(this.ThirdCharS);
            this.Controls.Add(this.SecondCharS);
            this.Controls.Add(this.FirstCharS);
            this.Controls.Add(this.FourthCharF);
            this.Controls.Add(this.ThirdCharF);
            this.Controls.Add(this.SecondCharF);
            this.Controls.Add(this.FirstCharF);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Jump";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FirstCharF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondCharF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThirdCharF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FourthCharF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FourthCharS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThirdCharS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondCharS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirstCharS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem выбратьФонToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обИгреToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem фон1ToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem фон2ToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem фон3ToolStripMenuItem;
        public System.Windows.Forms.PictureBox FirstCharF;
        public System.Windows.Forms.PictureBox SecondCharF;
        public System.Windows.Forms.PictureBox ThirdCharF;
        public System.Windows.Forms.PictureBox FourthCharF;
        public System.Windows.Forms.PictureBox FourthCharS;
        public System.Windows.Forms.PictureBox ThirdCharS;
        public System.Windows.Forms.PictureBox SecondCharS;
        public System.Windows.Forms.PictureBox FirstCharS;
        private System.Windows.Forms.Button Start;
    }
}

