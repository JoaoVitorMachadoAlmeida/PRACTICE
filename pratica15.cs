using System;
    class HelloWorld {
    static void Main() {
    string senha = "123";
    string senhausuario;
    int tentativas = 0;
    do{
    Console.Clear(); // Limpar o console
    Console.WriteLine("Digite a senha");
    senhausuario = Console.ReadLine();
    tentativas++;
        }while(senhausuario != senha);
    Console.Clear();
    Console.WriteLine("Parabens, senha correta\nNumero de tentativas: {0}",tentativas);
    }
}