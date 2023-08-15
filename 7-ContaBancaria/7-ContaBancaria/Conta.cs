using System.Globalization;

namespace Course
{
    class Conta
    {
        public string _nome;
        public int NumeroConta { get; private set; }
        public double Saldo { get; private set; }

        public Conta(string nome, int numeroConta)
        {
            _nome = nome;
            NumeroConta = numeroConta;
        }

        public Conta(string nome, int numeroConta, double saldo) : this(nome, numeroConta)
        {
            AdicionarSaldo(saldo);
        }

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (_nome != value && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

        public void AdicionarSaldo(double saldo)
        {
            Saldo += saldo;
        }

        public void RemoverSaldo(double saldo)
        {
            Saldo -= saldo + 5;
        }

        public override string ToString()
        {
            return "Conta "
                + NumeroConta
                + ", Titular: "
                + Nome
                + ", Saldo: R$"
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
