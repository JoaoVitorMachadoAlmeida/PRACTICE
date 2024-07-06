using System; // Importa o namespace System, necessário para usar a classe Console

class HelloWorld {
  static void Main() {
    int n = 4; // Declaração e inicialização da variável n com o valor 4
    int triplo; // Declaração da variável triplo, que será usada posteriormente

    // Chama o método Triplicar da classe Calculadora, passando n como parâmetro por referência
    // Isso significa que qualquer modificação feita em n dentro do método afetará a variável original
    Calculadora.Triplicar(ref n);

    // Chama o método Triple da classe Calculadora, passando n como parâmetro e triplo como um parâmetro de saída
    // Isso significa que o valor de triplo será definido dentro do método Triple
    Calculadora.Triple(n, out triplo);

    // Imprime o valor de n, que foi modificado pelo método Triplicar
    Console.WriteLine(n); // Saída: 12

    // Imprime o valor de triplo, que foi definido pelo método Triple
    Console.WriteLine(triplo); // Saída: 12
  }
}

class Calculadora {
    
    // Método que multiplica o valor do parâmetro x por 3
    // O uso de ref indica que x é passado por referência, ou seja, a variável original será modificada
    public static void Triplicar(ref int x) {
        x = x * 3;
    }
    
    // Método que multiplica o valor do parâmetro a por 3 e armazena o resultado no parâmetro de saída c
    // O uso de out indica que c é um parâmetro de saída, que deve ser definido dentro do método
    public static void Triple(int a, out int c) {
        c = a * 3;
    }
}
