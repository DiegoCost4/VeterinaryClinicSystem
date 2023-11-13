namespace wfaui
{
    partial class frmCadastroEspecies
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
            Código = new Label();
            label2 = new Label();
            tbCodigo = new TextBox();
            tbNome = new TextBox();
            btNovo = new Button();
            btSalvar = new Button();
            btRemover = new Button();
            btPesquisar = new Button();
            SuspendLayout();
            // 
            // Código
            // 
            Código.AutoSize = true;
            Código.Location = new Point(49, 37);
            Código.Name = "Código";
            Código.Size = new Size(46, 15);
            Código.TabIndex = 0;
            Código.Text = "Código";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 93);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 1;
            label2.Text = "Nome";
            // 
            // tbCodigo
            // 
            tbCodigo.Location = new Point(53, 55);
            tbCodigo.Name = "tbCodigo";
            tbCodigo.Size = new Size(59, 23);
            tbCodigo.TabIndex = 2;
            // 
            // tbNome
            // 
            tbNome.Location = new Point(55, 111);
            tbNome.Name = "tbNome";
            tbNome.Size = new Size(128, 23);
            tbNome.TabIndex = 3;
            // 
            // btNovo
            // 
            btNovo.Location = new Point(39, 164);
            btNovo.Name = "btNovo";
            btNovo.Size = new Size(75, 23);
            btNovo.TabIndex = 4;
            btNovo.Text = "Create";
            btNovo.UseVisualStyleBackColor = true;
            btNovo.Click += btNovo_Click;
            // 
            // btSalvar
            // 
            btSalvar.Location = new Point(120, 164);
            btSalvar.Name = "btSalvar";
            btSalvar.Size = new Size(75, 23);
            btSalvar.TabIndex = 5;
            btSalvar.Text = "Update";
            btSalvar.UseVisualStyleBackColor = true;
            btSalvar.Click += btSalvar_Click;
            // 
            // btRemover
            // 
            btRemover.Location = new Point(201, 164);
            btRemover.Name = "btRemover";
            btRemover.Size = new Size(75, 23);
            btRemover.TabIndex = 6;
            btRemover.Text = "Delete";
            btRemover.UseVisualStyleBackColor = true;
            btRemover.Click += btRemover_Click;
            // 
            // btPesquisar
            // 
            btPesquisar.Location = new Point(282, 164);
            btPesquisar.Name = "btPesquisar";
            btPesquisar.Size = new Size(75, 23);
            btPesquisar.TabIndex = 7;
            btPesquisar.Text = "Pesquisar";
            btPesquisar.UseVisualStyleBackColor = true;
            btPesquisar.Click += btPesquisar_Click;
            // 
            // frmCadastroEspecies
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(398, 213);
            Controls.Add(btPesquisar);
            Controls.Add(btRemover);
            Controls.Add(btSalvar);
            Controls.Add(btNovo);
            Controls.Add(tbNome);
            Controls.Add(tbCodigo);
            Controls.Add(label2);
            Controls.Add(Código);
            Name = "frmCadastroEspecies";
            Text = "Cadastrar Especies";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Código;
        private Label label2;
        private TextBox tbCodigo;
        private TextBox tbNome;
        private Button btNovo;
        private Button btSalvar;
        private Button btRemover;
        private Button btPesquisar;
    }
}