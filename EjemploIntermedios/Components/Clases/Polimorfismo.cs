using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploIntermedios.Components.Clases
{
    // Clase BAse
    public class Animales
    {
        public virtual string HacerSonido()
        {
            return "El animal hace un sonido.";
        }
        public virtual string Moverse()
        {
            return "El animal se está moviendo.";
        }

        // Función propia de la clase base
        public string Dormir()
        {
            return "El animal está durmiendo.";
        }
    }
    public class Perros : Animales
    {
        public override string HacerSonido()
        {
            return "El perro ladra.";
        }
        public override string Moverse()
        {
            return "El perro está corriendo.";
        }

        // Función propia de la clase Perros
        public string Jugar()
        {
            return "El perro está jugando con una pelota.";
        }
    }
    public class Gatos : Animales
    {
        public override string HacerSonido()
        {
            return "El gato maúlla.";
        }

        public override string Moverse()
        {
            return "El gato está caminando sigilosamente.";
        }

        // Función propia de la clase Gatos
        public string Cazar()
        {
            return "El gato está cazando un ratón.";
        }
    }
}
