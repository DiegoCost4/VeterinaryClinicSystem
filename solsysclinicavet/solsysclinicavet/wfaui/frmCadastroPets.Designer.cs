namespace wfaui
{
    partial class frmCadastroPets
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
            label4 = new Label();
            tbNome = new TextBox();
            tbApelido = new TextBox();
            tbObserv = new TextBox();
            btNovo = new Button();
            btSalvar = new Button();
            brRemover = new Button();
            btPesquisar = new Button();
            label5 = new Label();
            tbCodigo = new TextBox();
            tbData = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 57);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 102);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 1;
            label2.Text = "Apelido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(70, 146);
            label3.Name = "label3";
            label3.Size = new Size(114, 15);
            label3.TabIndex = 2;
            label3.Text = "Data de Nascimento";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(70, 190);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 3;
            label4.Text = "Observação";
            // 
            // tbNome
            // 
            tbNome.Location = new Point(70, 75);
            tbNome.Name = "tbNome";
            tbNome.Size = new Size(100, 23);
            tbNome.TabIndex = 4;
            // 
            // tbApelido
            // 
            tbApelido.Location = new Point(70, 120);
            tbApelido.Name = "tbApelido";
            tbApelido.Size = new Size(100, 23);
            tbApelido.TabIndex = 5;
            // 
            // tbObserv
            // 
            tbObserv.Location = new Point(72, 207);
            tbObserv.Name = "tbObserv";
            tbObserv.Size = new Size(388, 23);
            tbObserv.TabIndex = 7;
            // 
            // btNovo
            // 
            btNovo.Location = new Point(70, 255);
            btNovo.Name = "btNovo";
            btNovo.Size = new Size(75, 23);
            btNovo.TabIndex = 8;
            btNovo.Text = "Novo";
            btNovo.UseVisualStyleBackColor = true;
            btNovo.Click += btNovo_Click_1;
            // 
            // btSalvar
            // 
            btSalvar.Location = new Point(151, 255);
            btSalvar.Name = "btSalvar";
            btSalvar.Size = new Size(75, 23);
            btSalvar.TabIndex = 9;
            btSalvar.Text = "Salvar";
            btSalvar.UseVisualStyleBackColor = true;
            btSalvar.Click += btSalvar_Click_1;
            // 
            // brRemover
            // 
            brRemover.Location = new Point(232, 255);
            brRemover.Name = "brRemover";
            brRemover.Size = new Size(75, 23);
            brRemover.TabIndex = 10;
            brRemover.Text = "Remover";
            brRemover.UseVisualStyleBackColor = true;
            brRemover.Click += brRemover_Click;
            // 
            // btPesquisar
            // 
            btPesquisar.Location = new Point(313, 255);
            btPesquisar.Name = "btPesquisar";
            btPesquisar.Size = new Size(75, 23);
            btPesquisar.TabIndex = 11;
            btPesquisar.Text = "Pesquisar";
            btPesquisar.UseVisualStyleBackColor = true;
            btPesquisar.Click += btPesquisar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(72, 9);
            label5.Name = "label5";
            label5.Size = new Size(46, 15);
            label5.TabIndex = 12;
            label5.Text = "Código";
            // 
            // tbCodigo
            // 
            tbCodigo.BackColor = SystemColors.ScrollBar;
            tbCodigo.Enabled = false;
            tbCodigo.Location = new Point(72, 27);
            tbCodigo.Name = "tbCodigo";
            tbCodigo.Size = new Size(100, 23);
            tbCodigo.TabIndex = 3;
            // 
            // tbData
            // 
            tbData.Format = DateTimePickerFormat.Short;
            tbData.Location = new Point(70, 164);
            tbData.Margin = new Padding(3, 2, 3, 2);
            tbData.Name = "tbData";
            tbData.Size = new Size(219, 23);
            tbData.TabIndex = 13;
            // 
            // frmCadastroPets
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(492, 338);
            Controls.Add(tbData);
            Controls.Add(tbCodigo);
            Controls.Add(label5);
            Controls.Add(btPesquisar);
            Controls.Add(brRemover);
            Controls.Add(btSalvar);
            Controls.Add(btNovo);
            Controls.Add(tbObserv);
            Controls.Add(tbApelido);
            Controls.Add(tbNome);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmCadastroPets";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Pets";
            Load += frmCadastroPets_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tbNome;
        private TextBox tbApelido;
        private TextBox tbObserv;
        private Button btNovo;
        private Button btSalvar;
        private Button brRemover;
        private Button btPesquisar;
        private Label label5;
        private TextBox tbCodigo;
        private DateTimePicker tbData;
    }
}