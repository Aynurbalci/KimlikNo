using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KimlikNo
{
    class Kimlik
    {
        private ulong TC;
   
        public ulong MyTC
        {
            set {

                if (value.ToString().Length == 11)
                {
                    TC = value;
                }
                else
                {
                    Console.WriteLine("Tc no 11 haneli olmalıdır");
                }
               }
            get {
                string cut = Convert.ToString(TC);
                cut=cut.Substring(0, 5);
                TC = Convert.ToUInt64(cut);
                return TC; }
        }
    }
}
