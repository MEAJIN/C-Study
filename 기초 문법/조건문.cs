using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 씨샾겅부
{
    internal class 조건문
    {
        static bool verbose = false;
        static bool continueOnError = false;
        static bool logging = false;

        static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("Usage: MyApp.exe option");
                return;
            }

            string option = args[0];
            switch (option.ToLower())
            {
                case "/v":
                case "/verbose":
                    verbose = true;
                    Console.WriteLine("sadsad");
                    break;
                case "/c":
                    continueOnError = true;
                    break;
                case "/1":
                    logging = true;
                    break;
                default:
                    Console.WriteLine("Unknown argument: {0}", option);
                    break;
            }

            // ---------------------------------------------------------

            /*int i = 1;

            // do ~ while 루프
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i < 10);*/

            // ----------------------------------------------------------

            /* List<char> keyList = new List<char>();
             ConsoleKeyInfo key;
             do
             {
                 key = Console.ReadKey();
                 keyList.Add(key.KeyChar);
             } while (key.Key != ConsoleKey.Q); // Q가 아니면 계속

             Console.WriteLine();
             foreach (char ch in keyList) // 리스트 루프
             {
                 Console.Write(ch);
             }*/

        }
    }
}
