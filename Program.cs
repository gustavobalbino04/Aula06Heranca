using System;

namespace Aula06Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            //atributos = minuscula/azul
            //metodos = maiuscula/amarelo ou roxo
            
            CPF cpf = new CPF();
            cpf.nome ="Gustavo";
            cpf.cpf="123456789";
            System.Console.WriteLine( cpf.Saudar() );
            System.Console.WriteLine( cpf.ValidarCPF() );
        }
    }
}
