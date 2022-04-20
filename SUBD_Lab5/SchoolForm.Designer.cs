
namespace SUBD_Lab5
{
    partial class SchoolForm
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.comboBoxCity = new System.Windows.Forms.ComboBox();
            this.labelCity = new System.Windows.Forms.Label();
            this.textBoxNumberOfStudents = new System.Windows.Forms.TextBox();
            this.labelSalary = new System.Windows.Forms.Label();
            this.textBoxSchoolNumber = new System.Windows.Forms.TextBox();
            this.labelPosition = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelSchedule = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(12, 146);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(278, 23);
            this.buttonCancel.TabIndex = 14;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(12, 117);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(278, 23);
            this.buttonSave.TabIndex = 13;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // comboBoxCity
            // 
            this.comboBoxCity.FormattingEnabled = true;
            this.comboBoxCity.Location = new System.Drawing.Point(114, 90);
            this.comboBoxCity.Name = "comboBoxCity";
            this.comboBoxCity.Size = new System.Drawing.Size(176, 21);
            this.comboBoxCity.TabIndex = 24;
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(9, 93);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(98, 13);
            this.labelCity.TabIndex = 23;
            this.labelCity.Text = "Название города:";
            // 
            // textBoxNumberOfStudents
            // 
            this.textBoxNumberOfStudents.Location = new System.Drawing.Point(138, 64);
            this.textBoxNumberOfStudents.Name = "textBoxNumberOfStudents";
            this.textBoxNumberOfStudents.Size = new System.Drawing.Size(152, 20);
            this.textBoxNumberOfStudents.TabIndex = 22;
            // 
            // labelSalary
            // 
            this.labelSalary.AutoSize = true;
            this.labelSalary.Location = new System.Drawing.Point(9, 67);
            this.labelSalary.Name = "labelSalary";
            this.labelSalary.Size = new System.Drawing.Size(123, 13);
            this.labelSalary.TabIndex = 21;
            this.labelSalary.Text = "Количество студентов:";
            // 
            // textBoxSchoolNumber
            // 
            this.textBoxSchoolNumber.Location = new System.Drawing.Point(96, 38);
            this.textBoxSchoolNumber.Name = "textBoxSchoolNumber";
            this.textBoxSchoolNumber.Size = new System.Drawing.Size(194, 20);
            this.textBoxSchoolNumber.TabIndex = 20;
            // 
            // labelPosition
            // 
            this.labelPosition.AutoSize = true;
            this.labelPosition.Location = new System.Drawing.Point(9, 41);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(81, 13);
            this.labelPosition.TabIndex = 19;
            this.labelPosition.Text = "Номер школы:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(103, 12);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(187, 20);
            this.textBoxName.TabIndex = 18;
            // 
            // labelSchedule
            // 
            this.labelSchedule.AutoSize = true;
            this.labelSchedule.Location = new System.Drawing.Point(9, 15);
            this.labelSchedule.Name = "labelSchedule";
            this.labelSchedule.Size = new System.Drawing.Size(60, 13);
            this.labelSchedule.TabIndex = 17;
            this.labelSchedule.Text = "Название:";
            // 
            // SchoolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 173);
            this.Controls.Add(this.comboBoxCity);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.textBoxNumberOfStudents);
            this.Controls.Add(this.labelSalary);
            this.Controls.Add(this.textBoxSchoolNumber);
            this.Controls.Add(this.labelPosition);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelSchedule);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Name = "SchoolForm";
            this.Text = "Школа";
            this.Load += new System.EventHandler(this.SchoolForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.ComboBox comboBoxCity;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.TextBox textBoxNumberOfStudents;
        private System.Windows.Forms.Label labelSalary;
        private System.Windows.Forms.TextBox textBoxSchoolNumber;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelSchedule;
    }
}