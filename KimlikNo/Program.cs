using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KimlikNo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Kimlik kimlik = new Kimlik();
                Console.WriteLine("kimlik numaranızı giriniz");

                kimlik.MyTC = Convert.ToUInt64(Console.ReadLine());
                Console.WriteLine("tc nonuzun ilk beş hanesi:" + kimlik.MyTC);
                Console.WriteLine("bu bir sayısal ifadedir 10+ tc :" + (11 + kimlik.MyTC));
                
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);

            }
            Console.ReadKey();
        }
    }
}
