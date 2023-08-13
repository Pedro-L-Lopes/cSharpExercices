using System.Globalization;

namespace Course
{
    class Produto
    {
        private string _nome;
        private double Preco { get; private set; };
        public int Quantidade { get; private set; }

        public Produto() { }

        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }


        /*public double Preco
        {
            get { return _preco; }
        }

        public int Quantidade
        {
            get { return _quantidade }
        }*/

        /*public string GetNome()
        {
            return _nome;
        }

        public void SetNome(string nome)
        {
            if (nome != null && nome.Length > 1)
            {
                _nome = nome;
            }

        } */

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return _nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

/*  public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = 0;
        }

        // Usando this para diferenciar as variaveis locais da globais
        public Produto(string Nome, double Preco)
        {
            this.Nome = Nome;
            this.Preco = Preco;
            Quantidade = 0;
        }

        // Construtor padrão exemplo
        public Produto()
        {
            Quantidade = 0;
        }

        // Usando construtor padrão da classe
        public Produto(string nome, double preco): this()
        {
            Nome = nome;
            Preco = preco;
        }

        // Usando contrutor de dois argumentos
        public Produto(int quantidade) : this(nome, preco)
        {
            Quantidade = quantidade;
        }

        // Reaproveitando
        public Produto(string nome, double preco, int quantidade) : this(nome, preco)
        {
            Quantidade = quantidade;
        }*/