/*
Exercício 1: Calculadora de Divisão
Crie um programa de calculadora que solicite ao usuário dois números e execute operações de divisão, capturando exceções que possam ocorrer durante a entrada do usuário e durante a operação de divisão.

Instruções:

Crie um método que leia dois números do usuário.
Implemente a divisão dos dois números em um método separado.
Capture exceções como FormatException (entrada inválida), DivideByZeroException (divisão por zero), e OverflowException (números muito grandes ou muito pequenos).
Forneça mensagens de erro úteis para cada tipo de exceção.
*/
using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        int num1 = 0, num2 = 0;
        bool validInput = false;

        while(!validInput)
        {
            validInput = CollectNumber(ref num1, ref num2);
        }
        
        CalculateAndPrintResult(num1, num2);
    }
    public static bool CollectNumber(ref int num1, ref int num2)
    {
      try{
          Console.WriteLine("Digite o primeiro número: ");
            num1 = int.Parse(Console.ReadLine());

          Console.WriteLine("Digite o segundo número: ");
            num2 = int.Parse(Console.ReadLine());

          return true;
      }
        catch(FormatException)
        {
            Console.WriteLine("Erro no formato!! Digite um numero, por favor");
        }
        catch(OverflowException)
        {
            Console.WriteLine("Erro de Overflow!! Digite um numero menor que 2147483647 e maior que -2147483648");
        }

        return false;
    }
    public static void CalculateAndPrintResult(int num1, int num2)
    {
        try{
           int result = (num1 / num2);
            Console.WriteLine($"Resultado da divisão: {result}");
        }
        catch(DivideByZeroException)
        {
            Console.WriteLine("Erro de divisão por zero!! Não é possivel divir por zero");
        }
    }
}

