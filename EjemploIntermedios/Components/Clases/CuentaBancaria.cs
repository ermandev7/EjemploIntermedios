using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploIntermedios.Components.Clases
{
    public class CuentaBancaria
    {
        private double saldo;
        public double Saldo 
        {  
            get { return saldo; } 
            set { if(value >= 5) saldo = value; } 
        }
    }
}
