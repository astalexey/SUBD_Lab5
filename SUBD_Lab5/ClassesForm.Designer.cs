
namespace SUBD_Lab5
{
    partial class ClassesForm
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
            this.comboBoxSchool = new System.Windows.Forms.ComboBox();
            this.labelCity = new System.Windows.Forms.Label();
            this.textBoxCourse = new System.Windows.Forms.TextBox();
            this.labelCourse = new System.Windows.Forms.Label();
            this.textBoxCurator = new System.Windows.Forms.TextBox();
            this.labelCurator = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelSchedule = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxSpecialization = new System.Windows.Forms.TextBox();
            this.labelSpecialization = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxSchool
            // 
            this.comboBoxSchool.FormattingEnabled = true;
            this.comboBoxSchool.Location = new System.Drawing.Point(117, 102);
            this.comboBoxSchool.Name = "comboBoxSchool";
            this.comboBoxSchool.Size = new System.Drawing.Size(176, 21);
            this.comboBoxSchool.TabIndex = 34;
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(12, 105);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(97, 13);
            this.labelCity.TabIndex = 33;
            this.labelCity.Text = "Название школы:";
            // 
            // textBoxCourse
            // 
            this.textBoxCourse.Location = new System.Drawing.Point(141, 58);
            this.textBoxCourse.Name = "textBoxCourse";
            this.textBoxCourse.Size = new System.Drawing.Size(152, 20);
            this.textBoxCourse.TabIndex = 32;
            // 
            // labelCourse
            // 
            this.labelCourse.AutoSize = true;
            this.labelCourse.Location = new System.Drawing.Point(12, 61);
            this.labelCourse.Name = "labelCourse";
            this.labelCourse.Size = new System.Drawing.Size(34, 13);
            this.labelCourse.TabIndex = 31;
            this.labelCourse.Text = "Курс:";
            // 
            // textBoxCurator
            // 
            this.textBoxCurator.Location = new System.Drawing.Point(99, 32);
            this.textBoxCurator.Name = "textBoxCurator";
            this.textBoxCurator.Size = new System.Drawing.Size(194, 20);
            this.textBoxCurator.TabIndex = 30;
            // 
            // labelCurator
            // 
            this.labelCurator.AutoSize = true;
            this.labelCurator.Location = new System.Drawing.Point(12, 35);
            this.labelCurator.Name = "labelCurator";
            this.labelCurator.Size = new System.Drawing.Size(51, 13);
            this.labelCurator.TabIndex = 29;
            this.labelCurator.Text = "Куратор:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(106, 6);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(187, 20);
            this.textBoxName.TabIndex = 28;
            // 
            // labelSchedule
            // 
            this.labelSchedule.AutoSize = true;
            this.labelSchedule.Location = new System.Drawing.Point(12, 9);
            this.labelSchedule.Name = "labelSchedule";
            this.labelSchedule.Size = new System.Drawing.Size(60, 13);
            this.labelSchedule.TabIndex = 27;
            this.labelSchedule.Text = "Название:";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(15, 158);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(278, 23);
            this.buttonCancel.TabIndex = 26;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(15, 129);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(278, 23);
            this.buttonSave.TabIndex = 25;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxSpecialization
            // 
            this.textBoxSpecialization.Location = new System.Drawing.Point(141, 81);
            this.textBoxSpecialization.Name = "textBoxSpecialization";
            this.textBoxSpecialization.Size = new System.Drawing.Size(152, 20);
            this.textBoxSpecialization.TabIndex = 36;
            // 
            // labelSpecialization
            // 
            this.labelSpecialization.AutoSize = true;
            this.labelSpecialization.Location = new System.Drawing.Point(12, 84);
            this.labelSpecialization.Name = "labelSpecialization";
            this.labelSpecialization.Size = new System.Drawing.Size(89, 13);
            this.labelSpecialization.TabIndex = 35;
            this.labelSpecialization.Text = "Специализация:";
            // 
            // ClassesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 187);
            this.Controls.Add(this.textBoxSpecialization);
            this.Controls.Add(this.labelSpecialization);
            this.Controls.Add(this.comboBoxSchool);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.textBoxCourse);
            this.Controls.Add(this.labelCourse);
            this.Controls.Add(this.textBoxCurator);
            this.Controls.Add(this.labelCurator);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelSchedule);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Name = "ClassesForm";
            this.Text = "Класс";
            this.Load += new System.EventHandler(this.ClassesForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxSchool;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.TextBox textBoxCourse;
        private System.Windows.Forms.Label labelCourse;
        private System.Windows.Forms.TextBox textBoxCurator;
        private System.Windows.Forms.Label labelCurator;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelSchedule;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxSpecialization;
        private System.Windows.Forms.Label labelSpecialization;
    }
}