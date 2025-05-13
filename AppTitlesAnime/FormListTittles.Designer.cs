namespace AppTitlesAnime
{
    partial class FormListTittles
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridViewTittles = new DataGridView();
            flowLayoutPanel = new FlowLayoutPanel();
            btnAddTittles = new Button();
            btnUpdateTittles = new Button();
            btnDeleteTittles = new Button();
            panelFill = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTittles).BeginInit();
            flowLayoutPanel.SuspendLayout();
            panelFill.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewTittles
            // 
            dataGridViewTittles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewTittles.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewTittles.BackgroundColor = Color.White;
            dataGridViewTittles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTittles.Dock = DockStyle.Fill;
            dataGridViewTittles.Location = new Point(10, 10);
            dataGridViewTittles.MultiSelect = false;
            dataGridViewTittles.Name = "dataGridViewTittles";
            dataGridViewTittles.ReadOnly = true;
            dataGridViewTittles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewTittles.Size = new Size(914, 425);
            dataGridViewTittles.TabIndex = 0;
            // 
            // flowLayoutPanel
            // 
            flowLayoutPanel.AutoSize = true;
            flowLayoutPanel.Controls.Add(btnAddTittles);
            flowLayoutPanel.Controls.Add(btnUpdateTittles);
            flowLayoutPanel.Controls.Add(btnDeleteTittles);
            flowLayoutPanel.Dock = DockStyle.Top;
            flowLayoutPanel.Location = new Point(0, 0);
            flowLayoutPanel.Name = "flowLayoutPanel";
            flowLayoutPanel.Padding = new Padding(10);
            flowLayoutPanel.Size = new Size(934, 66);
            flowLayoutPanel.TabIndex = 8;
            // 
            // btnAddTittles
            // 
            btnAddTittles.AutoSize = true;
            btnAddTittles.BackColor = SystemColors.Control;
            btnAddTittles.Location = new Point(13, 13);
            btnAddTittles.Name = "btnAddTittles";
            btnAddTittles.Size = new Size(106, 40);
            btnAddTittles.TabIndex = 3;
            btnAddTittles.Text = "Добавить";
            btnAddTittles.UseVisualStyleBackColor = true;
            btnAddTittles.Click += btnAddTittles_Click;
            // 
            // btnUpdateTittles
            // 
            btnUpdateTittles.AutoSize = true;
            btnUpdateTittles.BackColor = SystemColors.Control;
            btnUpdateTittles.Dock = DockStyle.Fill;
            btnUpdateTittles.Location = new Point(125, 13);
            btnUpdateTittles.Name = "btnUpdateTittles";
            btnUpdateTittles.Size = new Size(151, 40);
            btnUpdateTittles.TabIndex = 4;
            btnUpdateTittles.Text = "Редактировать";
            btnUpdateTittles.UseMnemonic = false;
            btnUpdateTittles.UseVisualStyleBackColor = true;
            btnUpdateTittles.Click += btnUpdateTittles_Click;
            // 
            // btnDeleteTittles
            // 
            btnDeleteTittles.AutoSize = true;
            btnDeleteTittles.BackColor = SystemColors.Control;
            btnDeleteTittles.Location = new Point(282, 13);
            btnDeleteTittles.Name = "btnDeleteTittles";
            btnDeleteTittles.Size = new Size(92, 40);
            btnDeleteTittles.TabIndex = 5;
            btnDeleteTittles.Text = "Удалить";
            btnDeleteTittles.UseVisualStyleBackColor = true;
            btnDeleteTittles.Click += btnDeleteTittles_Click;
            // 
            // panelFill
            // 
            panelFill.Controls.Add(dataGridViewTittles);
            panelFill.Dock = DockStyle.Fill;
            panelFill.Location = new Point(0, 66);
            panelFill.Name = "panelFill";
            panelFill.Padding = new Padding(10);
            panelFill.Size = new Size(934, 445);
            panelFill.TabIndex = 9;
            // 
            // FormListTittles
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(934, 511);
            Controls.Add(panelFill);
            Controls.Add(flowLayoutPanel);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(5);
            Name = "FormListTittles";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Тайтлы аниме";
            ((System.ComponentModel.ISupportInitialize)dataGridViewTittles).EndInit();
            flowLayoutPanel.ResumeLayout(false);
            flowLayoutPanel.PerformLayout();
            panelFill.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewTittles;
        private FlowLayoutPanel flowLayoutPanel;
        private Button btnAddTittles;
        private Button btnUpdateTittles;
        private Button btnDeleteTittles;
        private Panel panelFill;
    }
}