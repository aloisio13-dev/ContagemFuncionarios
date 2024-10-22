using System;
using System.Collections.Generic;
using System.Linq;

namespace ContagemFuncionarios
{
    class Funcionario
    {
        public string Nome { get; set; }
        public string Departamento { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> funcionarios = new List<Funcionario>
            {
                new Funcionario { Nome = "Luis", Departamento = "TI" },
                new Funcionario { Nome = "João", Departamento = "RH" },
                new Funcionario { Nome = "Maria", Departamento = "Segurança" },
                new Funcionario { Nome = "Paulo", Departamento = "Financeiro" },
                new Funcionario { Nome = "Fernando", Departamento = "RH" }
            };

            var contagemPorDepartamento = funcionarios
                .GroupBy(f => f.Departamento)
                .Select(g => new { Departamento = g.Key, Quantidade = g.Count() });

            foreach (var item in contagemPorDepartamento)
            {
                Console.WriteLine($"Departamento: {item.Departamento},Quantidade de Funcionários: {item.Quantidade}");
            }
        }
    }
}




