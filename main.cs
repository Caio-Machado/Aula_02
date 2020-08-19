using System;

class MainClass {

  //Função Print / Exercício 01
  public static void Exibestr () {
    Console.WriteLine ("Hello World");
  }

  //Função print Soma / Teste
  public static int SomaNum () {
    Console.WriteLine (1 + 1);
    return 0;
  }

  //Função Input / Exercício 02
  public static void ExibeNum (int num) {
    Console.WriteLine ("O número infornado foi {0}: ", num);
  }

  //Função Soma números / Exercício 03
  public static void SomaNum (int num1, int num2) {
    Console.WriteLine ("A soma dos números infornados é {0}", num1 + num2);
  }

  //Função Média / Exercício 04
  public static void Media (int nota1, int nota2, int nota3, int nota4) {
    Console.WriteLine ("A Média das notas informadas é {0}", (nota1 + nota2 + nota3 + nota4) / 4);
  }

  //Main
  public static void Main () {
    //EX 01
    Exibestr ();

    // Teste
    SomaNum ();

    //ExibeNum EX 02
    int num;
    Console.WriteLine ("Digite um número!");
    num = int.Parse (Console.ReadLine ());

    ExibeNum (num);

    //SomaNum EX 03
    int num1, num2;
    Console.WriteLine ("Digite o primeiro número!");
    num1 = int.Parse (Console.ReadLine ());

    Console.WriteLine ("Digie o segundo número!");
    num2 = int.Parse (Console.ReadLine ());

    SomaNum (num1, num2);

    //Media EX 04
    int nota1, nota2, nota3, nota4;
    Console.WriteLine ("Digite a primeira nota!");
    nota1 = int.Parse (Console.ReadLine ());

    Console.WriteLine ("Digite a segunda nota!");
    nota2 = int.Parse (Console.ReadLine ());

    Console.WriteLine ("Digíte a terceira nota!");
    nota3 = int.Parse (Console.ReadLine ());

    Console.WriteLine ("Digite a quarta nota!");
    nota4 = int.Parse (Console.ReadLine ());

    Media (nota1, nota2, nota3, nota4);

  }
}
