namespace WindowsFormsApp1
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.работыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._453ZainullinDataSet = new WindowsFormsApp1._453ZainullinDataSet();
            this.работыTableAdapter = new WindowsFormsApp1._453ZainullinDataSetTableAdapters.РаботыTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеработыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.оплатаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаначалаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаокончанияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.работыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._453ZainullinDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(40, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 84);
            this.button1.TabIndex = 1;
            this.button1.Text = "Работы болеее определённой суммы";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(25, 226);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 62);
            this.button2.TabIndex = 2;
            this.button2.Text = "Заработная плата рабочих";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(25, 337);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(157, 87);
            this.button3.TabIndex = 3;
            this.button3.Text = "Неоконченные работы";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(40, 143);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(157, 29);
            this.textBox1.TabIndex = 4;
            // 
            // работыBindingSource
            // 
            this.работыBindingSource.DataMember = "Работы";
            this.работыBindingSource.DataSource = this._453ZainullinDataSet;
            // 
            // _453ZainullinDataSet
            // 
            this._453ZainullinDataSet.DataSetName = "_453ZainullinDataSet";
            this._453ZainullinDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // работыTableAdapter
            // 
            this.работыTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.названиеработыDataGridViewTextBoxColumn,
            this.оплатаDataGridViewTextBoxColumn,
            this.датаначалаDataGridViewTextBoxColumn,
            this.датаокончанияDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.работыBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(226, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(686, 150);
            this.dataGridView1.TabIndex = 7;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // названиеработыDataGridViewTextBoxColumn
            // 
            this.названиеработыDataGridViewTextBoxColumn.DataPropertyName = "Название_работы";
            this.названиеработыDataGridViewTextBoxColumn.HeaderText = "Название_работы";
            this.названиеработыDataGridViewTextBoxColumn.Name = "названиеработыDataGridViewTextBoxColumn";
            // 
            // оплатаDataGridViewTextBoxColumn
            // 
            this.оплатаDataGridViewTextBoxColumn.DataPropertyName = "Оплата";
            this.оплатаDataGridViewTextBoxColumn.HeaderText = "Оплата";
            this.оплатаDataGridViewTextBoxColumn.Name = "оплатаDataGridViewTextBoxColumn";
            // 
            // датаначалаDataGridViewTextBoxColumn
            // 
            this.датаначалаDataGridViewTextBoxColumn.DataPropertyName = "Дата_начала";
            this.датаначалаDataGridViewTextBoxColumn.HeaderText = "Дата_начала";
            this.датаначалаDataGridViewTextBoxColumn.Name = "датаначалаDataGridViewTextBoxColumn";
            // 
            // датаокончанияDataGridViewTextBoxColumn
            // 
            this.датаокончанияDataGridViewTextBoxColumn.DataPropertyName = "Дата_окончания";
            this.датаокончанияDataGridViewTextBoxColumn.HeaderText = "Дата_окончания";
            this.датаокончанияDataGridViewTextBoxColumn.Name = "датаокончанияDataGridViewTextBoxColumn";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(256, 212);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(362, 95);
            this.listBox1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.работыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._453ZainullinDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private _453ZainullinDataSet _453ZainullinDataSet;
        private System.Windows.Forms.BindingSource работыBindingSource;
        private _453ZainullinDataSetTableAdapters.РаботыTableAdapter работыTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеработыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn оплатаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаначалаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаокончанияDataGridViewTextBoxColumn;
        private System.Windows.Forms.ListBox listBox1;
    }
}

