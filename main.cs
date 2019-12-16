using System;

class MainClass {
  public static void Main (string[] args) {
    int x, y;

    Console.WriteLine("Informe dois números: ");

    x = int.Parse (Console.ReadLine());
    y = int.Parse (Console.ReadLine());

    while (x != y) {
      if (x <y){
        Console.WriteLine("Crescente");
      }
      else{
        Console.WriteLine ("Decrescente");
      }
    x = int.Parse (Console.ReadLine());
    y = int.Parse (Console.ReadLine());
    }

    
  }
}