using System;
using System.Collections.Generic;
using System.Text;

namespace POO1
{
    class ContaBancaria
    {
        public string Conta { get; set; }
        public string Agencia { get; set; }
        public string Nome { get; set; }
        public string Senha { private get; set; }
        private int Saldo;

        public ContaBancaria(int saldo)
        {
            Saldo = saldo;
        }

        public void Depositar(int valor)
        {
            Saldo = Saldo + valor;
        }

        public void Sacar(int valor)
        {
            Saldo = Saldo - valor;
        }

        public int ConsultarSaldo()
        {
            int taxa = 10;
            int valorTaxa = (Saldo * taxa) / 100;
            return Saldo - valorTaxa;
        }

        public void ImprimirSaldo() 
        {
            Console.WriteLine($"{Nome}, o saldo da sua conta {Conta} na agência {Agencia} é: {ConsultarSaldo()}");
        }
    }
}
