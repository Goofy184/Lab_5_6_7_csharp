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
        public EnginCalcCollection()
        {
            _collection = new SortedList();
        }
        public void Add(EngineeringCalculator calculator)
        {
            _collection.Add(calculator.Id, calculator);
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

    }
    public class EnginCalcCollection<V> : IEnumerable<KeyValuePair<int, V>> where V : EngineeringCalculator
    {
        private SortedList<int, V> list = new SortedList<int, V>();
        public void Add(V calculator)
        {
            list.Add(calculator.Id, calculator);
        }
        public string DisplayElement(int id)
        {
            if (list.ContainsKey(id))
            {
                return Convert.ToString(list[id]);
            }
            else
            {
                return ("Element not found.");
            }
        }
        public IEnumerator<KeyValuePair<int, V>> GetEnumerator()
        {
            return list.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return list.GetEnumerator();
        }

    }
}