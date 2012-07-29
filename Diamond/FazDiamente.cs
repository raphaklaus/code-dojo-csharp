using System;
using System.Text;


namespace CodeDojoDiamond
{
    class DoDiamond
    {
        String[] Alphabet = 
        {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"
        };

        public string Process(string param1)
        {
            int max;
            max = Array.IndexOf(Alphabet, param1);
            

            StringBuilder txt = new StringBuilder();
            int countOuterSpaces = max;
            int countInnerSpaces = -1;

                for (int i = 0; i < max; i++)
                {
                    
                    
                    txt.Append(doSpace(countOuterSpaces, " "));

                    if (i == 0)
                        txt.Append(Alphabet[i]);
                    else
                    {
                        txt.Append(Alphabet[i]);
                        txt.Append(doSpace(countInnerSpaces, " "));
                        txt.Append(Alphabet[i]);                
                    }
                
                    txt.AppendLine();
                    countOuterSpaces -= 1;
                    countInnerSpaces += 2;
                }


                for (int j = max; j >= 0; j--)
                {
                    txt.Append(doSpace(countOuterSpaces, " "));

                    if (j == 0)
                        txt.Append(Alphabet[j]);
                    else
                    {
                        txt.Append(Alphabet[j]);
                        txt.Append(doSpace(countInnerSpaces, " "));
                        txt.Append(Alphabet[j]);
                    }


                    txt.AppendLine();
                    countOuterSpaces += 1;
                    countInnerSpaces -= 2;
                    
                }
           
            return txt.ToString();
        }

        public string doSpace(int param1, string param2)
        {
            string sEspaco = "";
            
            for (int i = 0; i < param1; i++)
            {
                sEspaco += param2;    
            }

            return sEspaco;

        }

    }
}
