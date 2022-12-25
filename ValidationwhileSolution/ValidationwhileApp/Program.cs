internal class Program
{
    private static void Main(string[] args)
    {
        int a = Leer("Ingrese Valor1: ");
      int b = Leer("Ingrese Valor2: ");
      
      Console.WriteLine ("El valor de a:  "+ a);
      Console.WriteLine ("El valor de b:  "+ b);
      if (a>b)
        Console.WriteLine("a es mayor que b");
      else if (a<b)
        Console.WriteLine("a es menor que b");
      else if (a==b)
        Console.WriteLine("a es igual b");
    }

    public static int Leer(string mensaje)
  {
      int intentos = 0;
      Console.WriteLine(mensaje);
      while(intentos < 3)
      {    string numeroComoString = Console.ReadLine();
           int valorReal = 0;
           bool sePuedeConvertir=Int32.TryParse(numeroComoString, out valorReal);
        if(sePuedeConvertir)
        {
          return valorReal;
        }
        else
        {
         Console.WriteLine("valor ingresado invalido, intente de nuevo..."); 
          intentos++;
        }
      }
      return 0;
  }
}