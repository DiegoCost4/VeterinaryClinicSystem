using cldal;
using clmodel;

namespace wfaui
{
    public partial class frmCadastroClientesPesquisar : Form
    {
        public frmCadastroClientesPesquisar()
        {
            InitializeComponent();
        }
        public ClientesModel clientes;
        private ClientesDal clientesDal;

        private void CarregarGrid()
        {
            dgClientes.DataSource = clientesDal.listarTodosArray();
        }
        private void SelecionarItem()
        {
            Int32 i = 0;

            i = dgClientes.CurrentRow.Index;
            clientes.Codigo = Int32.Parse(dgClientes[0, i].Value.ToString());
            clientes.Nome = dgClientes[1, i].Value.ToString();
            clientes.Cpf = decimal.Parse(dgClientes[2, i].Value.ToString());
            clientes.Email = dgClientes[3, i].Value.ToString();

        }
        private void FrmCadastroClientesPesquisar_Load(object sender, EventArgs e)
        {
            this.clientes = new ClientesModel();
            this.clientesDal = new ClientesDal();
            this.CarregarGrid();
        }

        private void BtSelecionar_Click(object sender, EventArgs e)
        {
            this.SelecionarItem();
            this.Close();
        }

        private void BtVoltar_Click(object sender, EventArgs e)
        {
            this.clientes.Codigo = 0;
            this.Close();
        }

        private void dgClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
