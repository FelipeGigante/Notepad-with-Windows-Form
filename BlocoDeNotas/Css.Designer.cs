namespace BlocoDeNotas
{
    partial class Css
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.notasDataSet = new BlocoDeNotas.NotasDataSet();
            this.cssBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cssTableAdapter = new BlocoDeNotas.NotasDataSetTableAdapters.CssTableAdapter();
            this.textoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cssBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(559, 374);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(214, 51);
            this.button1.TabIndex = 1;
            this.button1.Text = "Adicionar Nova Nota";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(34, 374);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 51);
            this.button2.TabIndex = 4;
            this.button2.Text = "Voltar ao Início";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 26);
            this.label1.TabIndex = 7;
            this.label1.Text = "Notas:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.textoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cssBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(27, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(722, 268);
            this.dataGridView1.TabIndex = 8;
            // 
            // notasDataSet
            // 
            this.notasDataSet.DataSetName = "NotasDataSet";
            this.notasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cssBindingSource
            // 
            this.cssBindingSource.DataMember = "Css";
            this.cssBindingSource.DataSource = this.notasDataSet;
            // 
            // cssTableAdapter
            // 
            this.cssTableAdapter.ClearBeforeFill = true;
            // 
            // textoDataGridViewTextBoxColumn
            // 
            this.textoDataGridViewTextBoxColumn.DataPropertyName = "texto";
            this.textoDataGridViewTextBoxColumn.HeaderText = "Notas Salvas";
            this.textoDataGridViewTextBoxColumn.Name = "textoDataGridViewTextBoxColumn";
            this.textoDataGridViewTextBoxColumn.Width = 740;
            // 
            // Css
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Css";
            this.Text = "Css";
            this.Load += new System.EventHandler(this.Css_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cssBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private NotasDataSet notasDataSet;
        private System.Windows.Forms.BindingSource cssBindingSource;
        private NotasDataSetTableAdapters.CssTableAdapter cssTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn textoDataGridViewTextBoxColumn;
    }
}