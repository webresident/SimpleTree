using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTree_Data_Structure_
{
    public class NodeAnalyzer
    {
        public int GetTreeDepth(Node mainNode)
        {
            if (mainNode == null)
                return 0;

            int maxPasses = 1;
            int currentPasses;

            Node[] children = mainNode.GetChildren();

            for (int i = 0; i < children.Length; i++)
            {
                currentPasses = 1;
                currentPasses += GetTreeDepth(children[i]);
                if (currentPasses > maxPasses)
                    maxPasses = currentPasses;
            }
            return maxPasses;
        }
    }
}
