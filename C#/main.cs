using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Digite um numero");
    var x = float.Parse(Console.ReadLine()) ;
    Console.WriteLine ("Digite o segundo numero");
    var y = float.Parse(Console.ReadLine());

    int sum = (int)x + (int)y;
    
    Arrayde10(sum);
  }

  public static void Arrayde10 (int n) {
    int[] array = new int[10];
    for(int x = 0; x<10; x++){
      array[x] = n * x;
    }
    foreach(var item in array){
       Console.WriteLine (item);
    }
   
  }
 
}