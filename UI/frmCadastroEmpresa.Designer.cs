namespace PadraoDeProjetoEmCamadas
{
    partial class frmCadastroEmpresa
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label_ID = new System.Windows.Forms.Label();
            this.label_NomeEmpresa = new System.Windows.Forms.Label();
            this.label_DescricaoEmpresa = new System.Windows.Forms.Label();
            this.label_CNPJ = new System.Windows.Forms.Label();
            this.textBox_IDEmpresa = new System.Windows.Forms.TextBox();
            this.textBox_NomeEmpresa = new System.Windows.Forms.TextBox();
            this.textBox_DescricaoEmpresa = new System.Windows.Forms.TextBox();
            this.textBox_CNPJ = new System.Windows.Forms.TextBox();
            this.painel_campos.SuspendLayout();
            this.Painel_botoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // painel_campos
            // 
            this.painel_campos.Controls.Add(this.textBox_CNPJ);
            this.painel_campos.Controls.Add(this.textBox_DescricaoEmpresa);
            this.painel_campos.Controls.Add(this.textBox_NomeEmpresa);
            this.painel_campos.Controls.Add(this.textBox_IDEmpresa);
            this.painel_campos.Controls.Add(this.label_CNPJ);
            this.painel_campos.Controls.Add(this.label_DescricaoEmpresa);
            this.painel_campos.Controls.Add(this.label_NomeEmpresa);
            this.painel_campos.Controls.Add(this.label_ID);
            this.painel_campos.Location = new System.Drawing.Point(13, 15);
            this.painel_campos.Size = new System.Drawing.Size(796, 227);
            // 
            // Painel_botoes
            // 
            this.Painel_botoes.Location = new System.Drawing.Point(121, 262);
            this.Painel_botoes.Size = new System.Drawing.Size(597, 66);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_deletar
            // 
            this.btn_deletar.Click += new System.EventHandler(this.btn_deletar_Click);
            // 
            // btn_alterar
            // 
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // btn_inserir
            // 
            this.btn_inserir.Click += new System.EventHandler(this.btn_inserir_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Location = new System.Drawing.Point(62, 34);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(21, 17);
            this.label_ID.TabIndex = 0;
            this.label_ID.Text = "ID";
            // 
            // label_NomeEmpresa
            // 
            this.label_NomeEmpresa.AutoSize = true;
            this.label_NomeEmpresa.Location = new System.Drawing.Point(38, 79);
            this.label_NomeEmpresa.Name = "label_NomeEmpresa";
            this.label_NomeEmpresa.Size = new System.Drawing.Size(45, 17);
            this.label_NomeEmpresa.TabIndex = 1;
            this.label_NomeEmpresa.Text = "Nome";
            // 
            // label_DescricaoEmpresa
            // 
            this.label_DescricaoEmpresa.AutoSize = true;
            this.label_DescricaoEmpresa.Location = new System.Drawing.Point(12, 124);
            this.label_DescricaoEmpresa.Name = "label_DescricaoEmpresa";
            this.label_DescricaoEmpresa.Size = new System.Drawing.Size(71, 17);
            this.label_DescricaoEmpresa.TabIndex = 2;
            this.label_DescricaoEmpresa.Text = "Descrição";
            // 
            // label_CNPJ
            // 
            this.label_CNPJ.AutoSize = true;
            this.label_CNPJ.Location = new System.Drawing.Point(38, 169);
            this.label_CNPJ.Name = "label_CNPJ";
            this.label_CNPJ.Size = new System.Drawing.Size(43, 17);
            this.label_CNPJ.TabIndex = 3;
            this.label_CNPJ.Text = "CNPJ";
            // 
            // textBox_IDEmpresa
            // 
            this.textBox_IDEmpresa.Location = new System.Drawing.Point(89, 31);
            this.textBox_IDEmpresa.Name = "textBox_IDEmpresa";
            this.textBox_IDEmpresa.Size = new System.Drawing.Size(185, 22);
            this.textBox_IDEmpresa.TabIndex = 4;
            // 
            // textBox_NomeEmpresa
            // 
            this.textBox_NomeEmpresa.Location = new System.Drawing.Point(89, 76);
            this.textBox_NomeEmpresa.Name = "textBox_NomeEmpresa";
            this.textBox_NomeEmpresa.Size = new System.Drawing.Size(246, 22);
            this.textBox_NomeEmpresa.TabIndex = 5;
            // 
            // textBox_DescricaoEmpresa
            // 
            this.textBox_DescricaoEmpresa.Location = new System.Drawing.Point(89, 121);
            this.textBox_DescricaoEmpresa.Name = "textBox_DescricaoEmpresa";
            this.textBox_DescricaoEmpresa.Size = new System.Drawing.Size(246, 22);
            this.textBox_DescricaoEmpresa.TabIndex = 6;
            // 
            // textBox_CNPJ
            // 
            this.textBox_CNPJ.Location = new System.Drawing.Point(89, 166);
            this.textBox_CNPJ.Name = "textBox_CNPJ";
            this.textBox_CNPJ.Size = new System.Drawing.Size(185, 22);
            this.textBox_CNPJ.TabIndex = 7;
            // 
            // frmCadastroEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(822, 341);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmCadastroEmpresa";
            this.Controls.SetChildIndex(this.painel_campos, 0);
            this.Controls.SetChildIndex(this.Painel_botoes, 0);
            this.painel_campos.ResumeLayout(false);
            this.painel_campos.PerformLayout();
            this.Painel_botoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label_CNPJ;
        private System.Windows.Forms.Label label_DescricaoEmpresa;
        private System.Windows.Forms.Label label_NomeEmpresa;
        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.TextBox textBox_CNPJ;
        private System.Windows.Forms.TextBox textBox_DescricaoEmpresa;
        private System.Windows.Forms.TextBox textBox_NomeEmpresa;
        private System.Windows.Forms.TextBox textBox_IDEmpresa;
    }
}
