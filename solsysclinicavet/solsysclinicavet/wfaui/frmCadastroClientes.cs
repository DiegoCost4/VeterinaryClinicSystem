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
using clbll;

namespace wfaui
{
    public partial class frmCadastroClientes : Form
    {
        public frmCadastroClientes()
        {
            InitializeComponent();
        }
        private void LimparCampos()
        {
            tbCodigo.Text = string.Empty;
            tbNome.Text = string.Empty;
            tbCpf.Text = string.Empty;
            tbEmail.Text = string.Empty;

        }

        // Chame a função LimparCampos quando precisar limpar os campos, por exemplo, após um cadastro ou ao abrir um novo formulário.


        private void btPesquisar_Click(object sender, EventArgs e)
        {
            frmCadastroClientesPesquisar frm = new frmCadastroClientesPesquisar();
            frm.ShowDialog();

            if (frm.clientes.Codigo > 0)
            {
                tbCodigo.Text = frm.clientes.Codigo.ToString();
                tbNome.Text = frm.clientes.Nome.ToString();
                tbCpf.Text = frm.clientes.Cpf.ToString();
                tbEmail.Text = frm.clientes.Email.ToString();
                //tbData.Text = frm.clientes.DataCad.ToString();

            }
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            ClientesModel cadastrarCliente = new ClientesModel();

            cadastrarCliente.Nome = tbNome.Text;
            cadastrarCliente.Cpf = decimal.Parse(tbCpf.Text);
            cadastrarCliente.Email = tbEmail.Text;
            //cadastrarCliente.DataCad = DateTime.ParseExact(tbData.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);

            //ClientesDal dal = new ClientesDal();
            CadastrarClienteBll bll = new CadastrarClienteBll();


            try 
            {
                bll.inserir(cadastrarCliente);
                MessageBox.Show("Cliente cadastrado com sucesso!");
            }
            //try
            //{
            //    dal.inserir(cadastrarCliente);
            //    MessageBox.Show("Cliente cadastrado com sucesso!");
            //    LimparCampos();
            //}
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar Cliente!" + ex.Message);
            }
        }

        private void tbData_ValueChanged(object sender, EventArgs e)
        {
            tbData.Value = DateTime.Today;
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            ClientesModel atualizarCliente = new ClientesModel();

            atualizarCliente.Codigo = Convert.ToInt32(tbCodigo.Text);
            atualizarCliente.Nome = tbNome.Text;
            atualizarCliente.Cpf = decimal.Parse(tbCpf.Text);
            atualizarCliente.Email = tbEmail.Text;

            ClientesDal dal = new ClientesDal();
            dal.atualizar(atualizarCliente);

            try
            {
                ClientesDal cliente = new ClientesDal();
                dal.atualizar(atualizarCliente);
                MessageBox.Show("Os dados do cliente foram atualizados com sucesso!");
                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar os dados do Cliente!" + ex.Message);
            }
        }

        private void brRemover_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbCodigo.Text))
            {
                int codigoCliente = Convert.ToInt32(tbCodigo.Text);
                try
                {
                    ClientesDal dal = new ClientesDal();
                    dal.excluir(codigoCliente);
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

        private void frmCadastroClientes_Load(object sender, EventArgs e)
        {

        }

        private void frmCadastroClientes_Load_1(object sender, EventArgs e)
        {

        }
    }
}
