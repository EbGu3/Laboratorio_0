using System.Collections.Generic;
using Laboratorio_0.Modelo;

namespace Laboratorio_0.Helpers
{
    public class DATA
    {
        private static DATA _instance;

        public static DATA Instance
        {
            get
            {
                if (_instance == null) _instance = new DATA();
                return _instance;
            }
        }

        public Stack<Peliculas> misPelis = new Stack<Peliculas>();
        
    }
}
