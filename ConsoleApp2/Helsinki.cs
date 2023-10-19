using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Helsinki
    {
        public Helsinki(string r)
        {
            var v = r.Split(' ');
            this.helyezes = int.Parse(v[0]);
            this.sportolokszama = int.Parse(v[1]);
            this.sportag = v[2];
            this.versenyszam = v[3];
        }

        public int helyezes { get; set; }
        public int sportolokszama { get; set; }
        public string sportag { get; set; }
        public string versenyszam { get; set; }



    }
}
