namespace AppTitlesAnime
{
    partial class FormListStatuses
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
            panelFill = new Panel();
            dataGridViewStatus = new DataGridView();
            flowLayoutPanel = new FlowLayoutPanel();
            btnAddStatuses = new Button();
            btnUpdateStatus = new Button();
            btnDeleteStatuses = new Button();
            panelFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStatus).BeginInit();
            flowLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // panelFill
            // 
            panelFill.AutoSize = true;
            panelFill.Controls.Add(dataGridViewStatus);
            panelFill.Dock = DockStyle.Fill;
            panelFill.Location = new Point(0, 76);
            panelFill.Margin = new Padding(8);
            panelFill.Name = "panelFill";
            panelFill.Padding = new Padding(10);
            panelFill.Size = new Size(974, 335);
            panelFill.TabIndex = 11;
            // 
            // dataGridViewStatus
            // 
            dataGridViewStatus.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewStatus.BackgroundColor = Color.White;
            dataGridViewStatus.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStatus.Dock = DockStyle.Fill;
            dataGridViewStatus.Location = new Point(10, 10);
            dataGridViewStatus.Margin = new Padding(8);
            dataGridViewStatus.MultiSelect = false;
            dataGridViewStatus.Name = "dataGridViewStatus";
            dataGridViewStatus.ReadOnly = true;
            dataGridViewStatus.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewStatus.Size = new Size(954, 315);
            dataGridViewStatus.TabIndex = 0;
            // 
            // flowLayoutPanel
            // 
            flowLayoutPanel.AutoSize = true;
            flowLayoutPanel.Controls.Add(btnAddStatuses);
            flowLayoutPanel.Controls.Add(btnUpdateStatus);
            flowLayoutPanel.Controls.Add(btnDeleteStatuses);
            flowLayoutPanel.Dock = DockStyle.Top;
            flowLayoutPanel.Location = new Point(0, 0);
            flowLayoutPanel.Name = "flowLayoutPanel";
            flowLayoutPanel.Padding = new Padding(10);
            flowLayoutPanel.Size = new Size(974, 76);
            flowLayoutPanel.TabIndex = 5;
            // 
            // btnAddStatuses
            // 
            btnAddStatuses.AutoSize = true;
            btnAddStatuses.BackColor = SystemColors.Control;
            btnAddStatuses.Location = new Point(18, 18);
            btnAddStatuses.Margin = new Padding(8);
            btnAddStatuses.Name = "btnAddStatuses";
            btnAddStatuses.Size = new Size(106, 40);
            btnAddStatuses.TabIndex = 3;
            btnAddStatuses.Text = "Добавить";
            btnAddStatuses.UseVisualStyleBackColor = true;
            btnAddStatuses.Click += BtnAddStatus_Click;
            // 
            // btnUpdateStatus
            // 
            btnUpdateStatus.AutoSize = true;
            btnUpdateStatus.BackColor = SystemColors.Control;
            btnUpdateStatus.Location = new Point(140, 18);
            btnUpdateStatus.Margin = new Padding(8);
            btnUpdateStatus.Name = "btnUpdateStatus";
            btnUpdateStatus.Size = new Size(151, 40);
            btnUpdateStatus.TabIndex = 4;
            btnUpdateStatus.Text = "Редактировать";
            btnUpdateStatus.UseMnemonic = false;
            btnUpdateStatus.UseVisualStyleBackColor = true;
            btnUpdateStatus.Click += BtnUpdateStatus_Click;
            // 
            // btnDeleteStatuses
            // 
            btnDeleteStatuses.AutoSize = true;
            btnDeleteStatuses.BackColor = SystemColors.Control;
            btnDeleteStatuses.Location = new Point(307, 18);
            btnDeleteStatuses.Margin = new Padding(8);
            btnDeleteStatuses.Name = "btnDeleteStatuses";
            btnDeleteStatuses.Size = new Size(92, 40);
            btnDeleteStatuses.TabIndex = 5;
            btnDeleteStatuses.Text = "Удалить";
            btnDeleteStatuses.UseVisualStyleBackColor = true;
            btnDeleteStatuses.Click += btnDeleteStatus_Click;
            // 
            // FormListStatuses
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(974, 411);
            Controls.Add(panelFill);
            Controls.Add(flowLayoutPanel);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(5);
            Name = "FormListStatuses";
            Text = "Список статусов аниме";
            panelFill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewStatus).EndInit();
            flowLayoutPanel.ResumeLayout(false);
            flowLayoutPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelFill;
        private DataGridView dataGridViewStatus;
        private FlowLayoutPanel flowLayoutPanel;
        private Button btnAddStatuses;
        private Button btnUpdateStatus;
        private Button btnDeleteStatuses;
    }
}