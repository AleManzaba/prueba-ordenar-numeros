using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese la cantidad de números que desea ordenar: ");
        int cantidadNumeros = Convert.ToInt32(Console.ReadLine());

        int[] numeros = new int[cantidadNumeros];

        Console.WriteLine("Ingrese los números:");
        LeerNumeros(numeros);

        OrdenarNumeros(numeros);

        ImprimirNumeros(numeros);

        Console.WriteLine("\nPresione cualquier tecla para salir.");
        Console.ReadKey();
    }

    static void LeerNumeros(int[] numeros)
    {
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write($"Número {i + 1}: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            numeros[i] = numero;
        }
    }

    static void OrdenarNumeros(int[] numeros)
    {
        for (int i = 0; i < numeros.Length - 1; i++)
        {
            for (int j = 0; j < numeros.Length - 1 - i; j++)
            {
                if (numeros[j] > numeros[j + 1])
                {
                    int temp = numeros[j];
                    numeros[j] = numeros[j + 1];
                    numeros[j + 1] = temp;
                }
            }
        }
    }

    static void ImprimirNumeros(int[] numeros)
    {
        Console.WriteLine("\nNúmeros ordenados:");
        foreach (int numero in numeros)
        {
            Console.Write(numero + " ");
        }
    }
}