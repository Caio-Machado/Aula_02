using System;

class MainClass {

  //Função Print
  public static void Exibestr () {
    Console.WriteLine ("Teste 1");
  }

  //Função print Soma
  public static int SomaNum () {
    Console.WriteLine (1 + 1);
    return 0;
  }

  //Função Input
  public static void ExibeNum (int num) {
    Console.WriteLine ("O número infornado foi {0}: ", num);
  }

  //Main
  public static void Main () {
    Exibestr ();

    SomaNum ();

    int num;
    num = int.Parse(Console.ReadLine());
    ExibeNum (num);
  }
}