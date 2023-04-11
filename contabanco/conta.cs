namespace contabanco;

class Conta

{ 
    public int numeroConta {get;set;}
    private double saldo{get;set;}
    public double limite {get;set;}


    public void deposito (double valor){
        this.saldo += valor;
    }

public void sacar (double valor){
    this.saldo -= valor;
}
    public double Consultarsaldo(){
        return this.saldo + this.limite;
    }
}   