using System;

namespace modul5
{
    internal class Program
    {
        static string[] SplitText(string Text)
        {
            string[] TextToMass = Text.Split(' ');
            return TextToMass;
        }
        static void OutputText(string[] LineText)
        {
            for(int i = 0; i < LineText.Length; i++)
            {
                Console.WriteLine($"{i+1,5} слово: {LineText[i]}");
            }                        
        }

        static void ReversWords(string inputPhrase)
        {
            string[] ReverseMass = SplitText(inputPhrase);    
            Console.Write("Предложение в обратном порядке: ");
            for (int i = ReverseMass.Length - 1; i >= 0; i--)
            {
                Console.Write($"{ReverseMass[i]} ");
            }
        }
        static void Main(string[] args)
        {
            //задание 1
            Console.WriteLine("задание 1");
            Console.Write("Введите предложение: ");
            string TextToSplit = Console.ReadLine();
            string[] OutputMass = SplitText(TextToSplit);
            OutputText(OutputMass);
            Console.ReadKey();

            //задание 2
            Console.WriteLine("\nзадание 2");
            Console.Write("Введите предложение: ");
            string TextToReverse = Console.ReadLine();
            ReversWords(TextToReverse);
            Console.ReadKey();
        }
    }
}
