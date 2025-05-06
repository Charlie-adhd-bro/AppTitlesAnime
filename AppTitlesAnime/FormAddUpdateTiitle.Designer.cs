namespace AppTitlesAnime
{
    partial class FormAddUpdateTiitle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddUpdateTiitle));
            flowLayoutPanel = new FlowLayoutPanel();
            btnSaveChanges = new Button();
            btnCancel = new Button();
            textBoxOriginalName = new TextBox();
            panelFill = new Panel();
            richTextBoxDescription = new RichTextBox();
            labelDescription = new Label();
            textBoxStudio = new TextBox();
            labelStudio = new Label();
            numericUpDownDuration = new NumericUpDown();
            labelDuration = new Label();
            numericUpDownCountSeries = new NumericUpDown();
            labelCountSeries = new Label();
            comboBoxType = new ComboBox();
            labelType = new Label();
            textBoxName = new TextBox();
            labelName = new Label();
            labelOriginalName = new Label();
            flowLayoutPanel.SuspendLayout();
            panelFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDuration).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCountSeries).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel
            // 
            flowLayoutPanel.AutoSize = true;
            flowLayoutPanel.Controls.Add(btnSaveChanges);
            flowLayoutPanel.Controls.Add(btnCancel);
            flowLayoutPanel.Dock = DockStyle.Bottom;
            flowLayoutPanel.Location = new Point(0, 616);
            flowLayoutPanel.Margin = new Padding(5);
            flowLayoutPanel.Name = "flowLayoutPanel";
            flowLayoutPanel.Padding = new Padding(16, 17, 16, 17);
            flowLayoutPanel.Size = new Size(496, 79);
            flowLayoutPanel.TabIndex = 4;
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.AutoSize = true;
            btnSaveChanges.DialogResult = DialogResult.OK;
            btnSaveChanges.Location = new Point(21, 22);
            btnSaveChanges.Margin = new Padding(5);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new Size(115, 35);
            btnSaveChanges.TabIndex = 0;
            btnSaveChanges.Text = "Сохранить";
            btnSaveChanges.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.AutoSize = true;
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(146, 22);
            btnCancel.Margin = new Padding(5);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(88, 35);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // textBoxOriginalName
            // 
            textBoxOriginalName.Dock = DockStyle.Top;
            textBoxOriginalName.Location = new Point(16, 42);
            textBoxOriginalName.Margin = new Padding(5);
            textBoxOriginalName.Name = "textBoxOriginalName";
            textBoxOriginalName.Size = new Size(449, 33);
            textBoxOriginalName.TabIndex = 1;
            // 
            // panelFill
            // 
            panelFill.Controls.Add(richTextBoxDescription);
            panelFill.Controls.Add(labelDescription);
            panelFill.Controls.Add(textBoxStudio);
            panelFill.Controls.Add(labelStudio);
            panelFill.Controls.Add(numericUpDownDuration);
            panelFill.Controls.Add(labelDuration);
            panelFill.Controls.Add(numericUpDownCountSeries);
            panelFill.Controls.Add(labelCountSeries);
            panelFill.Controls.Add(comboBoxType);
            panelFill.Controls.Add(labelType);
            panelFill.Controls.Add(textBoxName);
            panelFill.Controls.Add(labelName);
            panelFill.Controls.Add(textBoxOriginalName);
            panelFill.Controls.Add(labelOriginalName);
            panelFill.Dock = DockStyle.Fill;
            panelFill.Location = new Point(0, 0);
            panelFill.Margin = new Padding(5);
            panelFill.Name = "panelFill";
            panelFill.Padding = new Padding(16, 17, 31, 17);
            panelFill.Size = new Size(496, 695);
            panelFill.TabIndex = 3;
            // 
            // richTextBoxDescription
            // 
            richTextBoxDescription.Dock = DockStyle.Top;
            richTextBoxDescription.Location = new Point(16, 390);
            richTextBoxDescription.Name = "richTextBoxDescription";
            richTextBoxDescription.Size = new Size(449, 203);
            richTextBoxDescription.TabIndex = 13;
            richTextBoxDescription.Text = resources.GetString("richTextBoxDescription.Text");
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Dock = DockStyle.Top;
            labelDescription.Location = new Point(16, 365);
            labelDescription.Margin = new Padding(5, 0, 5, 0);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(99, 25);
            labelDescription.TabIndex = 12;
            labelDescription.Text = "Описание";
            // 
            // textBoxStudio
            // 
            textBoxStudio.Dock = DockStyle.Top;
            textBoxStudio.Location = new Point(16, 332);
            textBoxStudio.Margin = new Padding(5);
            textBoxStudio.Name = "textBoxStudio";
            textBoxStudio.Size = new Size(449, 33);
            textBoxStudio.TabIndex = 11;
            // 
            // labelStudio
            // 
            labelStudio.AutoSize = true;
            labelStudio.Dock = DockStyle.Top;
            labelStudio.Location = new Point(16, 307);
            labelStudio.Margin = new Padding(5, 0, 5, 0);
            labelStudio.Name = "labelStudio";
            labelStudio.Size = new Size(72, 25);
            labelStudio.TabIndex = 10;
            labelStudio.Text = "Студия";
            // 
            // numericUpDownDuration
            // 
            numericUpDownDuration.Dock = DockStyle.Top;
            numericUpDownDuration.Location = new Point(16, 274);
            numericUpDownDuration.Margin = new Padding(13);
            numericUpDownDuration.Name = "numericUpDownDuration";
            numericUpDownDuration.Size = new Size(449, 33);
            numericUpDownDuration.TabIndex = 9;
            // 
            // labelDuration
            // 
            labelDuration.AutoSize = true;
            labelDuration.Dock = DockStyle.Top;
            labelDuration.Location = new Point(16, 249);
            labelDuration.Margin = new Padding(5, 0, 5, 0);
            labelDuration.Name = "labelDuration";
            labelDuration.Size = new Size(296, 25);
            labelDuration.TabIndex = 8;
            labelDuration.Text = "Продолжительность серий, мин.";
            // 
            // numericUpDownCountSeries
            // 
            numericUpDownCountSeries.Dock = DockStyle.Top;
            numericUpDownCountSeries.Location = new Point(16, 216);
            numericUpDownCountSeries.Margin = new Padding(13);
            numericUpDownCountSeries.Name = "numericUpDownCountSeries";
            numericUpDownCountSeries.Size = new Size(449, 33);
            numericUpDownCountSeries.TabIndex = 7;
            // 
            // labelCountSeries
            // 
            labelCountSeries.AutoSize = true;
            labelCountSeries.Dock = DockStyle.Top;
            labelCountSeries.Location = new Point(16, 191);
            labelCountSeries.Margin = new Padding(5, 0, 5, 0);
            labelCountSeries.Name = "labelCountSeries";
            labelCountSeries.Size = new Size(171, 25);
            labelCountSeries.TabIndex = 6;
            labelCountSeries.Text = "Количество серий";
            // 
            // comboBoxType
            // 
            comboBoxType.Dock = DockStyle.Top;
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Location = new Point(16, 158);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(449, 33);
            comboBoxType.TabIndex = 5;
            // 
            // labelType
            // 
            labelType.AutoSize = true;
            labelType.Dock = DockStyle.Top;
            labelType.Location = new Point(16, 133);
            labelType.Margin = new Padding(5, 0, 5, 0);
            labelType.Name = "labelType";
            labelType.Size = new Size(44, 25);
            labelType.TabIndex = 4;
            labelType.Text = "Тип";
            // 
            // textBoxName
            // 
            textBoxName.Dock = DockStyle.Top;
            textBoxName.Location = new Point(16, 100);
            textBoxName.Margin = new Padding(5);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(449, 33);
            textBoxName.TabIndex = 3;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Dock = DockStyle.Top;
            labelName.Location = new Point(16, 75);
            labelName.Margin = new Padding(5, 0, 5, 0);
            labelName.Name = "labelName";
            labelName.Size = new Size(109, 25);
            labelName.TabIndex = 2;
            labelName.Text = "Имя аниме";
            // 
            // labelOriginalName
            // 
            labelOriginalName.AutoSize = true;
            labelOriginalName.Dock = DockStyle.Top;
            labelOriginalName.Location = new Point(16, 17);
            labelOriginalName.Margin = new Padding(5, 0, 5, 0);
            labelOriginalName.Name = "labelOriginalName";
            labelOriginalName.Size = new Size(178, 25);
            labelOriginalName.TabIndex = 0;
            labelOriginalName.Text = "Оригинальное имя";
            // 
            // FormAddUpdateTiitle
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(496, 695);
            Controls.Add(flowLayoutPanel);
            Controls.Add(panelFill);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(5);
            Name = "FormAddUpdateTiitle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Информация об аниме";
            flowLayoutPanel.ResumeLayout(false);
            flowLayoutPanel.PerformLayout();
            panelFill.ResumeLayout(false);
            panelFill.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDuration).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCountSeries).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel;
        private Button btnSaveChanges;
        private Button btnCancel;
        protected internal TextBox textBoxOriginalName;
        private Panel panelFill;
        private Label labelOriginalName;
        private Label labelCountSeries;
        private Label labelType;
        protected internal TextBox textBoxName;
        private Label labelName;
        private Label labelDuration;
        private Label labelDescription;
        protected internal TextBox textBoxStudio;
        private Label labelStudio;
        protected internal ComboBox comboBoxType;
        protected internal NumericUpDown numericUpDownCountSeries;
        protected internal NumericUpDown numericUpDownDuration;
        protected internal RichTextBox richTextBoxDescription;
    }
}