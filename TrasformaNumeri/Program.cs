using System;
using System.Collections.Generic;

public class Program
{
    public static string TrasformaNumeri(List<int> numeri)
    {
        List<string> numeriTrasformati = new List<string>();

        foreach (int numero in numeri)
        {
            if (int.IsPositive(numero))
            {
                int radiceQuadrataArrotondata = (int)Math.Round(Math.Sqrt(numero));
                numeriTrasformati.Add(radiceQuadrataArrotondata.ToString());
            }
            else if (int.IsNegative(numero))
            {
                int valoreAssolutoMoltiplicato = (Math.Abs(numero))*2;
                numeriTrasformati.Add(valoreAssolutoMoltiplicato.ToString());
            }
        }

        numeriTrasformati.Reverse();

        string risultato = string.Join("", numeriTrasformati);
        return risultato;
    }

    public static void Main()
    {
        List<int> numeri = new List<int> { 9, -4, 16, -1, 25 };
        string risultato = TrasformaNumeri(numeri);
        Console.WriteLine("La stringa risultante è: " + risultato);
    }
}
