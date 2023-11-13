namespace clmodel
{
    public class ClientesModel
    {
        private int _codigo;
        private string _nome;
        private decimal _cpf;
        private string _email;
        private DateTime _dataCad;

        public int Codigo { get => _codigo; set => _codigo = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public decimal Cpf { get => _cpf; set => _cpf = value; }
        public string Email { get => _email; set => _email = value; }
        public DateTime DataCad { get => _dataCad; set => _dataCad = value; }

    }
}