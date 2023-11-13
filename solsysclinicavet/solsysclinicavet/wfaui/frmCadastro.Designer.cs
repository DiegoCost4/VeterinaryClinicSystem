namespace wfaui
{
    partial class frmCadastro
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
            panel1 = new Panel();
            label2 = new Label();
            label3 = new Label();
            tbUser = new TextBox();
            tbSenha = new TextBox();
            btCadastrar = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(287, 150);
            label1.Name = "label1";
            label1.Size = new Size(125, 20);
            label1.TabIndex = 0;
            label1.Text = "Faça seu cadastro";
            // 
            // panel1
            // 
            panel1.Controls.Add(btCadastrar);
            panel1.Controls.Add(tbSenha);
            panel1.Controls.Add(tbUser);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(144, 173);
            panel1.Name = "panel1";
            panel1.Size = new Size(454, 176);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 50);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 0;
            label2.Text = "Usuario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 97);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 1;
            label3.Text = "Senha";
            // 
            // tbUser
            // 
            tbUser.Location = new Point(112, 43);
            tbUser.Name = "tbUser";
            tbUser.Size = new Size(219, 27);
            tbUser.TabIndex = 2;
            tbUser.TextChanged += tbUser_TextChanged;
            // 
            // tbSenha
            // 
            tbSenha.Location = new Point(112, 90);
            tbSenha.Name = "tbSenha";
            tbSenha.Size = new Size(219, 27);
            tbSenha.TabIndex = 3;
            tbSenha.TextChanged += tbSenha_TextChanged;
            // 
            // btCadastrar
            // 
            btCadastrar.Location = new Point(332, 135);
            btCadastrar.Name = "btCadastrar";
            btCadastrar.Size = new Size(94, 29);
            btCadastrar.TabIndex = 4;
            btCadastrar.Text = "Confirmar";
            btCadastrar.UseVisualStyleBackColor = true;
            btCadastrar.Click += btCadastrar_Click;
            // 
            // cadastro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.job562_nunoon_10;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(741, 547);
            Controls.Add(panel1);
            Controls.Add(label1);
            ForeColor = SystemColors.ControlDarkDark;
            Name = "cadastro";
            Text = "cadastro";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label3;
        private Label label2;
        private Button btCadastrar;
        private TextBox tbSenha;
        private TextBox tbUser;
    }
}