using cldal;
using clmodel;
using MySqlX.XDevAPI;
using System.Globalization;

namespace wfaui
{
    public partial class frmCadastroPetsPesquisa : Form
    {
        public frmCadastroPetsPesquisa()
        {
            InitializeComponent();
        }
        public PetsModel pets;
        private PetsDal petsDal;

        private void CarregarGrid()
        {
            dgPets.DataSource = petsDal.listarTodosArray();
        }
        private void SelecionarItem()
        {
            Int32 i = 0;

            i = dgPets.CurrentRow.Index;
            pets.Codigo = Int32.Parse(dgPets[0, i].Value.ToString());
            pets.Nome = dgPets[1, i].Value.ToString();
            pets.Apelido = dgPets[2, i].Value.ToString();
            pets.Datanasc = DateTime.ParseExact(dgPets[3, i].Value.ToString(), "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);



        }
        private void FrmCadastroPetsPesquisa_Load(object sender, EventArgs e)
        {
            this.pets = new PetsModel();
            this.petsDal = new PetsDal();
            this.CarregarGrid();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.SelecionarItem();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.pets.Codigo = 0;
            this.Close();
        }
    }
}
