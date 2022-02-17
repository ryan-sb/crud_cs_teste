namespace CrudTeste
{
    partial class Form1
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
            this.bt_inserir = new System.Windows.Forms.Button();
            this.bt_atualizar = new System.Windows.Forms.Button();
            this.bt_remover = new System.Windows.Forms.Button();
            this.crudProdutosDataSet = new CrudTeste.CrudProdutosDataSet();
            this.produtosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produtosTableAdapter = new CrudTeste.CrudProdutosDataSetTableAdapters.ProdutosTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeprodutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preco_produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.crudProdutosDataSet1 = new CrudTeste.CrudProdutosDataSet1();
            this.produtosTableAdapter1 = new CrudTeste.CrudProdutosDataSet1TableAdapters.ProdutosTableAdapter();
            this.nome_prod = new System.Windows.Forms.TextBox();
            this.preco_prod = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.id_prod = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.crudProdutosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crudProdutosDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_inserir
            // 
            this.bt_inserir.BackColor = System.Drawing.SystemColors.HotTrack;
            this.bt_inserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_inserir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_inserir.Location = new System.Drawing.Point(170, 185);
            this.bt_inserir.Name = "bt_inserir";
            this.bt_inserir.Size = new System.Drawing.Size(106, 38);
            this.bt_inserir.TabIndex = 1;
            this.bt_inserir.Text = "Inserir";
            this.bt_inserir.UseVisualStyleBackColor = false;
            this.bt_inserir.Click += new System.EventHandler(this.bt_inserir_Click);
            // 
            // bt_atualizar
            // 
            this.bt_atualizar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.bt_atualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_atualizar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_atualizar.Location = new System.Drawing.Point(282, 185);
            this.bt_atualizar.Name = "bt_atualizar";
            this.bt_atualizar.Size = new System.Drawing.Size(106, 38);
            this.bt_atualizar.TabIndex = 2;
            this.bt_atualizar.Text = "Atualizar";
            this.bt_atualizar.UseVisualStyleBackColor = false;
            this.bt_atualizar.Click += new System.EventHandler(this.bt_atualizar_Click);
            // 
            // bt_remover
            // 
            this.bt_remover.BackColor = System.Drawing.SystemColors.HotTrack;
            this.bt_remover.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_remover.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_remover.Location = new System.Drawing.Point(394, 185);
            this.bt_remover.Name = "bt_remover";
            this.bt_remover.Size = new System.Drawing.Size(106, 38);
            this.bt_remover.TabIndex = 3;
            this.bt_remover.Text = "Remover";
            this.bt_remover.UseVisualStyleBackColor = false;
            this.bt_remover.Click += new System.EventHandler(this.bt_remover_Click);
            // 
            // crudProdutosDataSet
            // 
            this.crudProdutosDataSet.DataSetName = "CrudProdutosDataSet";
            this.crudProdutosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produtosBindingSource
            // 
            this.produtosBindingSource.DataMember = "Produtos";
            this.produtosBindingSource.DataSource = this.crudProdutosDataSet;
            // 
            // produtosTableAdapter
            // 
            this.produtosTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(48, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nome Produto";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nomeprodutoDataGridViewTextBoxColumn,
            this.preco_produto});
            this.dataGridView1.DataSource = this.produtosBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(170, 252);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(330, 172);
            this.dataGridView1.TabIndex = 7;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 60;
            // 
            // nomeprodutoDataGridViewTextBoxColumn
            // 
            this.nomeprodutoDataGridViewTextBoxColumn.DataPropertyName = "nome_produto";
            this.nomeprodutoDataGridViewTextBoxColumn.HeaderText = "nome_produto";
            this.nomeprodutoDataGridViewTextBoxColumn.Name = "nomeprodutoDataGridViewTextBoxColumn";
            this.nomeprodutoDataGridViewTextBoxColumn.Width = 120;
            // 
            // preco_produto
            // 
            this.preco_produto.DataPropertyName = "preco_produto";
            this.preco_produto.HeaderText = "preco_produto";
            this.preco_produto.Name = "preco_produto";
            this.preco_produto.Width = 105;
            // 
            // produtosBindingSource1
            // 
            this.produtosBindingSource1.DataMember = "Produtos";
            this.produtosBindingSource1.DataSource = this.crudProdutosDataSet1;
            // 
            // crudProdutosDataSet1
            // 
            this.crudProdutosDataSet1.DataSetName = "CrudProdutosDataSet1";
            this.crudProdutosDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produtosTableAdapter1
            // 
            this.produtosTableAdapter1.ClearBeforeFill = true;
            // 
            // nome_prod
            // 
            this.nome_prod.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nome_prod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nome_prod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nome_prod.Location = new System.Drawing.Point(170, 82);
            this.nome_prod.Multiline = true;
            this.nome_prod.Name = "nome_prod";
            this.nome_prod.Size = new System.Drawing.Size(330, 35);
            this.nome_prod.TabIndex = 8;
            // 
            // preco_prod
            // 
            this.preco_prod.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.preco_prod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.preco_prod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preco_prod.Location = new System.Drawing.Point(170, 123);
            this.preco_prod.Multiline = true;
            this.preco_prod.Name = "preco_prod";
            this.preco_prod.Size = new System.Drawing.Size(330, 35);
            this.preco_prod.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(48, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Preço Produto";
            // 
            // id_prod
            // 
            this.id_prod.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.id_prod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.id_prod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_prod.Location = new System.Drawing.Point(170, 43);
            this.id_prod.Multiline = true;
            this.id_prod.Name = "id_prod";
            this.id_prod.Size = new System.Drawing.Size(330, 35);
            this.id_prod.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(75, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "ID Produto";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(652, 467);
            this.Controls.Add(this.id_prod);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.preco_prod);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nome_prod);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_remover);
            this.Controls.Add(this.bt_atualizar);
            this.Controls.Add(this.bt_inserir);
            this.Name = "Form1";
            this.Text = "CrudProdutos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.crudProdutosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crudProdutosDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_inserir;
        private System.Windows.Forms.Button bt_atualizar;
        private System.Windows.Forms.Button bt_remover;
        private CrudProdutosDataSet crudProdutosDataSet;
        private System.Windows.Forms.BindingSource produtosBindingSource;
        private CrudProdutosDataSetTableAdapters.ProdutosTableAdapter produtosTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private CrudProdutosDataSet1 crudProdutosDataSet1;
        private System.Windows.Forms.BindingSource produtosBindingSource1;
        private CrudProdutosDataSet1TableAdapters.ProdutosTableAdapter produtosTableAdapter1;
        private System.Windows.Forms.TextBox nome_prod;
        private System.Windows.Forms.TextBox preco_prod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox id_prod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeprodutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn preco_produto;
    }
}

