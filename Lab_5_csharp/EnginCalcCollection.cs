using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lab_5_csharp
{
    public class EnginCalcCollection : IEnumerable
    {
        private SortedList _collection;
        private SortedList<int, EngineeringCalculator> _genericCollection;

        public EnginCalcCollection()
        {
            _collection = new SortedList();
            _genericCollection = new SortedList<int, EngineeringCalculator>();
        }

        public void Add(EngineeringCalculator calculator)
        {
            _collection.Add(calculator.Id, calculator);
            _genericCollection.Add(calculator.Id, calculator);
        }

        public string DisplayElement(int id)
        {
            if (_collection.ContainsKey(id))
            {
                return Convert.ToString(_collection[id]);
            }
            else
            {
                return ("Element not found.");
            }
        }

        public IEnumerator GetEnumerator()
        {
            return _collection.GetEnumerator();
        }

        public IEnumerator<EngineeringCalculator> GetEnumeratorGeneric()
        {
            return _genericCollection.Values.GetEnumerator();
        }
    }
}
