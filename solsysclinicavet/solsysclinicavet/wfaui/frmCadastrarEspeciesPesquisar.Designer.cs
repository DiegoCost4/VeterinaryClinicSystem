namespace wfaui
{
    partial class frmCadastrarEspeciesPesquisar
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
            dgEspecies = new DataGridView();
            Codigo = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            especieDalBindingSource3 = new BindingSource(components);
            especieDalBindingSource1 = new BindingSource(components);
            especieDalBindingSource = new BindingSource(components);
            button1 = new Button();
            button2 = new Button();
            Especies = new Label();
            especieDalBindingSource2 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dgEspecies).BeginInit();
            ((System.ComponentModel.ISupportInitialize)especieDalBindingSource3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)especieDalBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)especieDalBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)especieDalBindingSource2).BeginInit();
            SuspendLayout();
            // 
            // dgEspecies
            // 
            dgEspecies.AllowUserToAddRows = false;
            dgEspecies.AllowUserToDeleteRows = false;
            dgEspecies.AutoGenerateColumns = false;
            dgEspecies.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgEspecies.Columns.AddRange(new DataGridViewColumn[] { Codigo, Nome });
            dgEspecies.DataSource = especieDalBindingSource3;
            dgEspecies.Location = new Point(12, 40);
            dgEspecies.Name = "dgEspecies";
            dgEspecies.ReadOnly = true;
            dgEspecies.RowTemplate.Height = 25;
            dgEspecies.Size = new Size(253, 150);
            dgEspecies.TabIndex = 0;
            dgEspecies.CellContentClick += dgEspecies_CellContentClick;
            // 
            // Codigo
            // 
            Codigo.DataPropertyName = "Codigo";
            Codigo.HeaderText = "Código";
            Codigo.Name = "Codigo";
            Codigo.ReadOnly = true;
            // 
            // Nome
            // 
            Nome.DataPropertyName = "Nome";
            Nome.HeaderText = "Nome";
            Nome.Name = "Nome";
            Nome.ReadOnly = true;
            // 
            // especieDalBindingSource3
            // 
            especieDalBindingSource3.DataSource = typeof(cldal.EspecieDal);
            // 
            // especieDalBindingSource1
            // 
            especieDalBindingSource1.DataSource = typeof(cldal.EspecieDal);
            // 
            // especieDalBindingSource
            // 
            especieDalBindingSource.DataSource = typeof(cldal.EspecieDal);
            // 
            // button1
            // 
            button1.Location = new Point(189, 196);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Selecionar";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(190, 225);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "Voltar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Especies
            // 
            Especies.AutoSize = true;
            Especies.Location = new Point(12, 22);
            Especies.Name = "Especies";
            Especies.Size = new Size(51, 15);
            Especies.TabIndex = 3;
            Especies.Text = "Especies";
            // 
            // especieDalBindingSource2
            // 
            especieDalBindingSource2.DataSource = typeof(cldal.EspecieDal);
            // 
            // frmCadastrarEspeciesPesquisar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(276, 260);
            Controls.Add(Especies);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dgEspecies);
            Name = "frmCadastrarEspeciesPesquisar";
            Text = "frmCadastrarEspeciesPesquisar";
            Load += frmCadastrarEspeciesPesquisar_Load;
            ((System.ComponentModel.ISupportInitialize)dgEspecies).EndInit();
            ((System.ComponentModel.ISupportInitialize)especieDalBindingSource3).EndInit();
            ((System.ComponentModel.ISupportInitialize)especieDalBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)especieDalBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)especieDalBindingSource2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgEspecies;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Nome;
        private BindingSource especieDalBindingSource;
        private Button button1;
        private Button button2;
        private Label Especies;
        private BindingSource especieDalBindingSource1;
        private BindingSource especieDalBindingSource3;
        private BindingSource especieDalBindingSource2;
    }
}