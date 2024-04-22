  using System;
class HelloWorld {
static void Main() {
int[,] n = new int[3,5];
int[,] n1 = new int[2,2]{{10,20},{30,40}};
  n[0,0] = 10;
  n[0,1] = 22;
  n[0,2] = 21;
  n[0,3] = 13;
  n[0,4] = 65;

  n[1,0] = 11;
  n[1,1] = 25;
  n[1,2] = 14;
  n[1,3] = 12;
  n[1,4] = 64;

  n[2,0] = 17;
  n[2,1] = 65;
  n[2,2] = 54;
  n[2,3] = 72;
  n[2,4] = 34;

  Console.WriteLine(n[1,1]);
  Console.WriteLine(n1[0,0]);
	}
}	