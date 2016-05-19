using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace winphonesqlite
{


    
    class Daskaloi
    {
    
    [PrimaryKey, AutoIncrement]
        public int id { get; set; }
        public string onoma { get; set; }
        public string epitheto { get; set; }
        public string email { get; set; }
        public string eidikotita { get; set; }
        public string biografiko { get; set; }

        public string ImagePath { get; set; }
        public Daskaloi()
        {
            //empty constructor
        }
        public Daskaloi(string Onoma, string Epitheto, string Email , string Eidikotoita , string Biografiko , string imagePath )
        {
            onoma = Onoma;
            epitheto = Epitheto;
            email = Email;
            eidikotita = Eidikotoita;
            biografiko = Biografiko;
            ImagePath = imagePath;
        }
    
    
    
    
    
    
    
    }
}
