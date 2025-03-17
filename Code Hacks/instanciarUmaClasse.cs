using System;

public class Calculadora
{
    public int Soma(int x, int y)
    {
        int resultado = x + y;
        return resultado;
    }
}

public class Master
{
     public static void Main()
     {
        int x = 5;
        int y = 3;
        
        // Criando uma instância da classe Calculadora
        Calculadora calc = new Calculadora();
    
        int resultado;
    
        resultado = calc.Soma(x,y);
    
        Console.WriteLine("O resultado da soma é" + resultado);
     }
}
