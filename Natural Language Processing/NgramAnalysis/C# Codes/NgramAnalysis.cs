using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text.RegularExpressions;

namespace NLP_NGram
{
    class NgramAnalysis
    {
        // Converts input string to word list. Returns word list.
        public List<string> GenerateWordList(string text)
        {
            string replacedText = Regex.Replace(text, @"\t|\n|\r", "");
            replacedText = replacedText.ToLower();
            List<string> rawWords = replacedText.Split(new char[] { '.', ',', '!', '?', ';', ':', '(', ')', ' ', '"', '*', '+', '-', '/' }).ToList();
            List<string> words = new List<string>();

            foreach (string word in rawWords)
            {
                if (word.Length != 0)
                {
                    words.Add(word);
                }
            }
            return words;
        }
        // Writes given ngram dictionary to .txt file.
        public void DictionaryToTextFile(SortedDictionary<string, int> dictionary, string fileName)
        {
            StreamWriter file = new StreamWriter(fileName);
            foreach (KeyValuePair<string, int> kvp in dictionary.OrderByDescending(key => key.Value))
            {
                file.WriteLine(kvp.Key + "\t" + kvp.Value);
            }
        }
        // Generates all unigrams(1-gram) from given word list.
        public SortedDictionary<string, int> GenerateUnigram(List<string> words)
        {
            SortedDictionary<string, int> UniGramDic = new SortedDictionary<string, int>();
            List<string> searchedWords = new List<string>();

            int count = 0;
            searchedWords.Clear();

            for (int i = 0; i < words.Count; i++)
            {
                if (searchedWords.IndexOf(words[i]) == -1)
                {
                    searchedWords.Add(words[i]);

                    for (int j = 0; j < words.Count; j++)
                    {

                        if (words[i] == words[j])
                        {
                            count++;
                        }
                    }
                    //Console.WriteLine(words[i] + "\t: " + count);
                    UniGramDic.Add(words[i], count);
                    count = 0;
                }
            }

            return UniGramDic;
        }
        // Generates all bigrams(2-gram) from given word list.
        public SortedDictionary<string, int> GenerateBigram(List<string> words)
        {
            SortedDictionary<string, int> BiGramDic = new SortedDictionary<string, int>();
            List<string> searchedWords = new List<string>();

            int count = 0;
            searchedWords.Clear();

            for (int i = 0; i < words.Count - 2; i++)
            {

                if (searchedWords.IndexOf(words[i] + words[i + 1]) == -1)
                {
                    searchedWords.Add(words[i] + words[i + 1]);

                    for (int j = 0; j < words.Count - 2; j++)
                    {

                        if (words[i] == words[j] && words[i + 1] == words[j + 1])
                        {
                            count++;
                        }
                    }
                    //Console.WriteLine(words[i] + " " + words[i + 1] + "\t: " + count);
                    BiGramDic.Add(words[i] + " " + words[i + 1], count);
                    count = 0;
                }
            }

            return BiGramDic;
        }
        // Generates all trigrams(3-gram) from given word list.
        public SortedDictionary<string, int> GenerateTrigram(List<string> words)
        {
            SortedDictionary<string, int> TriGramDic = new SortedDictionary<string, int>();
            List<string> searchedWords = new List<string>();

            // 3-gram
            int count = 0;
            searchedWords.Clear();

            for (int i = 0; i < words.Count - 3; i++)
            {

                if (searchedWords.IndexOf(words[i] + words[i + 1] + words[i + 2]) == -1)
                {
                    searchedWords.Add(words[i] + words[i + 1] + words[i + 2]);

                    for (int j = 0; j < words.Count - 3; j++)
                    {

                        if (words[i] == words[j] && words[i + 1] == words[j + 1] && words[i + 2] == words[j + 2])
                        {
                            count++;
                        }
                    }
                    //Console.WriteLine(words[i] + " " + words[i + 1] + " " + words[i + 2] + "\t: " + count);
                    TriGramDic.Add(words[i] + " " + words[i + 1] + " " + words[i + 2], count);
                    count = 0;
                }
            }

            return TriGramDic;
        }
    }
}
