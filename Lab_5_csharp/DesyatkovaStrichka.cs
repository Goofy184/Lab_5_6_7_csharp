using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
namespace Lab_5_csharp
{
    class DesyatkovaStrichka: Strichka, IStrichka, IComparable, ICloneable
    {
        public DesyatkovaStrichka(int num) {
            this.Symbol = num.ToString().ToCharArray();
            this.Length = (byte)Encoding.UTF8.GetByteCount(this.Symbol);
        }
        public static DesyatkovaStrichka operator -(DesyatkovaStrichka a, DesyatkovaStrichka b)
        => new DesyatkovaStrichka(a.GetNumValue() - b.GetNumValue());
        public static bool operator >(DesyatkovaStrichka a, DesyatkovaStrichka b)
        => a.GetNumValue() > b.GetNumValue();
        public static bool operator <(DesyatkovaStrichka a, DesyatkovaStrichka b)
        => a.GetNumValue() < b.GetNumValue();
        private int GetNumValue() { 
            string numAsString = new string(this.Symbol);
            var regexWithSymbol = new Regex("^[+-][0-9$;]+$");
            var regexWithoutSymbol = new Regex("^[0-9$;]+$");
            if (!regexWithSymbol.IsMatch(numAsString) && !regexWithoutSymbol.IsMatch(numAsString)) {
                return 0;
            }
            return Int32.Parse(numAsString);
        }
        public int CompareTo(object obj)
        {
            if (obj == null) return 1;
            DesyatkovaStrichka other = obj as DesyatkovaStrichka;
            if (other != null)
                if (this > other) {
                    return 1;
                } else {
                    return -1;
                }
            else
                throw new ArgumentException("Object is not a DesyatkovaStrichka");
        }
        public object Clone()
        {
            return new DesyatkovaStrichka(this.GetNumValue());
        }
    }
}