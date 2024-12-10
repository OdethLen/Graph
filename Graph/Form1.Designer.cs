namespace Graph
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtNodeName = new TextBox();
            label2 = new Label();
            txtFromNode = new TextBox();
            label3 = new Label();
            txtToNode = new TextBox();
            label4 = new Label();
            txtWeight = new TextBox();
            btnAddNode = new Button();
            btnAddEdge = new Button();
            dgvAdjacencyMatrix = new DataGridView();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvAdjacencyMatrix).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 9.75F);
            label1.Location = new Point(15, 54);
            label1.Name = "label1";
            label1.Size = new Size(79, 17);
            label1.TabIndex = 0;
            label1.Text = "Node Name";
            // 
            // txtNodeName
            // 
            txtNodeName.Font = new Font("Yu Gothic", 9.75F);
            txtNodeName.Location = new Point(100, 43);
            txtNodeName.Name = "txtNodeName";
            txtNodeName.Size = new Size(126, 28);
            txtNodeName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic", 9.75F);
            label2.Location = new Point(21, 54);
            label2.Name = "label2";
            label2.Size = new Size(74, 17);
            label2.TabIndex = 2;
            label2.Text = "From Node";
            // 
            // txtFromNode
            // 
            txtFromNode.Font = new Font("Yu Gothic", 9.75F);
            txtFromNode.Location = new Point(101, 43);
            txtFromNode.Name = "txtFromNode";
            txtFromNode.Size = new Size(126, 28);
            txtFromNode.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic", 9.75F);
            label3.Location = new Point(37, 99);
            label3.Name = "label3";
            label3.Size = new Size(58, 17);
            label3.TabIndex = 4;
            label3.Text = "To Node";
            // 
            // txtToNode
            // 
            txtToNode.Font = new Font("Yu Gothic", 9.75F);
            txtToNode.Location = new Point(101, 91);
            txtToNode.Name = "txtToNode";
            txtToNode.Size = new Size(126, 28);
            txtToNode.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic", 9.75F);
            label4.Location = new Point(11, 137);
            label4.Name = "label4";
            label4.Size = new Size(84, 17);
            label4.TabIndex = 6;
            label4.Text = "Edge Weight";
            // 
            // txtWeight
            // 
            txtWeight.Font = new Font("Yu Gothic", 9.75F);
            txtWeight.Location = new Point(101, 134);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(126, 28);
            txtWeight.TabIndex = 7;
            // 
            // btnAddNode
            // 
            btnAddNode.Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddNode.Location = new Point(232, 38);
            btnAddNode.Name = "btnAddNode";
            btnAddNode.Size = new Size(98, 34);
            btnAddNode.TabIndex = 8;
            btnAddNode.Text = "Add Node";
            btnAddNode.UseVisualStyleBackColor = true;
            btnAddNode.Click += btnAddNode_Click;
            // 
            // btnAddEdge
            // 
            btnAddEdge.Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddEdge.Location = new Point(233, 86);
            btnAddEdge.Name = "btnAddEdge";
            btnAddEdge.Size = new Size(98, 34);
            btnAddEdge.TabIndex = 9;
            btnAddEdge.Text = "Add Edge";
            btnAddEdge.UseVisualStyleBackColor = true;
            btnAddEdge.Click += btnAddEdge_Click;
            // 
            // dgvAdjacencyMatrix
            // 
            dgvAdjacencyMatrix.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAdjacencyMatrix.Location = new Point(395, 55);
            dgvAdjacencyMatrix.Name = "dgvAdjacencyMatrix";
            dgvAdjacencyMatrix.Size = new Size(392, 268);
            dgvAdjacencyMatrix.TabIndex = 11;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtNodeName);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnAddNode);
            groupBox1.Location = new Point(22, 36);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(350, 105);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtFromNode);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(btnAddEdge);
            groupBox2.Controls.Add(txtToNode);
            groupBox2.Controls.Add(txtWeight);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(22, 147);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(350, 184);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic", 9.75F);
            label5.Location = new Point(15, 54);
            label5.Name = "label5";
            label5.Size = new Size(0, 17);
            label5.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(832, 377);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dgvAdjacencyMatrix);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvAdjacencyMatrix).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox txtNodeName;
        private Label label2;
        private TextBox txtFromNode;
        private Label label3;
        private TextBox txtToNode;
        private Label label4;
        private TextBox txtWeight;
        private Button btnAddNode;
        private Button btnAddEdge;
        private DataGridView dgvAdjacencyMatrix;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label5;
    }
}
