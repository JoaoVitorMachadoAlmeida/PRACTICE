/******************************************************************************
Faça um programa que simule uma autenticação, pedindo ao
usuário o login e sua senha. Considere que o sistema será usado por
20 usuários e seus logins e senhas deverão ser sorteados por um
procedimento.
*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
    
    string[] usuario = new string [20];
    int[] senhas = new int[20];
    
    GerarSenhasELogin(usuario, senhas);
    
    AutenticacaoUsuario(usuario, senhas);
    
  }
  public static void GerarSenhasELogin(string[]usuarios, int[]senhas){
      Random r = new Random();
      
      for(int i = 0; i < usuarios.Length; i++){
          usuarios[i] = "user" + (i + 1);
          senhas[i] = r.Next(1000,9999);
      }
      
      Console.WriteLine("Usuarios e senhas sorteadas: ");
      for(int i = 0; i < usuarios.Length; i++){
          Console.WriteLine($"Usuario: {usuarios[i]}, Senhas: {senhas[i]}");
      }
  }
  
  public static void AutenticacaoUsuario(string[]usuarios, int[]senhas){
      Console.WriteLine("Digite seu login: ");
      string login = Console.ReadLine();
      
      Console.WriteLine("Digite sua senha: ");
      int senha = int.Parse(Console.ReadLine());
      
      bool autenticacao = false;
      for(int i = 0; i < usuarios.Length; i++){
          if(usuarios[i] == login && senhas[i] == senha){
              autenticacao = true;
              break;
          }
      }
      if(autenticacao){
          Console.WriteLine("Autenticação bem sucedida");
      }else{
          Console.WriteLine("Login ou senha incorretos, tente novamente");
      }
  }
}
