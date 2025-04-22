namespace AppTitlesAnime
{
    partial class FormMain
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
            btnShowTypes = new Button();
            btnShowGenres = new Button();
            btnShowStatuses = new Button();
            flowLayoutPanel = new FlowLayoutPanel();
            flowLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // btnShowTypes
            // 
            btnShowTypes.AutoSize = true;
            btnShowTypes.BackColor = Color.White;
            btnShowTypes.Location = new Point(13, 13);
            btnShowTypes.Name = "btnShowTypes";
            btnShowTypes.Size = new Size(368, 35);
            btnShowTypes.TabIndex = 0;
            btnShowTypes.Text = "Отобразить список типов аниме";
            btnShowTypes.UseVisualStyleBackColor = true;
            btnShowTypes.Click += BtnShowTypes_Click;
            // 
            // btnShowGenres
            // 
            btnShowGenres.AutoSize = true;
            btnShowGenres.BackColor = Color.White;
            btnShowGenres.Location = new Point(387, 13);
            btnShowGenres.Name = "btnShowGenres";
            btnShowGenres.Size = new Size(436, 35);
            btnShowGenres.TabIndex = 1;
            btnShowGenres.Text = "Отобразить список жанров аниме";
            btnShowGenres.UseVisualStyleBackColor = true;
            btnShowGenres.Click += BtnShowGenres_Click;
            // 
            // btnShowStatuses
            // 
            btnShowStatuses.AutoSize = true;
            btnShowStatuses.BackColor = Color.White;
            btnShowStatuses.Location = new Point(829, 13);
            btnShowStatuses.Name = "btnShowStatuses";
            btnShowStatuses.Size = new Size(436, 35);
            btnShowStatuses.TabIndex = 2;
            btnShowStatuses.Text = "Отобразить список статусов  аниме";
            btnShowStatuses.UseVisualStyleBackColor = true;
            btnShowStatuses.Click += BtnShowStatuses_Click;
            // 
            // flowLayoutPanel
            // 
            flowLayoutPanel.Controls.Add(btnShowTypes);
            flowLayoutPanel.Controls.Add(btnShowGenres);
            flowLayoutPanel.Controls.Add(btnShowStatuses);
            flowLayoutPanel.Dock = DockStyle.Fill;
            flowLayoutPanel.Location = new Point(0, 0);
            flowLayoutPanel.Name = "flowLayoutPanel";
            flowLayoutPanel.Padding = new Padding(10);
            flowLayoutPanel.Size = new Size(1284, 661);
            flowLayoutPanel.TabIndex = 3;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1284, 661);
            Controls.Add(flowLayoutPanel);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(5);
            Name = "FormMain";
            Text = "Главная форма";
            flowLayoutPanel.ResumeLayout(false);
            flowLayoutPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnShowTypes;
        private Button btnShowGenres;
        private Button btnShowStatuses;
        private FlowLayoutPanel flowLayoutPanel;
    }
}
