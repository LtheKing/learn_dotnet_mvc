using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairOfSocks
{
    public class ListOfSocks
    {
        public ListOfSocks()
        {
        }

        public void DaftarKK(out string[] sock, out string[] merk)
        {
            sock = new String[] {
            "Kaos Kaki Putih",
            "Kaos Kaki Hitam",
            "Kaos Kaki IJO",
            };

            merk = new string[]
            {
                "Nike",
                "Adidas",
                "Puma"
            };
        }

        
    }
}
