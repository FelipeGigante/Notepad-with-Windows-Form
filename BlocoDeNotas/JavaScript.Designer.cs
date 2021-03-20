namespace BlocoDeNotas
{
    partial class JavaScript
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.javaScriptBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.notasDataSet = new BlocoDeNotas.NotasDataSet();
            this.notasDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.javaScriptTableAdapter = new BlocoDeNotas.NotasDataSetTableAdapters.JavaScriptTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.javaScriptBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.textoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.javaScriptBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notasDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.javaScriptBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(557, 374);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(214, 51);
            this.button1.TabIndex = 2;
            this.button1.Text = "Adicionar Nova Nota";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(32, 374);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 51);
            this.button2.TabIndex = 5;
            this.button2.Text = "Voltar ao Início";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 26);
            this.label1.TabIndex = 8;
            this.label1.Text = "Notas:";
            // 
            // javaScriptBindingSource
            // 
            this.javaScriptBindingSource.DataMember = "JavaScript";
            this.javaScriptBindingSource.DataSource = this.notasDataSet;
            // 
            // notasDataSet
            // 
            this.notasDataSet.DataSetName = "NotasDataSet";
            this.notasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // notasDataSetBindingSource
            // 
            this.notasDataSetBindingSource.DataSource = this.notasDataSet;
            this.notasDataSetBindingSource.Position = 0;
            // 
            // javaScriptTableAdapter
            // 
            this.javaScriptTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.textoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.javaScriptBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(32, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(712, 268);
            this.dataGridView1.TabIndex = 9;
            // 
            // javaScriptBindingSource1
            // 
            this.javaScriptBindingSource1.DataMember = "JavaScript";
            this.javaScriptBindingSource1.DataSource = this.notasDataSet;
            // 
            // textoDataGridViewTextBoxColumn
            // 
            this.textoDataGridViewTextBoxColumn.DataPropertyName = "texto";
            this.textoDataGridViewTextBoxColumn.HeaderText = "Notas Salvas";
            this.textoDataGridViewTextBoxColumn.Name = "textoDataGridViewTextBoxColumn";
            this.textoDataGridViewTextBoxColumn.Width = 740;
            // 
            // JavaScript
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "JavaScript";
            this.Text = "JavaScript";
            this.Load += new System.EventHandler(this.JavaScript_Load);
            ((System.ComponentModel.ISupportInitialize)(this.javaScriptBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notasDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.javaScriptBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource notasDataSetBindingSource;
        private NotasDataSet notasDataSet;
        private System.Windows.Forms.BindingSource javaScriptBindingSource;
        private NotasDataSetTableAdapters.JavaScriptTableAdapter javaScriptTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn textoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource javaScriptBindingSource1;
    }
}