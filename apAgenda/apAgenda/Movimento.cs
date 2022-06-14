using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

     class Movimento : IComparable<Movimento>
     {
        private int origem, destino;

        public Movimento(int or, int dest)
        {
            origem = or;
            destino = dest;
        }

        public int CompareTo(Movimento outro)
        {
            return 0;
        }

        public int Origem { get => origem; set => origem = value; }
        public int Destino { get => destino; set => destino = value; }

        public override string ToString()
        {
            return origem + " " + destino;
        }
     }