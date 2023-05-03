namespace Heranca_exemplo;
class Funcionarios
{
    public string? Nome {get;set;}
    public int Idade {get;set;}

    public virtual double Lucro(){    
        return 15000;
    }
}
