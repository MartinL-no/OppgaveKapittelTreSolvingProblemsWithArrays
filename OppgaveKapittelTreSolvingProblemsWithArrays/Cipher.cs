using System;
namespace OppgaveKapittelTreSolvingProblemsWithArrays
{
    internal class Cipher
    {
        string Alphabet;
        string CurrentCipher;
        // Constructor if no cipher is passed in - generates random cipher
        public Cipher()
        {
            Alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            CurrentCipher = GetRandomizedCipher();
        }
        // Constructor if user wants to input cipher
        public Cipher(string cipher)
        {
            Alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            CurrentCipher = cipher;
        }
        private static string GetRandomizedCipher()
        {
            var random = new Random();
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var cipher = "";

            for (int i = 0; i < alphabet.Length; i++)
            {
                while (true)
                {
                    var randomCharacter = alphabet[random.Next(0, alphabet.Length)];

                    if (!cipher.Contains(randomCharacter))
                    {
                        cipher += randomCharacter;
                        break;
                    }
                }
            }
            return cipher;
        }
        public string Encrypt(string plainText)
        {
            string ciphertext = ConvertText(plainText, Alphabet, CurrentCipher);

            return ciphertext;
        }
        public string Decrypt(string ciphertext)
        {
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string cipher = "IJVWXKLMNOPABCDYZEFGHQRSTU";

            string plainText = ConvertText(ciphertext, CurrentCipher, Alphabet);

            return plainText;
        }
        private string ConvertText(string inputText, string inputCharacterMap, string outputCharacterMap)
        {
            string outputText = "";

            foreach (var character in inputText.ToUpperInvariant())
            {
                for (int i = 0; i < inputCharacterMap.Length; i++)
                {
                    if (character == inputCharacterMap[i]) outputText += outputCharacterMap[i];
                }
            }
            return outputText;
        }
    }
}

