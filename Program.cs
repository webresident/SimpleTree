using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleTree_Data_Structure_
{
    public class Program
    {
        private static void Main()
        {
            Node mainNode = new Node(null, 0);

            Node node1 = new Node(mainNode, 1);
            Node node2 = new Node(mainNode, 2);

            Node node3 = new Node(node1, 3);

            Node node4 = new Node(node2, 4);
            Node node5 = new Node(node3, 5);

            NodeAnalyzer nodeAnalyzer = new NodeAnalyzer();
            int treeDepth = nodeAnalyzer.GetTreeDepth(mainNode);

            NodeDisplayer nodeDisplayer = new NodeDisplayer();
            nodeDisplayer.DisplayNodeTree(mainNode, treeDepth);

        }

        private static string PassingNodes(Node mainNode)
        {
            string resultValue = "";

            resultValue += mainNode.Value.ToString();

            foreach (Node child in mainNode.GetChildren())
            {
                if (child == null)
                    continue;
                resultValue += PassingNodes(child);
            }

            return resultValue;
        }
    }
}
