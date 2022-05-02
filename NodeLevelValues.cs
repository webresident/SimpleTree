using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTree_Data_Structure_
{
    public class NodeLevelValues
    {
        private int _level;
        private List<int> _values;

        public NodeLevelValues(int level)
        {
            _level = level;
            _values = new List<int>();
        }

        public void AddNewValue(int value)
        {
            _values.Add(value);
        }

        public string GetLevelText()
        {
            StringBuilder text = new StringBuilder(_values.Count);
            foreach (var value in _values)
            {
                text.Append(value + " ");
            }
            return text.ToString();
        }
    }
}
