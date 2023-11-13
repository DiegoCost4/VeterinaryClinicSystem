namespace wfaui
{
    partial class frmCadastroClientes
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbCodigo = new TextBox();
            tbNome = new TextBox();
            tbCpf = new TextBox();
            label4 = new Label();
            tbEmail = new TextBox();
            btNovo = new Button();
            btSalvar = new Button();
            brRemover = new Button();
            btPesquisar = new Button();
            tbData = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 22);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 0;
            label1.Text = "Código";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 75);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 1;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 129);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 2;
            label3.Text = "CPF";
            // 
            // tbCodigo
            // 
            tbCodigo.BackColor = SystemColors.ScrollBar;
            tbCodigo.Enabled = false;
            tbCodigo.Location = new Point(33, 40);
            tbCodigo.Name = "tbCodigo";
            tbCodigo.Size = new Size(100, 23);
            tbCodigo.TabIndex = 3;
            // 
            // tbNome
            // 
            tbNome.Location = new Point(33, 93);
            tbNome.Name = "tbNome";
            tbNome.Size = new Size(100, 23);
            tbNome.TabIndex = 4;
            // 
            // tbCpf
            // 
            tbCpf.Location = new Point(34, 147);
            tbCpf.Name = "tbCpf";
            tbCpf.Size = new Size(119, 23);
            tbCpf.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 189);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 6;
            label4.Text = "E-mail";
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(34, 207);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(246, 23);
            tbEmail.TabIndex = 7;
            // 
            // btNovo
            // 
            btNovo.Location = new Point(34, 254);
            btNovo.Name = "btNovo";
            btNovo.Size = new Size(75, 23);
            btNovo.TabIndex = 8;
            btNovo.Text = "Create";
            btNovo.UseVisualStyleBackColor = true;
            btNovo.Click += btNovo_Click;
            // 
            // btSalvar
            // 
            btSalvar.Location = new Point(115, 254);
            btSalvar.Name = "btSalvar";
            btSalvar.Size = new Size(75, 23);
            btSalvar.TabIndex = 9;
            btSalvar.Text = "Update";
            btSalvar.UseVisualStyleBackColor = true;
            btSalvar.Click += btSalvar_Click;
            // 
            // brRemover
            // 
            brRemover.Location = new Point(196, 254);
            brRemover.Name = "brRemover";
            brRemover.Size = new Size(75, 23);
            brRemover.TabIndex = 10;
            brRemover.Text = "Delete";
            brRemover.UseVisualStyleBackColor = true;
            brRemover.Click += brRemover_Click;
            // 
            // btPesquisar
            // 
            btPesquisar.Location = new Point(277, 254);
            btPesquisar.Name = "btPesquisar";
            btPesquisar.Size = new Size(75, 23);
            btPesquisar.TabIndex = 11;
            btPesquisar.Text = "Pesquisar";
            btPesquisar.UseVisualStyleBackColor = true;
            btPesquisar.Click += btPesquisar_Click;
            // 
            // tbData
            // 
            tbData.Format = DateTimePickerFormat.Short;
            tbData.Location = new Point(164, 40);
            tbData.Margin = new Padding(3, 2, 3, 2);
            tbData.Name = "tbData";
            tbData.Size = new Size(219, 23);
            tbData.TabIndex = 12;
            // 
            // frmCadastroClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(393, 328);
            Controls.Add(tbData);
            Controls.Add(btPesquisar);
            Controls.Add(brRemover);
            Controls.Add(btSalvar);
            Controls.Add(btNovo);
            Controls.Add(tbEmail);
            Controls.Add(label4);
            Controls.Add(tbCpf);
            Controls.Add(tbNome);
            Controls.Add(tbCodigo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmCadastroClientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Clientes";
            Load += frmCadastroClientes_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbCodigo;
        private TextBox tbNome;
        private TextBox tbCpf;
        private Label label4;
        private TextBox tbEmail;
        private Button btNovo;
        private Button btSalvar;
        private Button brRemover;
        private Button btPesquisar;
        private DateTimePicker tbData;
    }
}