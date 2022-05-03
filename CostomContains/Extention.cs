using System;
using System.Collections.Generic;
using System.Text;

namespace CostomContains
{
   public static class Extention
    {
        public static bool MyCostomContains(this string sentence, string part)
        {
            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i]== part[0])
                {
                    for (int j = 0; j < part.Length; j++)
                    {
                        if (part[j]!=sentence[i+j])
                        {
                            break;
                        }
                        if (j==part.Length-1)
                        {
                            return true;
                        }
                
                    }
                }
            }
            return false;
        }
    }
}
