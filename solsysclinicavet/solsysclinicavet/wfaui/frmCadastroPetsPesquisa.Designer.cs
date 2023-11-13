namespace wfaui
{
    partial class frmCadastroPetsPesquisa
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
            button3 = new Button();
            button4 = new Button();
            dgPets = new DataGridView();
            Codigo = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            Apelido = new DataGridViewTextBoxColumn();
            Datanasc = new DataGridViewTextBoxColumn();
            Observ = new DataGridViewTextBoxColumn();
            Especie = new DataGridViewTextBoxColumn();
            petsDalBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dgPets).BeginInit();
            ((System.ComponentModel.ISupportInitialize)petsDalBindingSource).BeginInit();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Location = new Point(633, 386);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 12;
            button3.Text = "Selecionar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(733, 386);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 13;
            button4.Text = "Voltar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // dgPets
            // 
            dgPets.AllowUserToAddRows = false;
            dgPets.AllowUserToDeleteRows = false;
            dgPets.AutoGenerateColumns = false;
            dgPets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgPets.Columns.AddRange(new DataGridViewColumn[] { Codigo, Nome, Apelido, Datanasc, Observ, Especie });
            dgPets.DataSource = petsDalBindingSource;
            dgPets.Location = new Point(12, 31);
            dgPets.Name = "dgPets";
            dgPets.ReadOnly = true;
            dgPets.RowHeadersWidth = 51;
            dgPets.Size = new Size(812, 311);
            dgPets.TabIndex = 14;
            // 
            // Codigo
            // 
            Codigo.DataPropertyName = "Codigo";
            Codigo.HeaderText = "Código";
            Codigo.MinimumWidth = 6;
            Codigo.Name = "Codigo";
            Codigo.ReadOnly = true;
            Codigo.Width = 70;
            // 
            // Nome
            // 
            Nome.DataPropertyName = "Nome";
            Nome.HeaderText = "Nome";
            Nome.MinimumWidth = 6;
            Nome.Name = "Nome";
            Nome.ReadOnly = true;
            Nome.Width = 125;
            // 
            // Apelido
            // 
            Apelido.DataPropertyName = "Apelido";
            Apelido.HeaderText = "Apelido";
            Apelido.MinimumWidth = 6;
            Apelido.Name = "Apelido";
            Apelido.ReadOnly = true;
            Apelido.Width = 125;
            // 
            // Datanasc
            // 
            Datanasc.DataPropertyName = "Datanasc";
            Datanasc.HeaderText = "Data de Nascimento";
            Datanasc.MinimumWidth = 6;
            Datanasc.Name = "Datanasc";
            Datanasc.ReadOnly = true;
            Datanasc.Width = 125;
            // 
            // Observ
            // 
            Observ.DataPropertyName = "Observ";
            Observ.HeaderText = "Observações";
            Observ.MinimumWidth = 6;
            Observ.Name = "Observ";
            Observ.ReadOnly = true;
            Observ.Width = 180;
            // 
            // Especie
            // 
            Especie.DataPropertyName = "Especie";
            Especie.HeaderText = "Cod. Especie";
            Especie.MinimumWidth = 6;
            Especie.Name = "Especie";
            Especie.ReadOnly = true;
            Especie.Width = 125;
            // 
            // petsDalBindingSource
            // 
            petsDalBindingSource.DataSource = typeof(cldal.PetsDal);
            // 
            // frmCadastroPetsPesquisa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(836, 450);
            Controls.Add(dgPets);
            Controls.Add(button4);
            Controls.Add(button3);
            Name = "frmCadastroPetsPesquisa";
            Text = "frmCadastroPetsPesquisa";
            Load += FrmCadastroPetsPesquisa_Load;
            ((System.ComponentModel.ISupportInitialize)dgPets).EndInit();
            ((System.ComponentModel.ISupportInitialize)petsDalBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button button3;
        private Button button4;
        private DataGridView dgPets;
        private BindingSource petsDalBindingSource;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Apelido;
        private DataGridViewTextBoxColumn Datanasc;
        private DataGridViewTextBoxColumn Observ;
        private DataGridViewTextBoxColumn Especie;
    }
}