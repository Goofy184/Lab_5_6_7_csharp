using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5_csharp
{
    class Strichka
    {
        public char[] Symbol { get; set; }
        public byte Length { get; set; }

        public Strichka() { }

        public Strichka(Strichka strichka) {
            this.Symbol = strichka.Symbol;
            this.Length = strichka.Length;
        }

        public Strichka(char[] symbols) {
            this.Symbol = symbols;
        }

        public byte GetLength() {
            return this.Length;
        }

        public void Clear() {
            this.Symbol = new char[0];
            this.Length = 0;
        }
    }
}
