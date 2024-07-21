using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas
{
    public abstract class variabel //Abstraksi
    {
        private string tugas {  get; set; } //Enkapsulasi
        private string deadline {  get; set; }

        public string Tugas
        {
            get { return tugas; }
            private set { tugas = value; }
        }
        public string DeadLine
        {
            get { return deadline; }
            private set { deadline = value; }
        }

        public variabel(string tugas, string deadline)
        {
            Tugas = tugas;
            DeadLine = deadline;
        }

        public virtual void TampilkanInfoTugas() //polimorfisme
        {
            Console.WriteLine("Judul : {0}, DeadLine : {1}", Tugas, DeadLine);
        }
    }
}
