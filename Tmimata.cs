using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SQLite;
namespace winphonesqlite
{
    class Tmimata
    {
        [PrimaryKey, AutoIncrement]


        public int id_tmimata { get; set; }
      
        public string onoma { get; set; }

         public int id_taksi { get; set; }
         public string epitheto_daskalos{ get; set; }
         public string onoma_daskalos { get; set; }
         public string ImagePath { get; set; }
        public Tmimata()
        {

        }


      







    }
}
