using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploIntermedios.Components.Clases
{
    //Herencia
    public class Animal
    {
        public string Caminar()
        {
            return "El animal está caminando.";
        }
        
    }
    public class Perro : Animal
    {
        public string Ladrar()
        {
           return "El perro está ladrando.";
        }
    }
     public class Gato : Animal
    {
        public string Maullar()
        {
            return "El gato está maullando.";
        }
    }
}
