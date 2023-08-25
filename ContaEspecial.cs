namespace overridingAndAbstractClass
{
	public class ContaEspecial : Conta
	{
		private double _limite;

		public ContaEspecial(int numero, double saldo, double limite) : base(numero, saldo)
		{
			this._limite = limite;
		}

		public override bool Sacar(double valor)
		{
			if (valor > 0 && valor <= Saldo + _limite)
			{
				Saldo -= valor;
				return true;
			}
			return false;
		}
	}
}
