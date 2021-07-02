using System;

namespace MyFirstApp.Interfaces
{
    public class Avion : IVehiculo, ICloneable
    {
        public void Acelerar(int kmh)
        {
            Console.WriteLine("Acelerando vehículo");
        }

        public void Aterrizar()
        {
            throw new System.NotImplementedException();
        }

        public object Clone()
        {
            throw new NotImplementedException();
        }

        public void Despegar()
        {
            throw new System.NotImplementedException();
        }

        public void Frenar()
        {
            throw new System.NotImplementedException();
        }

        public void Girar(int angulos)
        {
            throw new System.NotImplementedException();
        }
    }
}
