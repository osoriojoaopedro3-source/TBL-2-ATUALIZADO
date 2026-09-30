using System;
using System.Collections.Generic;

class Pagamento
{
    public virtual void ProcessarPagamento()
    {
        Console.WriteLine("Processando pagamento padrão...");
    }
}

class CartaoCredito : Pagamento
{
    public override void ProcessarPagamento()
    {
        Console.WriteLine("Processando pagamento via Cartão de Crédito...");
    }
}

class BoletoBancario : Pagamento
{
    public override void ProcessarPagamento()
    {
        Console.WriteLine("Processando pagamento via Boleto Bancário...");
    }
}

class Pix : Pagamento
{
    public override void ProcessarPagamento()
    {
        Console.WriteLine("Processando pagamento via Pix...");
    }
}

class Program
{
    static void Main()
    {
        List<Pagamento> pagamentos = new List<Pagamento>
        {
            new CartaoCredito(),
            new BoletoBancario(),
            new Pix()
        };

        foreach (var pagamento in pagamentos)
        {
            pagamento.ProcessarPagamento();
        }
    }
}
