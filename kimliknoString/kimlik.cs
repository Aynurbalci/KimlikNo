using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kimliknoString
{
    class kimlik
    {
        private string TC;

        public string MyTC
        {
           
            set
            {
                bool control = false;
                if (value.Length == 11)
                {
                    for(int i = 0; i < value.Length; i++)
                    {
                        bool input = char.IsNumber(value[i]);
                        if (input==false)
                        {
                            control = true;
                            break;
                        }
                     

                    }
                    if (control)
                    {
                        Console.WriteLine("sadece sayı giriniz");
                    }
                    else
                    {
                        TC = value;
                    }
                }
                else
                {
                    Console.WriteLine("lütfen 11 rakamlı sayı giriniz");
                }

               

             

            }
            get
            {


                return TC.Substring(0, 5);
            }





        }
    }
}
