using System;

namespace POO1
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria contaBancaria = new ContaBancaria(200);

            contaBancaria.Agencia = "1234-5";
            contaBancaria.Conta = "179845-6";
            contaBancaria.Nome = "Danilo Lustosa";
            contaBancaria.Senha = "senha123";

            contaBancaria.ImprimirSaldo();
            

        }
    }
}
