namespace WindowsFormsApplication8
{
    partial class Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вывестиВсеПереговорыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вывестиЗвонкиЗаОпределенныйПериодПоНомеруToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вывестиВсеЗвонкиСНомераToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.телефонныеПереговорыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database11DataSet = new WindowsFormsApplication8.Database11DataSet();
            this.телефонные_переговорыTableAdapter = new WindowsFormsApplication8.Database11DataSetTableAdapters.Телефонные_переговорыTableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.телефонныеПереговорыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database11DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.вывестиВсеПереговорыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(953, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(142, 26);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click_1);
            // 
            // вывестиВсеПереговорыToolStripMenuItem
            // 
            this.вывестиВсеПереговорыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вывестиЗвонкиЗаОпределенныйПериодПоНомеруToolStripMenuItem,
            this.вывестиВсеЗвонкиСНомераToolStripMenuItem});
            this.вывестиВсеПереговорыToolStripMenuItem.Name = "вывестиВсеПереговорыToolStripMenuItem";
            this.вывестиВсеПереговорыToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.вывестиВсеПереговорыToolStripMenuItem.Text = "Запросы";
            // 
            // вывестиЗвонкиЗаОпределенныйПериодПоНомеруToolStripMenuItem
            // 
            this.вывестиЗвонкиЗаОпределенныйПериодПоНомеруToolStripMenuItem.Name = "вывестиЗвонкиЗаОпределенныйПериодПоНомеруToolStripMenuItem";
            this.вывестиЗвонкиЗаОпределенныйПериодПоНомеруToolStripMenuItem.Size = new System.Drawing.Size(458, 26);
            this.вывестиЗвонкиЗаОпределенныйПериодПоНомеруToolStripMenuItem.Text = "Вывести звонки за определенный период по номеру";
            this.вывестиЗвонкиЗаОпределенныйПериодПоНомеруToolStripMenuItem.Click += new System.EventHandler(this.вывестиЗвонкиЗаОпределенныйПериодПоНомеруToolStripMenuItem_Click);
            // 
            // вывестиВсеЗвонкиСНомераToolStripMenuItem
            // 
            this.вывестиВсеЗвонкиСНомераToolStripMenuItem.Name = "вывестиВсеЗвонкиСНомераToolStripMenuItem";
            this.вывестиВсеЗвонкиСНомераToolStripMenuItem.Size = new System.Drawing.Size(458, 26);
            this.вывестиВсеЗвонкиСНомераToolStripMenuItem.Text = "Вывести все звонки с номера";
            this.вывестиВсеЗвонкиСНомераToolStripMenuItem.Click += new System.EventHandler(this.вывестиВсеЗвонкиСНомераToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.dataGridView1.DataSource = this.телефонныеПереговорыBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(949, 347);
            this.dataGridView1.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Код переговоров";
            this.dataGridViewTextBoxColumn7.HeaderText = "Код переговоров";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Дата переговоров";
            this.dataGridViewTextBoxColumn8.HeaderText = "Дата переговоров";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Продолжительность";
            this.dataGridViewTextBoxColumn9.HeaderText = "Продолжительность";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 150;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Тип вызова";
            this.dataGridViewTextBoxColumn10.HeaderText = "Тип вызова";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Номер звонящего";
            this.dataGridViewTextBoxColumn11.HeaderText = "Номер звонящего";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Номер вызываемого";
            this.dataGridViewTextBoxColumn12.HeaderText = "Номер вызываемого";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // телефонныеПереговорыBindingSource
            // 
            this.телефонныеПереговорыBindingSource.DataMember = "Телефонные переговоры";
            this.телефонныеПереговорыBindingSource.DataSource = this.database11DataSet;
            // 
            // database11DataSet
            // 
            this.database11DataSet.DataSetName = "Database11DataSet";
            this.database11DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // телефонные_переговорыTableAdapter
            // 
            this.телефонные_переговорыTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 390);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.телефонныеПереговорыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database11DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вывестиВсеПереговорыToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодПереговоровDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаПереговоровDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn продолжительностьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn типВызоваDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерЗвонящегоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерВызываемогоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private Database11DataSet database11DataSet;
        private System.Windows.Forms.BindingSource телефонныеПереговорыBindingSource;
        private Database11DataSetTableAdapters.Телефонные_переговорыTableAdapter телефонные_переговорыTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.ToolStripMenuItem вывестиЗвонкиЗаОпределенныйПериодПоНомеруToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вывестиВсеЗвонкиСНомераToolStripMenuItem;
    }
}

