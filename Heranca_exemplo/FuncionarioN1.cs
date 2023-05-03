namespace Heranca_exemplo;
class FuncionarioN1:Funcionarios
{
    public override double Lucro(){
        return base.Lucro()*0.01;
    }
}
