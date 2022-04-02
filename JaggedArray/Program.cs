using System;

namespace JaggedArray
{
    class Program
    {
        static void Main(string[] args)       
        {
           
            string initialText = "nrtyu cvhk. fghk hjkl rtyui. fgyuio fghj";

            string[] sentences = initialText.Split('.');

            string[][] textArray = new string[sentences.Length][];

            for (int i = 0; i < textArray.Length; i++)
            {
                string[] words = sentences[i].Split(' ');
                              
                textArray[i] = words;
            }           

            for (int i = 0; i < textArray.Length; i++)
            {
                for (int j = 0; j < textArray[i].Length; j++)
                {
                   Console.Write(textArray[i][j]+ " ");
                }
                Console.WriteLine();
            }
        }
    }
}
