using cldal;
using clmodel;

namespace wfaui
{
    public partial class frmCadastrarEspeciesPesquisar : Form
    {
        public frmCadastrarEspeciesPesquisar()
        {
            InitializeComponent();
        }
        public EspecieModel especie;
        private EspecieDal especieDal;

        private void CarregarGrid()
        {
            dgEspecies.DataSource = especieDal.listarTodosArray();

        }

        private void SelecionarItem()
        {
            Int32 i = 0;

            i = dgEspecies.CurrentRow.Index;
            especie.Codigo = Int32.Parse(dgEspecies[0, i].Value.ToString());
            especie.Nome = dgEspecies[1, i].Value.ToString();


        }




        private void frmCadastrarEspeciesPesquisar_Load(object sender, EventArgs e)
        {
            this.especie = new EspecieModel();
            this.especieDal = new EspecieDal();
            this.CarregarGrid();
        }

        private void dgEspecies_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.SelecionarItem();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.especie.Codigo = 0;
            this.Close();
        }
    }
}
