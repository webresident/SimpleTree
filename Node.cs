using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTree_Data_Structure_
{
    public class Node
    {
        private int _maxCountOfChildren = 2;
        private int _currentCountOfChildren = 0;

        private bool _isFree = true;
        private int _value;

        private Node _parent;
        private Node[] _children;

        public bool IsFree => _isFree;
        public int Value => _value;

        public Node(Node parent, int inputValue)
        {
            InitializeChildren();
            _value = inputValue;
            if (parent == null || !parent.IsFree)
                return;
            _parent = parent;
            _parent.SetNode(this);
        }

        public void SetNode(Node newNode)
        {
            if (_currentCountOfChildren >= _maxCountOfChildren)
            {
                _isFree = false;
                return;
            }
            _currentCountOfChildren++;
            _children[_currentCountOfChildren - 1] = newNode;
        }
        public Node[] GetChildren()
        {
            return _children;
        }

        private void InitializeChildren()
        {
            _children = new Node[_maxCountOfChildren];
            for (int i = 0; i < _maxCountOfChildren; i++)
            {
                _children[i] = null;
            }
        }

    }
}
