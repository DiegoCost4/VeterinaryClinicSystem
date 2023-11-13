using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using cldal;
using clmodel;

namespace wfaui
{
    public partial class frmCadastroPets : Form
    {
        public frmCadastroPets()
        {
            InitializeComponent();
        }

        private void frmCadastroPets_Load(object sender, EventArgs e)
        {

        }
        private void LimparCampos()
        {
            tbCodigo.Text = string.Empty;
            tbNome.Text = string.Empty;
            tbApelido.Text = string.Empty;
            tbData.Text = string.Empty;
            tbObserv.Text = string.Empty;

        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            frmCadastroPetsPesquisa frm = new frmCadastroPetsPesquisa();
            frm.ShowDialog();

            if (frm.pets.Codigo > 0)
            {
                tbCodigo.Text = frm.pets.Codigo.ToString();
                tbNome.Text = frm.pets.Nome.ToString();
                tbApelido.Text = frm.pets.Apelido.ToString();
                tbData.Text = frm.pets.Datanasc.ToString();
                if (frm.pets != null)
                {
                    tbObserv.Text = frm.pets.Observ != null ? frm.pets.Observ.ToString() : string.Empty;
                }
                else
                {
                    tbObserv.Text = string.Empty;
                }


            }
        }

        private void brRemover_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbCodigo.Text))
            {
                int codigoPet = Convert.ToInt32(tbCodigo.Text);
                try
                {
                    PetsDal dal = new PetsDal();
                    dal.excluir(codigoPet);
                    MessageBox.Show("O Pet foi removido com sucesso!");
                    LimparCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao tentar excluir Pet!!");
                }
            }
            else
            {
                MessageBox.Show("O campo ID está vazio ou em formato inválido");
            }
        }

        private void btNovo_Click_1(object sender, EventArgs e)
        {
            PetsModel cadastrarPets = new PetsModel();

            cadastrarPets.Nome = tbNome.Text;
            cadastrarPets.Apelido = tbApelido.Text;
            cadastrarPets.Datanasc = DateTime.ParseExact(tbData.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            cadastrarPets.Observ = tbObserv.Text;
            //cadastrarPets.Especie =


            PetsDal dal = new PetsDal();

            try
            {
                dal.inserir(cadastrarPets);
                MessageBox.Show("Pet cadastrado com sucesso!");
                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar Pet!" + ex.Message);
            }
        }

        private void btSalvar_Click_1(object sender, EventArgs e)
        {
            PetsModel atualizarPets = new PetsModel();

            atualizarPets.Codigo = Convert.ToInt32(tbCodigo.Text);
            atualizarPets.Nome = tbNome.Text;
            atualizarPets.Apelido = tbApelido.Text;
            atualizarPets.Datanasc = DateTime.ParseExact(tbData.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            atualizarPets.Observ = tbObserv.Text;

            PetsDal dal = new PetsDal();
            dal.atualizar(atualizarPets);

            try
            {
                PetsDal Pets = new PetsDal();
                dal.atualizar(atualizarPets);
                MessageBox.Show("Os dados do Pet foram atualizados com sucesso!");
                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar os dados do Pet!" + ex.Message);
            }
        }
    }
}
