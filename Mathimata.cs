using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
namespace winphonesqlite
{
    class Mathimata
    {
        [PrimaryKey, AutoIncrement]

        public int id_mathimata { get; set; }
        public int id_taksi { get; set; }
        public string onoma { get; set; }
        public int ores { get; set; }

      public Mathimata()
                {

                    }


      public Mathimata(int Id_taksi ,string Onoma , int Ores)
        {
            id_taksi = Id_taksi;
            onoma = Onoma;
            ores = Ores;
        }
    
    
    
    
    
    
    
    }
}
