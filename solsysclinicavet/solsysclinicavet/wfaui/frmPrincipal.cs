using System.Data;
using MySql.Data.MySqlClient;

using cldal;

namespace wfaui
{
    public partial class frmPrincipal : Form
    {

        public frmPrincipal()
        {

            InitializeComponent();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroClientes frmCadClientes = new frmCadastroClientes();
            ///Chama tela de cadastrar clientes
            frmCadClientes.ShowDialog();
        }

        private void petsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroPets frmCadPets = new frmCadastroPets();
            frmCadPets.ShowDialog();
        }
        private void especieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroEspecies frmCadEsp = new frmCadastroEspecies();
            frmCadEsp.ShowDialog();

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btSair_Click(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }


    }
}