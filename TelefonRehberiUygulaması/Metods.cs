using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonRehberi
{
    public class Metods
    {
        public bool CheckTheNumber(string a)
        {
            int b;
            return int.TryParse(a, out b);
        }

        public void AddNewNumber()
        {

        }
    }
}
