namespace contabanco;
class Program
{
        static void Main(string[] args)
    {
        Console.WriteLine("Exercício Conta de Banco");
        Conta conta = new Conta();

        conta.deposito(200);
        conta.limite = 2000;
        conta.sacar(500);
    
        double saldo = conta.Consultarsaldo();
        Console.WriteLine("Seu saldo é: "+ saldo);
    }
}
