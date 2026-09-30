using System;
using System.Collections.Generic;

abstract class Funcionario
{
    public string Nome { get; set; }

    public Funcionario(string nome)
    {
        Nome = nome;
    }

    public abstract decimal CalcularSalario();
}

class Gerente : Funcionario
{
    public decimal SalarioBase { get; set; }
    public decimal Bonus { get; set; }

    public Gerente(string nome, decimal salarioBase, decimal bonus)
        : base(nome)
    {
        SalarioBase = salarioBase;
        Bonus = bonus;
    }

    public override decimal CalcularSalario()
    {
        return SalarioBase + Bonus;
    }
}

class Programador : Funcionario
{
    public decimal SalarioBase { get; set; }
    public decimal BonusPorProjeto { get; set; }

    public Programador(string nome, decimal salarioBase, decimal bonusPorProjeto)
        : base(nome)
    {
        SalarioBase = salarioBase;
        BonusPorProjeto = bonusPorProjeto;
    }

    public override decimal CalcularSalario()
    {
        return SalarioBase + BonusPorProjeto;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Gerente gerente = new Gerente("Carlos", 8000m, 2000m);
        Programador programador = new Programador("Ana", 5000m, 1000m);

        Console.WriteLine($"Gerente: {gerente.Nome} - Salário: {gerente.CalcularSalario():C}");
        Console.WriteLine($"Programador: {programador.Nome} - Salário: {programador.CalcularSalario():C}");

        List<Funcionario> funcionarios = new List<Funcionario>
        {
            gerente,
            programador
        };

        Console.WriteLine("\nLista de funcionários:");
        foreach (var funcionario in funcionarios)
        {
            Console.WriteLine($"{funcionario.GetType().Name} - {funcionario.Nome} - Salário: {funcionario.CalcularSalario():C}");
        }
    }
}
