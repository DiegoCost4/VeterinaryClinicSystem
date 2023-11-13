namespace wfaui
{
    partial class frmCadastroClientesPesquisar
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
            components = new System.ComponentModel.Container();
            dgClientes = new DataGridView();
            Codigo = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            Cpf = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            DataCad = new DataGridViewTextBoxColumn();
            clientesDalBindingSource1 = new BindingSource(components);
            clientesDalBindingSource = new BindingSource(components);
            btSelecionar = new Button();
            btVoltar = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgClientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clientesDalBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clientesDalBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dgClientes
            // 
            dgClientes.AllowUserToAddRows = false;
            dgClientes.AllowUserToDeleteRows = false;
            dgClientes.AutoGenerateColumns = false;
            dgClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgClientes.Columns.AddRange(new DataGridViewColumn[] { Codigo, Nome, Cpf, Email, DataCad });
            dgClientes.DataSource = clientesDalBindingSource1;
            dgClientes.Location = new Point(12, 24);
            dgClientes.Name = "dgClientes";
            dgClientes.ReadOnly = true;
            dgClientes.RowHeadersWidth = 51;
            dgClientes.RowTemplate.Height = 25;
            dgClientes.Size = new Size(522, 195);
            dgClientes.TabIndex = 0;
            dgClientes.CellContentClick += dgClientes_CellContentClick;
            // 
            // Codigo
            // 
            Codigo.DataPropertyName = "Codigo";
            Codigo.HeaderText = "Código";
            Codigo.MinimumWidth = 6;
            Codigo.Name = "Codigo";
            Codigo.ReadOnly = true;
            Codigo.Width = 60;
            // 
            // Nome
            // 
            Nome.DataPropertyName = "Nome";
            Nome.HeaderText = "Nome";
            Nome.MinimumWidth = 6;
            Nome.Name = "Nome";
            Nome.ReadOnly = true;
            Nome.Width = 120;
            // 
            // Cpf
            // 
            Cpf.DataPropertyName = "Cpf";
            Cpf.HeaderText = "CPF";
            Cpf.MinimumWidth = 6;
            Cpf.Name = "Cpf";
            Cpf.ReadOnly = true;
            Cpf.Width = 120;
            // 
            // Email
            // 
            Email.DataPropertyName = "Email";
            Email.HeaderText = "E-mail";
            Email.MinimumWidth = 6;
            Email.Name = "Email";
            Email.ReadOnly = true;
            Email.Width = 150;
            // 
            // DataCad
            // 
            DataCad.DataPropertyName = "DataCad";
            DataCad.HeaderText = "Data de Cadastro";
            DataCad.MinimumWidth = 6;
            DataCad.Name = "DataCad";
            DataCad.ReadOnly = true;
            DataCad.Width = 125;
            // 
            // clientesDalBindingSource1
            // 
            clientesDalBindingSource1.DataSource = typeof(cldal.ClientesDal);
            // 
            // clientesDalBindingSource
            // 
            clientesDalBindingSource.DataSource = typeof(cldal.ClientesDal);
            // 
            // btSelecionar
            // 
            btSelecionar.Location = new Point(378, 225);
            btSelecionar.Name = "btSelecionar";
            btSelecionar.Size = new Size(75, 23);
            btSelecionar.TabIndex = 1;
            btSelecionar.Text = "Selecionar";
            btSelecionar.UseVisualStyleBackColor = true;
            btSelecionar.Click += BtSelecionar_Click;
            // 
            // btVoltar
            // 
            btVoltar.Location = new Point(459, 225);
            btVoltar.Name = "btVoltar";
            btVoltar.Size = new Size(75, 23);
            btVoltar.TabIndex = 2;
            btVoltar.Text = "Voltar";
            btVoltar.UseVisualStyleBackColor = true;
            btVoltar.Click += BtVoltar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 7);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 3;
            label1.Text = "Clientes";
            // 
            // frmCadastroClientesPesquisar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(547, 281);
            Controls.Add(label1);
            Controls.Add(btVoltar);
            Controls.Add(btSelecionar);
            Controls.Add(dgClientes);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmCadastroClientesPesquisar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Clientes - Pesquisar";
            Load += FrmCadastroClientesPesquisar_Load;
            ((System.ComponentModel.ISupportInitialize)dgClientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)clientesDalBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)clientesDalBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgClientes;
        private Button btSelecionar;
        private Button btVoltar;
        private Label label1;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Cpf;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn DataCad;
        private BindingSource clientesDalBindingSource;
        private BindingSource clientesDalBindingSource1;
    }
}