namespace overridingAndAbstractClass
{
    public abstract class Conta
    {
        private int _numero;
        private double _saldo;

        public Conta(int numero, double saldo)
        {
            this._numero = numero;
            this._saldo = saldo;
        }

        public double Saldo
        {
            get { return _saldo; }
            set { _saldo = value; }
        }

        public bool Depositar(double valor)
        {
            if (valor > 0)
            {
                _saldo += valor;
                return true;
            }
            return false;
        }

        public abstract bool Sacar(double valor);

        public void ConsultarSaldo()
        {
            Console.WriteLine($"Conta nº {_numero} - Saldo: R$ {_saldo:F2}");
        }
    }
}
