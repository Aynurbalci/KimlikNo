using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kimliknoString
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                kimlik kimlik = new kimlik();
                Console.WriteLine("kimlik numaranızı giriniz");

                kimlik.MyTC = Convert.ToString(Console.ReadLine());
                Console.WriteLine("tc nonuzun ilk beş hanesi:" + kimlik.MyTC);
                

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);

            }
            Console.ReadKey();
        }
    }
}
