namespace overridingAndAbstractClass
{
	public class ContaComum : Conta
	{
		public ContaComum(int numero, double saldo) : base(numero, saldo) { }

		public override bool Sacar(double valor)
		{
			if (valor > 0 && valor <= Saldo)
			{
				Saldo -= valor;
				return true;
			}
			return false;
		}
	}
}
