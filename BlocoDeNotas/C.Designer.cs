namespace BlocoDeNotas
{
    partial class C
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
            this.cBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.cBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.notasDataSet = new BlocoDeNotas.NotasDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.cTableAdapter = new BlocoDeNotas.NotasDataSetTableAdapters.CTableAdapter();
            this.textoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.cBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notasDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(558, 370);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(214, 51);
            this.button1.TabIndex = 0;
            this.button1.Text = "Adicionar Nova Nota";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cBindingSource
            // 
            this.cBindingSource.DataMember = "c";
            // 
            // cBindingSource2
            // 
            this.cBindingSource2.DataMember = "c";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(26, 370);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 51);
            this.button2.TabIndex = 3;
            this.button2.Text = "Voltar ao Início";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cBindingSource1
            // 
            this.cBindingSource1.DataMember = "c";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.textoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(26, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(746, 268);
            this.dataGridView1.TabIndex = 4;
            // 
            // cBindingSource3
            // 
            this.cBindingSource3.DataMember = "C";
            this.cBindingSource3.DataSource = this.notasDataSet;
            // 
            // notasDataSet
            // 
            this.notasDataSet.DataSetName = "NotasDataSet";
            this.notasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Notas:";
            // 
            // cTableAdapter
            // 
            this.cTableAdapter.ClearBeforeFill = true;
            // 
            // textoDataGridViewTextBoxColumn
            // 
            this.textoDataGridViewTextBoxColumn.DataPropertyName = "texto";
            this.textoDataGridViewTextBoxColumn.HeaderText = "Notas Salvas";
            this.textoDataGridViewTextBoxColumn.MinimumWidth = 40;
            this.textoDataGridViewTextBoxColumn.Name = "textoDataGridViewTextBoxColumn";
            this.textoDataGridViewTextBoxColumn.Width = 746;
            // 
            // C
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "C";
            this.Text = "C";
            this.Load += new System.EventHandler(this.C_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notasDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource cBindingSource;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource cBindingSource2;
        private System.Windows.Forms.BindingSource cBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private NotasDataSet notasDataSet;
        private System.Windows.Forms.BindingSource cBindingSource3;
        private NotasDataSetTableAdapters.CTableAdapter cTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn textoDataGridViewTextBoxColumn;
    }
}