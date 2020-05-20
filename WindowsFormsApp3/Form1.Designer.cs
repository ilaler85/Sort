namespace WindowsFormsApp3
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
            this.components = new System.ComponentModel.Container();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Sort = new System.Windows.Forms.ToolStripMenuItem();
            this.BiSort = new System.Windows.Forms.ToolStripMenuItem();
            this.ProstSort = new System.Windows.Forms.ToolStripMenuItem();
            this.Zapoln = new System.Windows.Forms.ToolStripMenuItem();
            this.Randoom = new System.Windows.Forms.ToolStripMenuItem();
            this.ColvoMass = new System.Windows.Forms.ToolStripMenuItem();
            this.massiv = new System.Windows.Forms.DataGridView();
            this.vvod = new System.Windows.Forms.TextBox();
            this.labVvod = new System.Windows.Forms.Label();
            this.butVvod = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.massiv)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Sort,
            this.Zapoln});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Sort
            // 
            this.Sort.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BiSort,
            this.ProstSort});
            this.Sort.Name = "Sort";
            this.Sort.Size = new System.Drawing.Size(104, 24);
            this.Sort.Text = "Сортировка";
            // 
            // BiSort
            // 
            this.BiSort.Name = "BiSort";
            this.BiSort.Size = new System.Drawing.Size(238, 26);
            this.BiSort.Text = "Бинарная сортировка";
            // 
            // ProstSort
            // 
            this.ProstSort.Name = "ProstSort";
            this.ProstSort.Size = new System.Drawing.Size(238, 26);
            this.ProstSort.Text = "Простыми вставками";
            // 
            // Zapoln
            // 
            this.Zapoln.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Randoom,
            this.ColvoMass});
            this.Zapoln.Name = "Zapoln";
            this.Zapoln.Size = new System.Drawing.Size(106, 24);
            this.Zapoln.Text = "Заполнение";
            // 
            // Randoom
            // 
            this.Randoom.Name = "Randoom";
            this.Randoom.Size = new System.Drawing.Size(332, 26);
            this.Randoom.Text = "Заполнить случайными числами";
            this.Randoom.Click += new System.EventHandler(this.заполнитьСлучайнымиЧисламиToolStripMenuItem_Click);
            // 
            // ColvoMass
            // 
            this.ColvoMass.Name = "ColvoMass";
            this.ColvoMass.Size = new System.Drawing.Size(332, 26);
            this.ColvoMass.Text = "Ввести количество чисел в массиве";
            this.ColvoMass.Click += new System.EventHandler(this.ColvoMass_Click);
            // 
            // massiv
            // 
            this.massiv.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.massiv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.massiv.Location = new System.Drawing.Point(12, 31);
            this.massiv.Name = "massiv";
            this.massiv.RowHeadersWidth = 55;
            this.massiv.RowTemplate.Height = 24;
            this.massiv.Size = new System.Drawing.Size(776, 106);
            this.massiv.TabIndex = 1;
            this.massiv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // vvod
            // 
            this.vvod.Location = new System.Drawing.Point(345, 163);
            this.vvod.Name = "vvod";
            this.vvod.Size = new System.Drawing.Size(100, 22);
            this.vvod.TabIndex = 2;
            this.vvod.Text = "2";
            this.vvod.Visible = false;
            // 
            // labVvod
            // 
            this.labVvod.AutoSize = true;
            this.labVvod.Location = new System.Drawing.Point(181, 166);
            this.labVvod.Name = "labVvod";
            this.labVvod.Size = new System.Drawing.Size(158, 17);
            this.labVvod.TabIndex = 3;
            this.labVvod.Text = "Ввод размара массива";
            this.labVvod.Visible = false;
            this.labVvod.Click += new System.EventHandler(this.label1_Click);
            // 
            // butVvod
            // 
            this.butVvod.Location = new System.Drawing.Point(451, 155);
            this.butVvod.Name = "butVvod";
            this.butVvod.Size = new System.Drawing.Size(42, 38);
            this.butVvod.TabIndex = 4;
            this.butVvod.Text = "—>";
            this.butVvod.UseVisualStyleBackColor = true;
            this.butVvod.Click += new System.EventHandler(this.butVvod_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 216);
            this.Controls.Add(this.butVvod);
            this.Controls.Add(this.labVvod);
            this.Controls.Add(this.vvod);
            this.Controls.Add(this.massiv);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.massiv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Sort;
        private System.Windows.Forms.ToolStripMenuItem BiSort;
        private System.Windows.Forms.ToolStripMenuItem ProstSort;
        private System.Windows.Forms.ToolStripMenuItem Zapoln;
        private System.Windows.Forms.ToolStripMenuItem Randoom;
        private System.Windows.Forms.DataGridView massiv;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ColvoMass;
        private System.Windows.Forms.TextBox vvod;
        private System.Windows.Forms.Label labVvod;
        private System.Windows.Forms.Button butVvod;
    }
}

