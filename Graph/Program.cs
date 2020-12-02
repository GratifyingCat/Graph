// Репозиторий Римас Никиты

using System;
using System.Collections;
using System.Collections.Generic;

namespace Graph
{
    class Node
    {
        public int Value { get; set; }
        public bool Visited { get; set; }

        public Node()
        {
            LinkedNodes = new ArrayList();
        }

        public void AddLinkedNode(Node node, int linkWeight)
        {
            Link link = new Link(node, linkWeight);
            LinkedNodes.Add(link);
        }

        public ArrayList LinkedNodes { get; }
    }

    class Link
    {
        public Link(Node node, int linkWeight)
        {
            LinkedNode = node;
            LinkWeight = linkWeight;
        }

        public Node LinkedNode { get; set; }

        public int LinkWeight { get; set; }
    }

    class Program
    {
        const int NodesCount = 10;
        static void Main(string[] args)
        {
            int[] values = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            ArrayList nodes = new ArrayList();
            for(int i = 0; i < NodesCount; i++)
            {
                nodes.Add(new Node());
                nodes[i] = values[i];
            }
            int[,] links = new int[NodesCount, NodesCount] 
            {
                {0, 1, 0, 0, 0, 0, 0, 0, 0, 0},
                {1, 0, 1, 0, 0, 0, 0, 0, 0, 0},
                {0, 1, 0, 1, 0, 0, 0, 0, 0, 0},
                {0, 0, 1, 0, 1, 0, 0, 0, 0, 0},
                {0, 0, 0, 1, 0, 1, 0, 0, 0, 0},
                {0, 0, 0, 0, 1, 0, 1, 0, 0, 0},
                {0, 0, 0, 0, 0, 1, 0, 1, 0, 0},
                {0, 0, 0, 0, 0, 0, 1, 0, 1, 0},
                {0, 0, 0, 0, 0, 0, 0, 1, 0, 1},
                {0, 0, 0, 0, 0, 0, 0, 0, 1, 0}
            };
            for(int i = 0; i < NodesCount; i++)
            {
                Node node = (Node)nodes[i];
                for (int j = 0; j < NodesCount; j++)
                {
                    if (links[i, j] != 0)
                    {
                        node.AddLinkedNode((Node)nodes[j], links[i, j]);
                    }
                }
            }
        }
    }
}
