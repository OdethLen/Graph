using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    internal class Graph
    {
        private List<string> nodes; // Lista de nodos
        private int[,] adjacencyMatrix; // Matriz de adyacencia

        public Graph()
        {
            nodes = new List<string>();
            adjacencyMatrix = new int[0, 0];
        }

        // Agregar un nodo al grafo
        public void AddNode(string node)
        {
            if (!nodes.Contains(node))
            {
                nodes.Add(node);
                ResizeMatrix(); // Ajustar el tamaño de la matriz
            }
        }

        // Agregar una arista entre dos nodos
        public void AddEdge(string from, string to, int weight = 1)
        {
            int fromIndex = nodes.IndexOf(from);
            int toIndex = nodes.IndexOf(to);

            if (fromIndex != -1 && toIndex != -1)
            {
                adjacencyMatrix[fromIndex, toIndex] = weight;
                adjacencyMatrix[toIndex, fromIndex] = weight; // Para grafos no dirigidos
            }
        }

        // Remover un nodo
        public void RemoveNode(string node)
        {
            int index = nodes.IndexOf(node);
            if (index != -1)
            {
                nodes.RemoveAt(index);
                ResizeMatrix();
            }
        }

        // Obtener la matriz de adyacencia
        public int[,] GetAdjacencyMatrix()
        {
            return adjacencyMatrix;
        }

        // Obtener la lista de nodos
        public List<string> GetNodes()
        {
            return nodes;
        }

        // Redimensionar la matriz de adyacencia
        private void ResizeMatrix()
        {
            int newSize = nodes.Count;
            int[,] newMatrix = new int[newSize, newSize];

            // Copiar los datos antiguos a la nueva matriz
            for (int i = 0; i < newSize - 1; i++)
            {
                for (int j = 0; j < newSize - 1; j++)
                {
                    newMatrix[i, j] = adjacencyMatrix[i, j];
                }
            }

            adjacencyMatrix = newMatrix;
        }
    }
}
