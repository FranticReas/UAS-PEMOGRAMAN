using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas
{
    public class status//Polimorfisme
    {
        public virtual void Status()
        {
            Console.Write("Status Tugas");
        }
    }

    public class selesai : status
    {
        public override void Status()
        {
            Console.Write("Selsai");

        }
    }
    public class belum : status
    {
        public override void Status()
        {
            Console.Write("Belum Selesai");
        }
    }
}
