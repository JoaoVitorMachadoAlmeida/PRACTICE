using System;

class HelloWorld {
    static void Main() {
        Estudantes[] vect = new Estudantes[10];
        
        Console.WriteLine("Quantos quartos serão alugados?");
        int n = int.Parse(Console.ReadLine());
        
        for (int i = 0; i < n; i++) {
            Console.WriteLine();
            Console.WriteLine($"Aluguel #{i + 1}");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Quarto: ");
            int quarto = int.Parse(Console.ReadLine());
            if (quarto >= 0 && quarto < 10) { 
                vect[quarto] = new Estudantes(nome, email);
            } else {
                Console.WriteLine("Número de quarto inválido. Por favor, insira um número de 0 a 9.");
               
            }
        }
        
        Console.WriteLine();
        Console.WriteLine("Quartos ocupados: ");
        for (int i = 0; i < vect.Length; i++) { 
            if (vect[i] != null)
                Console.WriteLine(i + ": " + vect[i]);
        }
    }
    
    public class Estudantes {
        public string Nome { get; set; }
        public string Email { get; set; }
        
        public Estudantes(string nome, string email) {
            Nome = nome;
            Email = email;
        }
        
        public override string ToString() {
            return Nome + ", " + Email;
        }
    }
}
