using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Diagnostics;

namespace NLP_NGram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("====== C# N-gram Implementation ======");
            // Stop watch to calculate execution time.
            Stopwatch watch = new Stopwatch();
            Stopwatch watch2 = new Stopwatch();

            // Impoerting N-gram analysis object to get functions.
            NgramAnalysis ngramAnalysis = new NgramAnalysis();

            // Reading all source .txt files. Put them all in one string variable.
            Console.WriteLine("Reading from texts...");
            string text = "";
            try
            {
                text = File.ReadAllText("BİLİM İŞ BAŞINDA.txt", Encoding.GetEncoding("iso-8859-9"));
                text += (" " + File.ReadAllText("BOZKIRDA.txt", Encoding.GetEncoding("iso-8859-9")));
                text += (" " + File.ReadAllText("DEĞİŞİM.txt", Encoding.GetEncoding("iso-8859-9")));
                text += (" " + File.ReadAllText("DENEMELER.txt", Encoding.GetEncoding("iso-8859-9")));
                text += (" " + File.ReadAllText("UNUTULMUŞ DİYARLAR.txt", Encoding.GetEncoding("iso-8859-9")));
                Console.WriteLine("Reading completed.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Reading failed. File not found.");
                Console.Read();
                Environment.Exit(-1);
            }

            // List that keeps all words from text carpus.
            List<string> words = ngramAnalysis.GenerateWordList(text);

            watch.Start();
            watch2.Start();
            Console.WriteLine("N-Gram Analysis started... This will take a moment...");
            // Creating N-gram dictionaries that keeps analysis results.
            SortedDictionary<string, int> UniGramDic = ngramAnalysis.GenerateUnigram(words);
            watch2.Stop();
            Console.WriteLine("Unigram Analysis completed. Elapsed Time : " + watch2.Elapsed + " Bigram Analysis started...");

            watch2.Reset();
            watch2.Start();
            SortedDictionary<string, int> BiGramDic = ngramAnalysis.GenerateBigram(words);
            watch2.Stop();
            Console.WriteLine("Bigram Analysis completed. Elapsed Time : " + watch2.Elapsed + " Trigram Analysis started...");

            watch2.Reset();
            watch2.Start();
            SortedDictionary<string, int> TriGramDic = ngramAnalysis.GenerateTrigram(words);
            watch2.Stop();
            Console.WriteLine("Trigram Analysis completed. Elapsed Time : " + watch2.Elapsed);

            Console.WriteLine("N-Gram Analysis completed.");
            watch.Stop();
            Console.WriteLine("Total Elapsed time : " + watch.Elapsed);

            // Writing all results to .txt file to see all analysis.
            Console.WriteLine("Writing results to text files...");
            ngramAnalysis.DictionaryToTextFile(UniGramDic, "C#-Results-Unigram.txt");
            ngramAnalysis.DictionaryToTextFile(BiGramDic, "C#-Results-Bigram.txt");
            ngramAnalysis.DictionaryToTextFile(TriGramDic, "C#-Results-Trigram.txt");
            Console.WriteLine("Writing Completed.");
            Console.WriteLine("Press enter to exit...");

            Console.Read();
        }
    }
}
