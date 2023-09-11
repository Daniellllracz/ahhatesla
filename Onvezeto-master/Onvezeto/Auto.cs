using System;
using System.Collections.Generic;
using System.Text;

namespace Onvezeto
{
    class Auto
    {
        public string azonosito { get; set; }
        public int teljeseitmeny { get; set; }
        public double tomeg { get; set; }
        public int gyorsulas { get; set; }
        public int beavatkozas { get; set; }

        public Auto(string sor)
        {
            var darabok = sor.Split(';');
            this.azonosito = darabok[0];
            this.teljeseitmeny = int.Parse(darabok[1]);
            this.tomeg = double.Parse(darabok[2]);
            this.gyorsulas = int.Parse(darabok[3]);
            this.beavatkozas = int.Parse(darabok[4]);
        }
    }
}
