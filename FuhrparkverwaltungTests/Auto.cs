using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuhrparkverwaltungTests
{
   public    class Auto
    {
        private int kilometerstand;
        
        public Auto(int kilomerterstand)
        {
            this.kilometerstand = kilomerterstand;
        }



        public int Kilometerstand
        {
         
            get
            {
                return kilometerstand;
            }
        }

        public void Fahren(int Streckeinkilometer)
        {
            kilometerstand+= Streckeinkilometer;
        }

    }
}
