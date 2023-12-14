using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountWordsInAString
{
    public class CountWords
    {
        int count = 1;
        public void counts(string words)
        {
            for(int i=0;i<=words.Length-1;i++)
            {
                if (words[i]==' ' || words[i]=='\t' || words[i]=='\n')
                { 
                    count=count+1;
                }
            }

            Console.WriteLine(count);
        }
    }
}
