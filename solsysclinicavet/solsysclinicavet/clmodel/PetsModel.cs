namespace clmodel
{
    public class PetsModel
    {
        private int _codigo;
        private string _nome;
        private string _apelido;
        private DateTime _datanasc;
        private string _observ;
        private string _especie;

        public int Codigo { get => _codigo; set => _codigo = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public string Apelido { get => _apelido; set => _apelido = value; }
        public DateTime Datanasc { get => _datanasc; set => _datanasc = value; }
        public string Observ { get => _observ; set => _observ = value; }
        public string Especie { get => _especie; set => _especie = value; }
    }
}
