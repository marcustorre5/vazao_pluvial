using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("\nCalculo de vazão para dimensionamento tubus agua pluviais\n");
      
      while (true){

        vazao();
        trecho_tubos();
        Console.WriteLine("\nReiniciando..\n");
        System.Threading.Thread.Sleep(3000);//sleep de 3 segundos

      }

    }

    static void vazao (){

        Console.WriteLine("Vazão\n");

        //Definindo área
        Console.WriteLine("Digite a área de cobertura do proejto");
        var areaStr = Console.ReadLine();
        double area = Convert.ToDouble(areaStr);
        Console.WriteLine("área da cobertura: " + area+"m²");
        
        //Definando quantidades de tubos
        if (area <= 199)
          Console.WriteLine("Será preciso 1 tubo de 100mm");
          int qnt_tubos = 1;

        if (area >= 200 && area <= 299)
          Console.WriteLine("Será preciso 2 tubo de 100mm");

        if (area >= 300 && area <= 399)
          Console.WriteLine("Será preciso 3 tubo de 100mm");  

        if (area >= 400 && area <= 499)
          Console.WriteLine("Será preciso 4 tubo de 100mm");  
          
        if (area >= 500 && area <= 599)
          Console.WriteLine("Será preciso 5 tubo de 100mm"); 

        if (area >= 600 && area <= 699)
          Console.WriteLine("Será preciso 6 tubo de 100mm"); 

        if (area >= 700 && area <= 799)
          Console.WriteLine("Será preciso 7 tubo de 100mm");

        if (area >= 800 && area <= 899)
          Console.WriteLine("Será preciso 8 tubo de 100mm");

        if (area >= 900 && area <= 999)
          Console.WriteLine("Será preciso 9 tubo de 100mm");

        if (area >= 1000 && area <= 1099)
          Console.WriteLine("Será preciso 10 tubo de 100mm");    

    }

    static void trecho_tubos(){

      Console.WriteLine("\nTrechos de tubos");

      //quantidades de tubos por trechos
      Console.WriteLine("quantos tubos de queda tem se encotra nesse no techo? ");
      var qnt_trechosStr = Console.ReadLine();
      double qnt_trechos = Convert.ToDouble(qnt_trechosStr);

      Console.WriteLine(qnt_trechos+" tubos que vão se encontrar no trecho");

      //Diametro dos tubos:

      //tubo de 100:
      var t100 = 0.0079;
      //tubo de 150:
      var t150 = 0.0177;
      //tubo de 200:
      var t200 = 0.0314;
      //tubo de 250:
      var t250 = 0.0491;
      //tubo de 300:
      var t300 = 0.0707;
      //tubo de 400:
      var t400 = 0.1256;

      //Calculo de diâmetro do trecho
      var calc_techos = qnt_trechos*t100;
      Console.WriteLine(calc_techos);

      if (calc_techos < t150)
        Console.WriteLine("Tubulação de 100mm");

      if (calc_techos > t150 && calc_techos <= t200)
        Console.WriteLine("Tubulação de 150mm");

      if (calc_techos > t200 && calc_techos <= t250)
        Console.WriteLine("Tubulação de 200mm");

      if (calc_techos > t250 && calc_techos <= t300)
        Console.WriteLine("Tubulação de 250mm");

      if (calc_techos > t300 && calc_techos <= t400)
        Console.WriteLine("Tubulação de 300mm");

      if (calc_techos > t400)
        Console.WriteLine("Tubulação de 400mm");

    }
  }
}