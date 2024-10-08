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
            this.обИгреToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фон3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(1803, 73);
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
            this.фон1ToolStripMenuItem.Image = global::ТРПО27.Properties.Resources.landscape12;
            this.фон1ToolStripMenuItem.Name = "фон1ToolStripMenuItem";
            this.фон1ToolStripMenuItem.Size = new System.Drawing.Size(359, 74);
            this.фон1ToolStripMenuItem.Text = "фон 1";
            this.фон1ToolStripMenuItem.Click += new System.EventHandler(this.фон1ToolStripMenuItem_Click);
            // 
            // фон2ToolStripMenuItem
            // 
            this.фон2ToolStripMenuItem.Image = global::ТРПО27.Properties.Resources.landscape13;
            this.фон2ToolStripMenuItem.Name = "фон2ToolStripMenuItem";
            this.фон2ToolStripMenuItem.Size = new System.Drawing.Size(359, 74);
            this.фон2ToolStripMenuItem.Text = "Фон 2";
            // 
            // обИгреToolStripMenuItem
            // 
            this.обИгреToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.обИгреToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.обИгреToolStripMenuItem.Name = "обИгреToolStripMenuItem";
            this.обИгреToolStripMenuItem.Size = new System.Drawing.Size(224, 69);
            this.обИгреToolStripMenuItem.Text = "Об игре";
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.помощьToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(236, 69);
            this.помощьToolStripMenuItem.Text = "Помощь";
            // 
            // фон3ToolStripMenuItem
            // 
            this.фон3ToolStripMenuItem.Image = global::ТРПО27.Properties.Resources.landscape11;
            this.фон3ToolStripMenuItem.Name = "фон3ToolStripMenuItem";
            this.фон3ToolStripMenuItem.Size = new System.Drawing.Size(359, 74);
            this.фон3ToolStripMenuItem.Text = "Фон 3";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackgroundImage = global::ТРПО27.Properties.Resources.landscape11;
            this.ClientSize = new System.Drawing.Size(1803, 1060);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jump";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem выбратьФонToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обИгреToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фон1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фон2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фон3ToolStripMenuItem;
    }
}

