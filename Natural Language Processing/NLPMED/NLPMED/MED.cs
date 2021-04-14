using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Drawing;

namespace NLPMED
{
    class MED
    {
        public List<Point> operationIndexes = new List<Point>();
        private List<Word> wordDictionary;
        public MED(string dictionaryFilePath)
        {
            string[] readedWords = File.ReadAllLines(dictionaryFilePath, Encoding.GetEncoding("iso-8859-9"));
            this.wordDictionary = new List<Word>();
            for (int i = 0; i < readedWords.Length; i++)
            {
                wordDictionary.Add(new Word(readedWords[i], 0));
            }
        }
        public List<Word> FindAlternates(string word)
        {
            List<Word> alternateWords = new List<Word>();

            for (int i = 0; i < wordDictionary.Count; i++)
            {
                
                wordDictionary[i].cost = EditDist(wordDictionary[i].str, word, wordDictionary[i].str.Length, word.Length);
            }
            
            List<Word> temp = wordDictionary.OrderBy(x => x.cost).ToList<Word>();
            
            alternateWords.Add(temp[0]);
            alternateWords.Add(temp[1]);
            alternateWords.Add(temp[2]);
            alternateWords.Add(temp[3]);
            alternateWords.Add(temp[4]);
            alternateWords.Add(temp[5]);

            return alternateWords;
        }
        static public int EditDist(string str1, string str2, int m, int n)
        {
            if (m == 0)
            {
                return n;
            }

            if (n == 0)
            {
                return m;
            }


            if (str1[m - 1] == str2[n - 1])
                return EditDist(str1, str2, m - 1, n - 1);

            return 1 + Min(EditDist(str1, str2, m, n - 1), // Insert 
                           EditDist(str1, str2, m - 1, n), // Remove 
                           EditDist(str1, str2, m - 1, n - 1) // Replace 
                           );
        }
        private int[,] FindMEDValues(string str1, string str2)
        {
            int minIndex;
            str1 = str1.ToLower();
            str2 = str2.ToLower();

            int[,] medValues = new int[str1.Length+1,str2.Length+1];

            for(int i = 0; i < str2.Length + 1; i++)
            {
                medValues[0, i] = i;
            }

            for (int i = 0; i < str1.Length + 1; i++)
            {
                medValues[i, 0] = i;
            }

            for (int i = 0; i < str1.Length; i++)
            {
                for (int j = 0; j < str2.Length; j++)
                {
                    if (str1[i] != str2[j])
                    {
                        medValues[i + 1, j + 1] = Min(medValues[i, j], medValues[i, j + 1], medValues[i + 1, j]) + 1;
                    }
                    else
                    {
                        medValues[i + 1, j + 1] = medValues[i, j];
                    }
                }
            }
            return medValues;
        }
        public string[,] GenerateGridData(string source, string target)
        {
            string headerStr = " #" + target;
            string str2 = " #" + source;

            string[,] gridData = new string[str2.Length, headerStr.Length];

            for (int i = 0; i < headerStr.Length; i++)
            {
                gridData[0, i] = headerStr[i].ToString();
            }

            for (int i = 0; i < str2.Length; i++)
            {
                gridData[i, 0] = str2[i].ToString();
            }

            int[,] medValues = FindMEDValues(source, target);

            int height = medValues.GetLength(0) + 1;
            int width = medValues.GetLength(1) + 1;

            for (int i = 0; i < medValues.GetLength(0); i++)
            {
                for (int j = 0; j < medValues.GetLength(1); j++)
                {
                    gridData[i + 1, j + 1] = medValues[i, j].ToString();
                }
            }
            return gridData;
        }
        static int MinIndex(int x, int y, int z)
        {
            if (x <= y && x <= z)
                return 0;
            if (y <= x && y <= z)
                return 1;
            else
                return 2;
        }
        static int Min(int x, int y, int z)
        {
            if (x <= y && x <= z)
                return x;
            if (y <= x && y <= z)
                return y;
            else
                return z;
        }
        public List<string> FindOperations(string[,] data)
        {            
            List<string> operations = new List<string>();
            

            int i = data.GetLength(0) - 1;
            int j = data.GetLength(1) - 1; ;

            int minIndex;
            
            // source data[i, 0]
            // target data[0, j]

            // 1 2 controls sequence
            // 0

            while(i > 1 && j > 1)
            {
                minIndex = MinIndex(Convert.ToInt32(data[i, j - 1]), Convert.ToInt32(data[i - 1, j - 1]), Convert.ToInt32(data[i - 1, j]));
                operationIndexes.Add(new Point(i, j));
                if (data[i,0] == data[0, j])
                {
                    i--;
                    j--;
                }
                else
                {
                    if (minIndex == 0)
                    {
                        operations.Add("insert " + data[0, j]);
                        j--;
                    }
                    else if (minIndex == 1)
                    {
                        operations.Add("replace " + data[i, 0] + " by " + data[0, j]);
                        i--;
                        j--;
                    }
                    else if (minIndex == 2)
                    {
                        operations.Add("delete " + data[i, 0]);
                        i--;
                    }
                    else { }

                    
                }
            }
            operations.Reverse();
            return operations;
        }
    }
}
