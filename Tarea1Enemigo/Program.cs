using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tarea1Enemigo
{
    class Program
    {
        static void Main(string[] args)
        {
            Enemigo enemigo1 = new Enemigo();
            enemigo1.posicionX = "15";
            enemigo1.posicionY = "20";
            enemigo1.xp = "250";
            enemigo1.movimiento = "derecha";
            enemigo1.disparos = "4";
            enemigo1.explotar = "grande";
        }
    }
}
