using System;
using System.ComponentModel;

namespace OppgaveKapittelTreSolvingProblemsWithArrays;
class Program
{
    static void Main(string[] args)
    {
        /*
         * Oppgave 3-3
         */
        var sortedArray = new int[] { 1, 2, 3 };
        var unSortedArray = new int[] { 16, 222, 3, 44 };
        var arrayIsSorted = Sorter.IsSorted(unSortedArray, 3);

        Console.WriteLine("Sorting exercise:");
        Console.WriteLine($"int[] {{ 1, 2, 3 }} is a sorted array = {Sorter.IsSorted(sortedArray,3)}");
        Console.WriteLine($"int[] {{ 16, 222, 3, 44 }} is a sorted array = {Sorter.IsSorted(unSortedArray, 4)}");
        Console.WriteLine();

        /*
         * Oppgave 3-4 & 3-5
         */
        var userCipher = new Cipher("IJVWXKLMNOPABCDYZEFGHQRSTU");

        Console.WriteLine("Cipher exercises:");
        Console.WriteLine($"The encryption of GETACADEMY is: {userCipher.Encrypt("GETACADEMY")}");
        Console.WriteLine($"The decryption of LXGIVIWXBT is: {userCipher.Decrypt("LXGIVIWXBT")}");

        /*
         * Oppgave 3-6
         */
        var randomizedCipherOne = new Cipher();
        var randomizedCipherTwo = new Cipher();
        Console.WriteLine($"First randomized cipher of GETACADEMY: {randomizedCipherOne.Encrypt("GETACADEMY")}");
        Console.WriteLine($"Second randomized cipher of GETACADEMY: {randomizedCipherTwo.Encrypt("GETACADEMY")}");
        Console.WriteLine();

        /*
         * Oppgave 3-7
         */
        Console.WriteLine("Mode Exercise:");
        Mode(new int[] { 2, 5, 7, 4, 2, 4, 2, 2,4,4,4,4,4 });
    }
    static void Mode(int[] intArray)
    {
        var maxIndex = intArray.Max(x => x) + 1;
        var amountOfEachNumbersArray = new int[maxIndex];
        int mode = 0;
        int maxInstances = 0;

        foreach (var number in intArray)
        {
            amountOfEachNumbersArray[number]++;

            if (amountOfEachNumbersArray[number] > maxInstances)
            {
                mode = number;
                maxInstances = amountOfEachNumbersArray[number];
            }
        }

        Console.WriteLine($"The mode is {mode}");
    }
}