using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTree_Data_Structure_
{
    public class NodeDisplayer
    {
        private Dictionary<int, NodeLevelValues> _treeValues;
        public void DisplayNodeTree(Node mainNode, int depth)
        {
            InitializeTreeValues(depth);
            FindTreeValues(mainNode, 0);
            PrintTreeValues();
        }


        private void FindTreeValues(Node mainNode, int currentLevel)
        {
            if (mainNode == null)
                return;
            AddNewValueAtLevel(mainNode.Value, currentLevel);

            Node[] children = mainNode.GetChildren();

            for (int i = 0; i < children.Length; i++)
            {
                if (children[i] == null)
                    continue;
                FindTreeValues(children[i], currentLevel + 1);
            }

        }
        private void PrintTreeValues()
        {
            foreach (KeyValuePair<int, NodeLevelValues> element in _treeValues)
            {
                string text = element.Value.GetLevelText();
                Console.WriteLine(text);
            }
        }
        private void InitializeTreeValues(int levels)
        {
            _treeValues = new Dictionary<int, NodeLevelValues>(levels);

            for (int i = 0; i < levels; i++)
            {
                _treeValues.Add(i, new NodeLevelValues(i));
            }
        }
        private void AddNewValueAtLevel(int value, int level)
        {
            _treeValues[level].AddNewValue(value);
        }
    }
}
