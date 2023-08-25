namespace overridingAndAbstractClass
{
	public class ContaPoupanca : Conta
	{
		private double _percentualRendimento;

		public ContaPoupanca(int numero, double saldo, double percentual) : base(numero, saldo)
		{
			this._percentualRendimento = percentual;
		}

		public override bool Sacar(double valor)
		{
			if (valor > 0 && valor <= Saldo)
			{
				Saldo -= valor;
				return true;
			}
			return false;
		}

		public void Render()
		{
			Saldo *= (1 + _percentualRendimento / 100);
		}
	}
}
