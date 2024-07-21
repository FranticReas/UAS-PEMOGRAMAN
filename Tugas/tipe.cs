using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas
{
    public class TugasKerja : variabel //Pewarisan
    {
        public string deskripsi {  get; set; }
        public TugasKerja(string Tugas, string DeadLine, string desk) : base (Tugas, DeadLine)
        {
            deskripsi = desk;
        }

        public override void TampilkanInfoTugas()//polimorfisme
        {
            Console.WriteLine($"[KERJA] Judul : {Tugas}, DeadLine : {DeadLine}. {deskripsi}");
        }
    }

    public class TugasPribadi : variabel //Pewarisan
    {
        public string deskripsi { get; set; }
        public TugasPribadi(string Tugas, string DeadLine, string desk) : base (Tugas, DeadLine)
        {
            deskripsi = desk;
        }

        public override void TampilkanInfoTugas()//polimordisme
        {
            Console.WriteLine("[PRIBADI] Judul : {0}, DeadLine : {1}. {2}", Tugas, DeadLine, deskripsi);
        }
    }
}
