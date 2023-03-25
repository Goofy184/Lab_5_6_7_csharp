using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Lab_5_csharp
{
    class Strichka
    {
        private char[] symbol;
        private byte length;
        public char[] Symbol
        {
            get
            {
                return symbol;
            }
            set
            {
                symbol = value;
            }
        }
        public byte Length 
        {
            get
            {
                return length;
            }
            set
            {
                length = value;
            }
        }
        public Strichka() { }
        public Strichka(Strichka strichka) {
            this.Symbol = strichka.Symbol;
            this.Length = strichka.Length;
        }
        public Strichka(char[] symbols) {
            this.Symbol = symbols;
        }
        public void Clear() {
            this.Symbol = new char[0];
            this.Length = 0;
        }
    }
}