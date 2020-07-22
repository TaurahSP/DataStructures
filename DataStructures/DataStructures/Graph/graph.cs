using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Graph
{
    /// <summary>
    /// Use adjaceny list to implement graph
    /// </summary>
    public class graph
    {
        private Dictionary<int, List<int>> adjacentList;
        private int numberOfNodes;

        public graph()
        {
            adjacentList = new Dictionary<int, List<int>>();
            numberOfNodes = 0;
        }

        public void addVertex(int value)
        {
            adjacentList.Add(value, new List<int>());
            numberOfNodes++;
        }

        public void addEdge(int value1, int value2)
        {
            adjacentList[value1].Add(value2);
            adjacentList[value2].Add(value1);
        }

        public void showConnections()
        {
            foreach(var item in adjacentList)
            {
                List<int> nodeConnections = adjacentList[item.Key];
                StringBuilder connections = new StringBuilder();
                foreach(int edge in nodeConnections)
                {
                    connections.Append(edge).Append(" ");
                }
                Console.WriteLine(item.Key + "-->" + connections);
            }
        }
    }
}
