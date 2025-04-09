namespace AppTitlesAnime
{
    partial class FormListTypes
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
            flowLayoutPanelTop = new Panel();
            btnDeleteType = new Button();
            btnAddType = new Button();
            btnUpdateType = new Button();
            dataGridViewTypes = new DataGridView();
            panelFill = new Panel();
            flowLayoutPanelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTypes).BeginInit();
            panelFill.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanelTop
            // 
            flowLayoutPanelTop.AutoSize = true;
            flowLayoutPanelTop.BackColor = Color.White;
            flowLayoutPanelTop.Controls.Add(btnDeleteType);
            flowLayoutPanelTop.Controls.Add(btnAddType);
            flowLayoutPanelTop.Controls.Add(btnUpdateType);
            flowLayoutPanelTop.Dock = DockStyle.Top;
            flowLayoutPanelTop.Location = new Point(0, 0);
            flowLayoutPanelTop.Name = "flowLayoutPanelTop";
            flowLayoutPanelTop.Padding = new Padding(10);
            flowLayoutPanelTop.Size = new Size(1257, 66);
            flowLayoutPanelTop.TabIndex = 1;
            // 
            // btnDeleteType
            // 
            btnDeleteType.AutoSize = true;
            btnDeleteType.BackColor = SystemColors.Control;
            btnDeleteType.Location = new Point(292, 13);
            btnDeleteType.Name = "btnDeleteType";
            btnDeleteType.Size = new Size(92, 40);
            btnDeleteType.TabIndex = 5;
            btnDeleteType.Text = "Удалить";
            btnDeleteType.UseVisualStyleBackColor = true;
            // 
            // btnAddType
            // 
            btnAddType.AutoSize = true;
            btnAddType.BackColor = SystemColors.Control;
            btnAddType.Location = new Point(10, 13);
            btnAddType.Name = "btnAddType";
            btnAddType.Size = new Size(106, 40);
            btnAddType.TabIndex = 3;
            btnAddType.Text = "Добавить";
            btnAddType.UseVisualStyleBackColor = true;
            btnAddType.Click += BtnAddType_Click;
            // 
            // btnUpdateType
            // 
            btnUpdateType.AutoSize = true;
            btnUpdateType.BackColor = SystemColors.Control;
            btnUpdateType.Location = new Point(122, 12);
            btnUpdateType.Name = "btnUpdateType";
            btnUpdateType.Size = new Size(164, 40);
            btnUpdateType.TabIndex = 4;
            btnUpdateType.Text = "Редактировать";
            btnUpdateType.UseVisualStyleBackColor = true;
            btnUpdateType.Click += btnUpdateType_Click_2;
            // 
            // dataGridViewTypes
            // 
            dataGridViewTypes.BackgroundColor = Color.White;
            dataGridViewTypes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTypes.Dock = DockStyle.Fill;
            dataGridViewTypes.GridColor = Color.White;
            dataGridViewTypes.Location = new Point(10, 10);
            dataGridViewTypes.Name = "dataGridViewTypes";
            dataGridViewTypes.ReadOnly = true;
            dataGridViewTypes.Size = new Size(1237, 664);
            dataGridViewTypes.TabIndex = 2;
            dataGridViewTypes.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panelFill
            // 
            panelFill.Controls.Add(dataGridViewTypes);
            panelFill.Dock = DockStyle.Fill;
            panelFill.Location = new Point(0, 66);
            panelFill.Name = "panelFill";
            panelFill.Padding = new Padding(10);
            panelFill.Size = new Size(1257, 684);
            panelFill.TabIndex = 3;
            // 
            // FormListTypes
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1257, 750);
            Controls.Add(panelFill);
            Controls.Add(flowLayoutPanelTop);
            Font = new Font("Segoe UI", 14.25F);
            Margin = new Padding(5);
            Name = "FormListTypes";
            Text = "Список типов аниме";
            Load += FormListTypes_Load;
            flowLayoutPanelTop.ResumeLayout(false);
            flowLayoutPanelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTypes).EndInit();
            panelFill.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel flowLayoutPanelTop;
        private Button btnDeleteType;
        private Button btnAddType;
        private Button btnUpdateType;
        private DataGridView dataGridViewTypes;
        private Panel panelFill;
    }
}