using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cldal;
using clmodel;

namespace wfaui
{
    public partial class frmCadastroEspecies : Form
    {
        public frmCadastroEspecies()
        {
            InitializeComponent();
        }
        private void LimparCampos()
        {
            tbCodigo.Text = string.Empty;
            tbNome.Text = string.Empty;
        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            frmCadastrarEspeciesPesquisar frm = new frmCadastrarEspeciesPesquisar();
            frm.ShowDialog();

            if (frm.especie.Codigo > 0)
            {
                tbCodigo.Text = frm.especie.Codigo.ToString();
                tbNome.Text = frm.especie.Nome.ToString();              

            }
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            EspecieModel cadastrarEspecie = new EspecieModel();

            cadastrarEspecie.Nome = tbNome.Text;

            EspecieDal dal = new EspecieDal();

            try
            {
                dal.inserir(cadastrarEspecie);
                MessageBox.Show("Cliente cadastrado com sucesso!");
                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar Cliente!" + ex.Message);
            }
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            EspecieModel atualizarEspecie = new EspecieModel();

            atualizarEspecie.Codigo = Convert.ToInt32(tbCodigo.Text);
            atualizarEspecie.Nome = tbNome.Text;

            EspecieDal dal = new EspecieDal();
            dal.atualizar(atualizarEspecie);

            try
            {
                EspecieDal cliente = new EspecieDal();
                dal.atualizar(atualizarEspecie);
                MessageBox.Show("Os dados do cliente foram atualizados com sucesso!");
                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar os dados do Cliente!" + ex.Message);
            }

        }

        private void btRemover_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbCodigo.Text))
            {
                int codigoEspecie = Convert.ToInt32(tbCodigo.Text);
                try
                {
                    EspecieDal dal = new EspecieDal();
                    dal.excluir(codigoEspecie);
                    MessageBox.Show("O cliente foi removido com sucesso!");
                    LimparCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao tentar excluir cliente!!");
                }
            }
            else
            {
                MessageBox.Show("O campo ID está vazio ou em formato inválido");
            }
        }
    }
}
