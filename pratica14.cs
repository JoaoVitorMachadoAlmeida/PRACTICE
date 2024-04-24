using System;
    class HelloWorld {
    static void Main() {

    int [] num = new int[5] {12,33,44,55,26,};

    /*for(int i = 0;i < num.Length;i++ ){
    Console.WriteLine(num[i]);
    }*/
    foreach(int n in num){
    Console.WriteLine(n);
    }
  }
}