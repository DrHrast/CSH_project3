namespace PH_project3
{
    partial class PH_project
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabPH_project = new System.Windows.Forms.TabControl();
            this.tabPhProject = new System.Windows.Forms.TabPage();
            this.tabSpProject = new System.Windows.Forms.TabPage();
            this.checkKeepDataBox = new System.Windows.Forms.CheckBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.datumBox = new System.Windows.Forms.DateTimePicker();
            this.addButton = new System.Windows.Forms.Button();
            this.spolBox = new System.Windows.Forms.ComboBox();
            this.mjestoBox = new System.Windows.Forms.TextBox();
            this.drzavaBox = new System.Windows.Forms.TextBox();
            this.prezimeBox = new System.Windows.Forms.TextBox();
            this.imeBox = new System.Windows.Forms.TextBox();
            this.mjestoLabel = new System.Windows.Forms.Label();
            this.drzavaLabel = new System.Windows.Forms.Label();
            this.datumLabel = new System.Windows.Forms.Label();
            this.spolLabel = new System.Windows.Forms.Label();
            this.prezimeLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.dataPersonView = new System.Windows.Forms.DataGridView();
            this.tabPH_project.SuspendLayout();
            this.tabPhProject.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataPersonView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPH_project
            // 
            this.tabPH_project.Controls.Add(this.tabPhProject);
            this.tabPH_project.Controls.Add(this.tabSpProject);
            this.tabPH_project.Location = new System.Drawing.Point(13, 13);
            this.tabPH_project.Name = "tabPH_project";
            this.tabPH_project.SelectedIndex = 0;
            this.tabPH_project.Size = new System.Drawing.Size(918, 539);
            this.tabPH_project.TabIndex = 0;
            // 
            // tabPhProject
            // 
            this.tabPhProject.Controls.Add(this.checkKeepDataBox);
            this.tabPhProject.Controls.Add(this.progressBar);
            this.tabPhProject.Controls.Add(this.datumBox);
            this.tabPhProject.Controls.Add(this.addButton);
            this.tabPhProject.Controls.Add(this.spolBox);
            this.tabPhProject.Controls.Add(this.mjestoBox);
            this.tabPhProject.Controls.Add(this.drzavaBox);
            this.tabPhProject.Controls.Add(this.prezimeBox);
            this.tabPhProject.Controls.Add(this.imeBox);
            this.tabPhProject.Controls.Add(this.mjestoLabel);
            this.tabPhProject.Controls.Add(this.drzavaLabel);
            this.tabPhProject.Controls.Add(this.datumLabel);
            this.tabPhProject.Controls.Add(this.spolLabel);
            this.tabPhProject.Controls.Add(this.prezimeLabel);
            this.tabPhProject.Controls.Add(this.nameLabel);
            this.tabPhProject.Controls.Add(this.dataPersonView);
            this.tabPhProject.Location = new System.Drawing.Point(4, 22);
            this.tabPhProject.Name = "tabPhProject";
            this.tabPhProject.Padding = new System.Windows.Forms.Padding(3);
            this.tabPhProject.Size = new System.Drawing.Size(910, 513);
            this.tabPhProject.TabIndex = 0;
            this.tabPhProject.Text = "Php";
            this.tabPhProject.UseVisualStyleBackColor = true;
            // 
            // tabSpProject
            // 
            this.tabSpProject.Location = new System.Drawing.Point(4, 22);
            this.tabSpProject.Name = "tabSpProject";
            this.tabSpProject.Padding = new System.Windows.Forms.Padding(3);
            this.tabSpProject.Size = new System.Drawing.Size(910, 513);
            this.tabSpProject.TabIndex = 1;
            this.tabSpProject.Text = "Spp";
            this.tabSpProject.UseVisualStyleBackColor = true;
            // 
            // checkKeepDataBox
            // 
            this.checkKeepDataBox.AutoSize = true;
            this.checkKeepDataBox.Location = new System.Drawing.Point(35, 375);
            this.checkKeepDataBox.Name = "checkKeepDataBox";
            this.checkKeepDataBox.Size = new System.Drawing.Size(77, 17);
            this.checkKeepDataBox.TabIndex = 35;
            this.checkKeepDataBox.Text = "Keep Data";
            this.checkKeepDataBox.UseVisualStyleBackColor = true;
            // 
            // progressBar
            // 
            this.progressBar.ForeColor = System.Drawing.Color.Lime;
            this.progressBar.Location = new System.Drawing.Point(34, 351);
            this.progressBar.Margin = new System.Windows.Forms.Padding(2);
            this.progressBar.Maximum = 102;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(142, 19);
            this.progressBar.Step = 17;
            this.progressBar.TabIndex = 34;
            // 
            // datumBox
            // 
            this.datumBox.CustomFormat = "dd,MM,yyyy";
            this.datumBox.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datumBox.Location = new System.Drawing.Point(78, 216);
            this.datumBox.Margin = new System.Windows.Forms.Padding(2);
            this.datumBox.Name = "datumBox";
            this.datumBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.datumBox.Size = new System.Drawing.Size(102, 20);
            this.datumBox.TabIndex = 30;
            this.datumBox.Value = new System.DateTime(2023, 12, 5, 0, 0, 0, 0);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(34, 394);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(143, 23);
            this.addButton.TabIndex = 33;
            this.addButton.Text = "Dodaj osobu";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // spolBox
            // 
            this.spolBox.FormattingEnabled = true;
            this.spolBox.Location = new System.Drawing.Point(78, 156);
            this.spolBox.Name = "spolBox";
            this.spolBox.Size = new System.Drawing.Size(47, 21);
            this.spolBox.TabIndex = 29;
            // 
            // mjestoBox
            // 
            this.mjestoBox.Location = new System.Drawing.Point(78, 303);
            this.mjestoBox.Name = "mjestoBox";
            this.mjestoBox.Size = new System.Drawing.Size(100, 20);
            this.mjestoBox.TabIndex = 32;
            this.mjestoBox.Validated += new System.EventHandler(this.mjestoBox_Validated);
            // 
            // drzavaBox
            // 
            this.drzavaBox.Location = new System.Drawing.Point(78, 249);
            this.drzavaBox.Name = "drzavaBox";
            this.drzavaBox.Size = new System.Drawing.Size(100, 20);
            this.drzavaBox.TabIndex = 31;
            this.drzavaBox.Validated += new System.EventHandler(this.drzavaBox_Validated);
            // 
            // prezimeBox
            // 
            this.prezimeBox.Location = new System.Drawing.Point(78, 122);
            this.prezimeBox.Name = "prezimeBox";
            this.prezimeBox.Size = new System.Drawing.Size(100, 20);
            this.prezimeBox.TabIndex = 28;
            this.prezimeBox.Validated += new System.EventHandler(this.prezimeBox_Validated);
            // 
            // imeBox
            // 
            this.imeBox.Location = new System.Drawing.Point(78, 87);
            this.imeBox.Name = "imeBox";
            this.imeBox.Size = new System.Drawing.Size(100, 20);
            this.imeBox.TabIndex = 27;
            this.imeBox.Validated += new System.EventHandler(this.imeBox_Validated);
            // 
            // mjestoLabel
            // 
            this.mjestoLabel.AutoSize = true;
            this.mjestoLabel.Location = new System.Drawing.Point(32, 287);
            this.mjestoLabel.Name = "mjestoLabel";
            this.mjestoLabel.Size = new System.Drawing.Size(79, 13);
            this.mjestoLabel.TabIndex = 26;
            this.mjestoLabel.Text = "MjestoRođenja";
            // 
            // drzavaLabel
            // 
            this.drzavaLabel.AutoSize = true;
            this.drzavaLabel.Location = new System.Drawing.Point(32, 256);
            this.drzavaLabel.Name = "drzavaLabel";
            this.drzavaLabel.Size = new System.Drawing.Size(41, 13);
            this.drzavaLabel.TabIndex = 25;
            this.drzavaLabel.Text = "Država";
            // 
            // datumLabel
            // 
            this.datumLabel.AutoSize = true;
            this.datumLabel.Location = new System.Drawing.Point(32, 200);
            this.datumLabel.Name = "datumLabel";
            this.datumLabel.Size = new System.Drawing.Size(79, 13);
            this.datumLabel.TabIndex = 24;
            this.datumLabel.Text = "DatumRođenja";
            // 
            // spolLabel
            // 
            this.spolLabel.AutoSize = true;
            this.spolLabel.Location = new System.Drawing.Point(32, 164);
            this.spolLabel.Name = "spolLabel";
            this.spolLabel.Size = new System.Drawing.Size(28, 13);
            this.spolLabel.TabIndex = 23;
            this.spolLabel.Text = "Spol";
            // 
            // prezimeLabel
            // 
            this.prezimeLabel.AutoSize = true;
            this.prezimeLabel.Location = new System.Drawing.Point(32, 129);
            this.prezimeLabel.Name = "prezimeLabel";
            this.prezimeLabel.Size = new System.Drawing.Size(44, 13);
            this.prezimeLabel.TabIndex = 22;
            this.prezimeLabel.Text = "Prezime";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(32, 94);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(24, 13);
            this.nameLabel.TabIndex = 21;
            this.nameLabel.Text = "Ime";
            // 
            // dataPersonView
            // 
            this.dataPersonView.AllowUserToAddRows = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataPersonView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataPersonView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.Format = "dd/MM/yyyy";
            dataGridViewCellStyle6.NullValue = null;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataPersonView.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataPersonView.Location = new System.Drawing.Point(203, 59);
            this.dataPersonView.Name = "dataPersonView";
            this.dataPersonView.ReadOnly = true;
            this.dataPersonView.Size = new System.Drawing.Size(676, 395);
            this.dataPersonView.TabIndex = 20;
            // 
            // PH_project
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 564);
            this.Controls.Add(this.tabPH_project);
            this.Name = "PH_project";
            this.Text = "PH_project";
            this.tabPH_project.ResumeLayout(false);
            this.tabPhProject.ResumeLayout(false);
            this.tabPhProject.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataPersonView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabPH_project;
        private System.Windows.Forms.TabPage tabPhProject;
        private System.Windows.Forms.TabPage tabSpProject;
        private System.Windows.Forms.CheckBox checkKeepDataBox;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.DateTimePicker datumBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ComboBox spolBox;
        private System.Windows.Forms.TextBox mjestoBox;
        private System.Windows.Forms.TextBox drzavaBox;
        private System.Windows.Forms.TextBox prezimeBox;
        private System.Windows.Forms.TextBox imeBox;
        private System.Windows.Forms.Label mjestoLabel;
        private System.Windows.Forms.Label drzavaLabel;
        private System.Windows.Forms.Label datumLabel;
        private System.Windows.Forms.Label spolLabel;
        private System.Windows.Forms.Label prezimeLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.DataGridView dataPersonView;
    }
}

