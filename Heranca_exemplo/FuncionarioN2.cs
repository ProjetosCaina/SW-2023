namespace Heranca_exemplo;
class FuncionarioN2:Funcionarios
{
    public override double Lucro(){
        return base.Lucro()*0.02;
    }
}

