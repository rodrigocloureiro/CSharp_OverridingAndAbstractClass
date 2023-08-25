using overridingAndAbstractClass;

public class Program
{
    public static void Main(string[] args)
    {
        // Criando conta comum e consultando saldo
        Conta cc = new ContaComum(12345, 1000);
        cc.ConsultarSaldo();
        Console.WriteLine("\n===================================\n");

        // Depositando R$ 129.90 e consultando saldo
        cc.Depositar(129.90);
        cc.ConsultarSaldo();
        Console.WriteLine("\n===================================\n");

        // Sacando R$ 759.00 e consultando saldo
        cc.Sacar(759.90);
        cc.ConsultarSaldo();
        Console.WriteLine("\n===================================\n");

        // Tentando sacar mais que o saldo
        if (cc.Sacar(371.00)) cc.ConsultarSaldo();
        else
        {
            Console.WriteLine("Não foi possível realizar o saque..");
            cc.ConsultarSaldo();
        }
        Console.WriteLine("\n===================================\n");

        // Criando conta poupanca e consultando saldo
        ContaPoupanca cp = new ContaPoupanca(67890, 550.00, 10);
        cp.ConsultarSaldo();
        Console.WriteLine("\n===================================\n");

        // Depositando R$ 50.00 e consultando saldo
        cp.Depositar(50.00);
        cp.ConsultarSaldo();
        Console.WriteLine("\n===================================\n");

        // Sacando R$ 499.99 e consultando saldo
        cp.Sacar(499.99);
        cp.ConsultarSaldo();
        Console.WriteLine("\n===================================\n");

        // Tentando sacar mais que o saldo
        if (cp.Sacar(120.00)) cp.ConsultarSaldo();
        else
        {
            Console.WriteLine("Não foi possível realizar o saque..");
            cp.ConsultarSaldo();
        }
        Console.WriteLine("\n===================================\n");

        // Rendendo 10% na poupança e consultando saldo
        cp.Render();
        cp.ConsultarSaldo();
        Console.WriteLine("\n===================================\n");

        // Criando conta especial e consultando saldo
        Conta ce = new ContaEspecial(13579, 12_600.50, 100_000);
        ce.ConsultarSaldo();
        Console.WriteLine("\n===================================\n");

        // Depositando R$ 399.50 e consultando saldo
        ce.Depositar(399.50);
        ce.ConsultarSaldo();
        Console.WriteLine("\n===================================\n");

        // Sacando R$ 12.000 e consultando saldo
        ce.Sacar(12_000);
        ce.ConsultarSaldo();
        Console.WriteLine("\n===================================\n");

        // Tentando sacar mais que o saldo e menos que o limite e consultando saldo
        ce.Sacar(90_000);
        ce.ConsultarSaldo();
        Console.WriteLine("\n===================================\n");

        // Tentando sacar mais que o limite da conta
        if (ce.Sacar(11_500)) ce.ConsultarSaldo();
        else
        {
            Console.WriteLine("Não foi possível realizar o saque..");
            ce.ConsultarSaldo();
        }

        Console.ReadKey();
    }
}
