using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace winphonesqlite
{
    class Programma
    {
    
    [PrimaryKey, AutoIncrement]
        public int id_programma { get; set; }
        public int id_daskaloi { get; set; }
        public int id_imeres { get; set; }
        public int  ora { get; set; }
        public int id_mathimata { get; set; }
        public int id_tmimata { get; set; }
        public int id_taksi { get; set; }

        public string onoma { get; set; }
        public Programma()
        {
            //empty constructor
        }
       
    
    
    
    
    
    
    }
}
