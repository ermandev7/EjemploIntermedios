using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploIntermedios.Components.Clases
{
    internal interface IVehiculo
    {
        string ArrancarMotor();
        string DetenerMotor();
    }
    public class Coche : IVehiculo
    {
        public delegate void ManejadorMotor();
        public event ManejadorMotor MotorArrancado;
        public event ManejadorMotor MotorDetenido;
        public string ArrancarMotor()
        {
            return "Motor del coche arrancado.";
        }
        public string DetenerMotor()
        {
            return "Motor del coche detenido.";
        }
        protected virtual void OnMotorArrancado()
        {
            MotorArrancado?.Invoke();
        }
        protected virtual void OnMotorDetenido()
        {
            MotorDetenido?.Invoke();
        }
    }
}
