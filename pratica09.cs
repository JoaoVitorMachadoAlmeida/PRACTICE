using System;
class HelloWorld {
    static void Main() {
    int[] numero = new int [5];  //int[] num = new int[3]{55,33,44}; //ja declara os valores da variavel
    int[] num = {55,33,44}; // é a mesma coisa que o de cima, só que sem declarar o tamanho que vair ser o array
    numero[0] = 5; //declaradando cada valor para a variavel numero
    numero[1] = 45;
    numero[2] = 333;
    numero[3] = 2;
    numero[4] = 23;

        Console.WriteLine("O primeiro numero é : {0}\\no terceiro é:{1} ",numero[0],numero[2]);
        Console.WriteLine("O primeiro numero do segundo array é : {0}\\no terceiro é:{1} ",num[0],num[2]);
	}
}
