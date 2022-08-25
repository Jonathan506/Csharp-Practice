﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Vehiculo
{
    class Coche:Vehiculo
    {
        public void Acelerar() => Console.WriteLine("Acelerando");

        public void Frenar () => Console.WriteLine("Frenando");

        public override void Conducir()
        {
            base.Conducir();
        }
    }
}
