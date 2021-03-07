using System;

namespace CaesarCipher
{
    public static class CipherUI
    {
        public static void AppStart()
        {
            string menuOption;
            do
            {
                menuOption = AppMenu();

                switch (menuOption)
                {
                    case "encrypt":
                        Encrypt();
                        break;

                    case "decrypt":
                        Decrypt();
                        break;
                }
            } while (menuOption != "exit");
        }

        private static string AppMenu()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine(String.Format("{0,20}", "Ceasar Cipher"));
            Console.WriteLine("------------------------------");
            Console.WriteLine(" Encrypt  |  Decrypt  |  Exit");
            Console.WriteLine("------------------------------");
            Console.WriteLine(String.Format("{0,26}", "Type Your option below:"));
            Console.WriteLine("------------------------------");
            string menuOption = Console.ReadLine().ToLower();
            return menuOption;
        }

        private static void Encrypt()
        {
            Console.WriteLine(String.Format("{0,20}", "Enter Encrypt Key:"));
            int cipher;

            if (!int.TryParse(Console.ReadLine(), out cipher))
            {
                Console.WriteLine(String.Format("{0,21}", "Ivalid Cipher Key!"));
                return;
            }

            Console.WriteLine(String.Format("{0,21}", "Enter text to Encrypt:"));
            string text = Console.ReadLine();

            if (text.Length == 0)
            {
                Console.WriteLine(String.Format("{0,20}", "Ivalid Input Text!"));
                return;
            }
            Console.WriteLine("..............................");
            Console.WriteLine("Encrypted text: " + CipherService.Encrypt(text, cipher));
        }

        private static void Decrypt()
        {
            Console.WriteLine(String.Format("{0,21}", "Enter Decrypt Key:"));
            int cipher;

            if (!int.TryParse(Console.ReadLine(), out cipher))
            {
                Console.WriteLine(String.Format("{0,21}", "Ivalid Cipher Key!"));
                return;
            }

            Console.WriteLine(String.Format("{0,21}", "Enter text to Decrypt:"));
            string text = Console.ReadLine();

            if (text.Length == 0)
            {
                Console.WriteLine(String.Format("{0,20}", "Ivalid Input Text!"));
                return;
            }
            Console.WriteLine("...........................");
            Console.WriteLine("Decrypted text: " + CipherService.Decrypt(text, cipher));
        }
    }
}