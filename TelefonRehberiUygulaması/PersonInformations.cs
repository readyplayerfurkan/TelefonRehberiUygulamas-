using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonRehberi
{   
    public class PersonInformations
    {
        public string NameSurname { get; set; }
        
        public string Number { get; set; }

        public PersonInformations(string nameSurname, string number)
        {
            NameSurname = nameSurname;
            Number = number;
        }

        public PersonInformations()
        {

        }
    }   
}
