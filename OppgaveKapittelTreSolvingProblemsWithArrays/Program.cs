using System;

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
        var arrayIsSorted = OppgaveTre(unSortedArray, 3);

        Console.WriteLine("Sorting exercise:");
        Console.WriteLine($"int[] {{ 1, 2, 3 }} is a sorted array = {OppgaveTre(sortedArray,3)}");
        Console.WriteLine($"int[] {{ 16, 222, 3, 44 }} is a sorted array = {OppgaveTre(unSortedArray, 4)}");
        Console.WriteLine();

        /*
         * Oppgave 3-4 & 3-5
         */
        var UserCipher = new Cipher("IJVWXKLMNOPABCDYZEFGHQRSTU");

        Console.WriteLine("Cipher exercises:");
        Console.WriteLine($"The encryption of GETACADEMY is: {UserCipher.Encrypt("GETACADEMY")}");
        Console.WriteLine($"The decryption of LXGIVIWXBT is: {UserCipher.Decrypt("LXGIVIWXBT")}");
        /*
         * Oppgave 3-6
         */
        var RandomizedCipherOne = new Cipher();
        var RandomizedCipherTwo = new Cipher();
        Console.WriteLine($"First randomized cipher of GETACADEMY: {RandomizedCipherOne.Encrypt("GETACADEMY")}");
        Console.WriteLine($"Second randomized cipher of GETACADEMY: {RandomizedCipherTwo.Encrypt("GETACADEMY")}");
    }
    
    static bool OppgaveTre(int[] array, int numberOfElements)
    {
        /*
         * 3-3 Write a bool function that is passed an array and the number of elements in
         * that array and determines whether the data in the array is sorted. This should
         * require only one pass!
         */

        int start = 0;
        int end = numberOfElements - 1;
        for (int i = start + 1; i <= end; i++)
        {
            for (int j = i; j > start && array[j - 1] > array[j]; j--)
            {
                int temp = array[j - 1];
                array[j - 1] = array[j];
                array[j] = temp;

                return false;
            }
        }
        return true;
    }
}