using System;
class HelloWorld {
  static void Main() {
    
    
    string original = "abcds FGRS ABC abc DEFG  ";
    
    string s1 = original.ToUpper(); // deixar tudo em letra maiuscula
    string s2 = original.ToLower(); //deixar tudo em letra minuscula
    string s3 = original.Trim(); //tirar os espaços em branco
    
    int n1 = original.IndexOf("bc"); //procura em que posição da string contem a palavra "bc"
    int n2 = original.LastIndexOf("bc"); //procura a ultima posição com ocorrencia da palavra descrita
    
    string s4 = original.Substring(3); // corta a string de acordo com o indicie selecionado
    string s5 = original.Substring(3,5); // ele corta e mostra 5 caracteres apartir da posição 3
    
    string s6 = original.Replace('a', 'x'); // ele altera todo caracterer 'a' pelo 'x'
    string s7 = original.Replace("abc", "xy");
    
    bool b1 = String.IsNullOrEmpty(original); //verifica se a string está vazia ou não
    bool b2 = String.IsNullOrWhiteSpace(original); //verifica se está vazia ou se tem só um monte de espaço em branco
    
    Console.WriteLine("Original: -" + original + "-");
    Console.WriteLine("ToUpper: -"+ s1 +"-");
    Console.WriteLine("ToLower: -"+ s2 +"-");
    Console.WriteLine("Trim: -"+ s3 +"-");
    Console.WriteLine("IndexOf('bc'): "+ n1 );
    Console.WriteLine("LastIndexOf('bc'): "+ n2);
    Console.WriteLine("Substring(3): -"+ s4+ "-");
    Console.WriteLine("Substring(3,5): -"+ s5+ "-");
    Console.WriteLine("Replace(a,x): -"+ s6+ "-");
    Console.WriteLine("Replace(abc, xy): -"+ s7+ "-");
    Console.WriteLine("IsNullOrEmpty: "+ b1);
     Console.WriteLine("IsNullOrWhiteSpace: "+ b2);
  }
}
