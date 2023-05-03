namespace Heranca_exemplo;
class Program
{
    static void Main(string[] args)
    {
        FuncionarioN1 n1 = new FuncionarioN1();
        FuncionarioN2 n2 = new FuncionarioN2();
        FuncionarioN3 n3 = new FuncionarioN3();

        n1.Nome = "zé";
        n2.Nome = "pedrin";
        n3.Nome = "jao";

        Console.WriteLine("nome: " + n1.Nome + "Lucro: " + n1.Lucro());
        Console.WriteLine("nome: " + n2.Nome + "Lucro: " + n2.Lucro());
        Console.WriteLine("nome: " + n3.Nome + "Lucro: " + n3.Lucro());
    }

}
