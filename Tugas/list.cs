using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas
{
    public class Daftar
    {
        public List<variabel> variabels;

        public Daftar()
        {
            variabels = new List<variabel>();
        }
        public void Add(variabel Variabel)
        {
            variabels.Add(Variabel);
        }
        public void Print()
        {
            foreach (var Variabel in variabels)
            {
                Variabel.TampilkanInfoTugas();
            }
        }
    }
}
