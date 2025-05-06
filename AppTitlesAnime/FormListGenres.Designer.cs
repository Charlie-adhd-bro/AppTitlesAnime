namespace AppTitlesAnime
{
    partial class FormListGenres
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
            btnAddGenre = new Button();
            btnUpdateGenre = new Button();
            btnDeleteGenre = new Button();
            panelFill = new Panel();
            dataGridViewGenres = new DataGridView();
            errorProvider = new ErrorProvider(components);
            flowLayoutPanel.SuspendLayout();
            panelFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewGenres).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel
            // 
            flowLayoutPanel.AutoSize = true;
            flowLayoutPanel.Controls.Add(btnAddGenre);
            flowLayoutPanel.Controls.Add(btnUpdateGenre);
            flowLayoutPanel.Controls.Add(btnDeleteGenre);
            flowLayoutPanel.Dock = DockStyle.Top;
            flowLayoutPanel.Location = new Point(0, 0);
            flowLayoutPanel.Margin = new Padding(5);
            flowLayoutPanel.Name = "flowLayoutPanel";
            flowLayoutPanel.Padding = new Padding(10);
            flowLayoutPanel.Size = new Size(974, 70);
            flowLayoutPanel.TabIndex = 8;
            // 
            // btnAddGenre
            // 
            btnAddGenre.AutoSize = true;
            btnAddGenre.BackColor = SystemColors.Control;
            btnAddGenre.Location = new Point(15, 15);
            btnAddGenre.Margin = new Padding(5);
            btnAddGenre.Name = "btnAddGenre";
            btnAddGenre.Size = new Size(106, 40);
            btnAddGenre.TabIndex = 3;
            btnAddGenre.Text = "Добавить";
            btnAddGenre.UseVisualStyleBackColor = true;
            btnAddGenre.Click += BtnAddGenre_Click;
            // 
            // btnUpdateGenre
            // 
            btnUpdateGenre.AutoSize = true;
            btnUpdateGenre.BackColor = SystemColors.Control;
            btnUpdateGenre.Location = new Point(131, 15);
            btnUpdateGenre.Margin = new Padding(5);
            btnUpdateGenre.Name = "btnUpdateGenre";
            btnUpdateGenre.Size = new Size(151, 40);
            btnUpdateGenre.TabIndex = 4;
            btnUpdateGenre.Text = "Редактировать";
            btnUpdateGenre.UseMnemonic = false;
            btnUpdateGenre.UseVisualStyleBackColor = true;
            btnUpdateGenre.Click += btnUpdateGenre_Click;
            // 
            // btnDeleteGenre
            // 
            btnDeleteGenre.AutoSize = true;
            btnDeleteGenre.BackColor = SystemColors.Control;
            btnDeleteGenre.Location = new Point(292, 15);
            btnDeleteGenre.Margin = new Padding(5);
            btnDeleteGenre.Name = "btnDeleteGenre";
            btnDeleteGenre.Size = new Size(92, 40);
            btnDeleteGenre.TabIndex = 5;
            btnDeleteGenre.Text = "Удалить";
            btnDeleteGenre.UseVisualStyleBackColor = true;
            btnDeleteGenre.Click += btnDeleteGenre_Click;
            // 
            // panelFill
            // 
            panelFill.AutoSize = true;
            panelFill.Controls.Add(dataGridViewGenres);
            panelFill.Dock = DockStyle.Fill;
            panelFill.Location = new Point(0, 70);
            panelFill.Margin = new Padding(5);
            panelFill.Name = "panelFill";
            panelFill.Padding = new Padding(10);
            panelFill.Size = new Size(974, 441);
            panelFill.TabIndex = 9;
            // 
            // dataGridViewGenres
            // 
            dataGridViewGenres.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewGenres.BackgroundColor = Color.White;
            dataGridViewGenres.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewGenres.Dock = DockStyle.Fill;
            dataGridViewGenres.Location = new Point(10, 10);
            dataGridViewGenres.Margin = new Padding(5);
            dataGridViewGenres.MultiSelect = false;
            dataGridViewGenres.Name = "dataGridViewGenres";
            dataGridViewGenres.ReadOnly = true;
            dataGridViewGenres.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewGenres.Size = new Size(954, 421);
            dataGridViewGenres.TabIndex = 0;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // FormListGenres
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(974, 511);
            Controls.Add(panelFill);
            Controls.Add(flowLayoutPanel);
            Font = new Font("Segoe UI", 14.25F);
            Margin = new Padding(5);
            Name = "FormListGenres";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Список жанров аниме";
            flowLayoutPanel.ResumeLayout(false);
            flowLayoutPanel.PerformLayout();
            panelFill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewGenres).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel;
        private Button btnAddGenre;
        private Button btnUpdateGenre;
        private Button btnDeleteGenre;
        private Panel panelFill;
        private DataGridView dataGridViewGenres;
        private ErrorProvider errorProvider;
    }
}