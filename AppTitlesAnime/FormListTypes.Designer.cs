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
            components = new System.ComponentModel.Container();
            flowLayoutPanel = new FlowLayoutPanel();
            btnAddType = new Button();
            btnUpdateType = new Button();
            btnDeleteType = new Button();
            panelFill = new Panel();
            dataGridViewTypes = new DataGridView();
            errorProvider = new ErrorProvider(components);
            flowLayoutPanel.SuspendLayout();
            panelFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTypes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel
            // 
            flowLayoutPanel.AutoSize = true;
            flowLayoutPanel.Controls.Add(btnAddType);
            flowLayoutPanel.Controls.Add(btnUpdateType);
            flowLayoutPanel.Controls.Add(btnDeleteType);
            flowLayoutPanel.Dock = DockStyle.Top;
            flowLayoutPanel.Location = new Point(0, 0);
            flowLayoutPanel.Name = "flowLayoutPanel";
            flowLayoutPanel.Padding = new Padding(10);
            flowLayoutPanel.Size = new Size(974, 66);
            flowLayoutPanel.TabIndex = 5;
            // 
            // btnAddType
            // 
            btnAddType.AutoSize = true;
            btnAddType.BackColor = SystemColors.Control;
            btnAddType.Dock = DockStyle.Top;
            btnAddType.Location = new Point(13, 13);
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
            btnUpdateType.Dock = DockStyle.Top;
            btnUpdateType.Location = new Point(125, 13);
            btnUpdateType.Name = "btnUpdateType";
            btnUpdateType.Size = new Size(164, 40);
            btnUpdateType.TabIndex = 4;
            btnUpdateType.Text = "Редактировать";
            btnUpdateType.UseMnemonic = false;
            btnUpdateType.UseVisualStyleBackColor = true;
            btnUpdateType.Click += BtnUpdateType_Click;
            // 
            // btnDeleteType
            // 
            btnDeleteType.AutoSize = true;
            btnDeleteType.BackColor = SystemColors.Control;
            btnDeleteType.Location = new Point(295, 13);
            btnDeleteType.Name = "btnDeleteType";
            btnDeleteType.Size = new Size(92, 40);
            btnDeleteType.TabIndex = 5;
            btnDeleteType.Text = "Удалить";
            btnDeleteType.UseVisualStyleBackColor = true;
            btnDeleteType.Click += btnDeleteType_Click;
            // 
            // panelFill
            // 
            panelFill.Controls.Add(dataGridViewTypes);
            panelFill.Dock = DockStyle.Fill;
            panelFill.Location = new Point(0, 66);
            panelFill.Name = "panelFill";
            panelFill.Padding = new Padding(10);
            panelFill.Size = new Size(974, 345);
            panelFill.TabIndex = 7;
            // 
            // dataGridViewTypes
            // 
            dataGridViewTypes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewTypes.BackgroundColor = Color.White;
            dataGridViewTypes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTypes.Dock = DockStyle.Fill;
            dataGridViewTypes.Location = new Point(10, 10);
            dataGridViewTypes.MultiSelect = false;
            dataGridViewTypes.Name = "dataGridViewTypes";
            dataGridViewTypes.ReadOnly = true;
            dataGridViewTypes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewTypes.Size = new Size(954, 325);
            dataGridViewTypes.TabIndex = 0;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // FormListTypes
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(974, 411);
            Controls.Add(panelFill);
            Controls.Add(flowLayoutPanel);
            Font = new Font("Segoe UI", 14.25F);
            Margin = new Padding(5);
            Name = "FormListTypes";
            Text = "Список типов аниме";
            flowLayoutPanel.ResumeLayout(false);
            flowLayoutPanel.PerformLayout();
            panelFill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewTypes).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FlowLayoutPanel flowLayoutPanel;
        private Button btnDeleteType;
        private Button btnAddType;
        private Button btnUpdateType;
        private Panel panelFill;
        private DataGridView dataGridViewTypes;
        private ErrorProvider errorProvider;
    }
}