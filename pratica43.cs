/******************************************************************************

Faça um programa que simule uma autenticação, pedindo ao
usuário o login e sua senha. Considere que o sistema será usado por
20 usuários e seus logins e senhas deverão ser sorteados por um
procedimento.

entrada: usuario e login
saida: se senha está correta ou não
procedimento: gerar login e senha
armazeanar em um array de 20 de tamanho
percorrer o array e gerar senha aleatoria

procedimento se é ou não igual
se vetor da posição i for diferente da senha de mesma posição, resultado é falso

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
    string[] usuario = new string[20];
    int[]senha = new int[20];
    
    GerarSenhaELogin(usuario,senha);
    
    Validacao(usuario,senha);
  }
  public static void GerarSenhaELogin(string[]usuario, int[]senha){
      Random r = new Random();
      for(int i = 0; i < usuario.Length; i++){
          usuario[i] = "Usuario" + (i + 1);
          senha[i] = r.Next(1000,9999);
      }
      for (int i = 0; i < usuario.Length; i++){
          Console.WriteLine($"{usuario[i]}\nSenha: {senha[i]}");
      }
  }
  public static void Validacao(string[] usuario, int[] senha){
  Console.WriteLine("Digite seu login: ");
  string login = Console.ReadLine();
  
  Console.WriteLine("Digite sua senha: ");
  int senhas = int.Parse(Console.ReadLine());
  
  bool autenticacao = false;
  
  for(int i = 0; i < usuario.Length; i++){
      if(usuario[i] == login && senha[i] == senhas){
          autenticacao = true;
          break;
         }
     }
     if(autenticacao){
         Console.WriteLine("Acesso validado");
     }else{
         Console.WriteLine("Login ou senha invalidos");
     }
  }
}
