namespace Graph
{
    public partial class Form1 : Form
    {
        private Graph graph;
        public Form1()
        {
            InitializeComponent();
            graph = new Graph();
        }

        private void btnAddNode_Click(object sender, EventArgs e)
        {
            string nodeName = txtNodeName.Text;
            if (!string.IsNullOrEmpty(nodeName))
            {
                graph.AddNode(nodeName);
                UpdateAdjacencyMatrixView();
                txtNodeName.Clear();
            }
        }

        private void btnAddEdge_Click(object sender, EventArgs e)
        {
            string from = txtFromNode.Text;
            string to = txtToNode.Text;
            int weight = int.Parse(txtWeight.Text);

            graph.AddEdge(from, to, weight);
            UpdateAdjacencyMatrixView();
            txtFromNode.Clear();
            txtToNode.Clear();
            txtWeight.Clear();
        }


        private void UpdateAdjacencyMatrixView()
        {
            // Obtener matriz y nodos
            var matrix = graph.GetAdjacencyMatrix();
            var nodes = graph.GetNodes();

            // Configurar columnas y filas
            dgvAdjacencyMatrix.Columns.Clear();
            dgvAdjacencyMatrix.Rows.Clear();

            // Crear encabezados de columnas
            dgvAdjacencyMatrix.Columns.Add("", ""); // Esquina vacía
            foreach (var node in nodes)
            {
                dgvAdjacencyMatrix.Columns.Add(node, node);
            }

            // Agregar filas con valores de la matriz
            for (int i = 0; i < nodes.Count; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.HeaderCell.Value = nodes[i];

                for (int j = 0; j < nodes.Count; j++)
                {
                    row.Cells.Add(new DataGridViewTextBoxCell() { Value = matrix[i, j] });
                }

                dgvAdjacencyMatrix.Rows.Add(row);
            }
        }

      

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        

    }
}
