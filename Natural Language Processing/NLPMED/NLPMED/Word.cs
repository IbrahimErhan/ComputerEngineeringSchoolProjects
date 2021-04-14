using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLPMED
{
    class Word
    {
        public int cost;
        public string str;

        public Word(string str, int cost)
        {
            this.cost = cost;
            this.str = str;
        }
        public Word()
        {
            this.cost = 0;
            this.str = "";
        }
    }
}
