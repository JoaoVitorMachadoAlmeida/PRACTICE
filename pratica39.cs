using System;
class HelloWorld
{
  static void Main ()
  {
	Console.WriteLine ("Quantas palavras deseja analisar?");
	int quantidade = int.Parse(Console.ReadLine ());

	  string[] palavras = new string[quantidade];

	for (int i = 0; i < quantidade; i++)
	  {
		Console.Write ($"Digite a palavra {i + 1} : ");
		palavras[i] = Console.ReadLine();
	  }
	  
	  VerificarPalindromos(palavras);
  }
  static bool EhPalindromo(string palavra){
      string palavraFormatada = palavra.Replace(" ", "").ToLower();
      char[]charArray = palavraFormatada.ToCharArray();
      Array.Reverse(charArray);
      string palavraReversa = new string(charArray);
      
      return palavraFormatada == palavraReversa;
      
  }
  
  static void VerificarPalindromos(string[] palavras){
      Console.WriteLine("Palindromos encontrados: ");
      
      foreach(string palavra in palavras){
          if (EhPalindromo(palavra)){
              Console.WriteLine(palavra);
          }
      }
  }
}
