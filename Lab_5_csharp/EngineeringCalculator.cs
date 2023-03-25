using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5_csharp
{
    public class EngineeringCalculator
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public EngineeringCalculator(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}";
        }
    }
}
