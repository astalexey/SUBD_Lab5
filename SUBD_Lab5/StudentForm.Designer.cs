
namespace SUBD_Lab5
{
    partial class StudentForm
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
            this.comboBoxClass = new System.Windows.Forms.ComboBox();
            this.labelClass = new System.Windows.Forms.Label();
            this.textBoxForeignStudent = new System.Windows.Forms.TextBox();
            this.labelForeignStudent = new System.Windows.Forms.Label();
            this.textBoxDistrict = new System.Windows.Forms.TextBox();
            this.labelDistrict = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelSchedule = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxClass
            // 
            this.comboBoxClass.FormattingEnabled = true;
            this.comboBoxClass.Location = new System.Drawing.Point(126, 108);
            this.comboBoxClass.Name = "comboBoxClass";
            this.comboBoxClass.Size = new System.Drawing.Size(176, 21);
            this.comboBoxClass.TabIndex = 34;
            // 
            // labelClass
            // 
            this.labelClass.AutoSize = true;
            this.labelClass.Location = new System.Drawing.Point(21, 111);
            this.labelClass.Name = "labelClass";
            this.labelClass.Size = new System.Drawing.Size(99, 13);
            this.labelClass.TabIndex = 33;
            this.labelClass.Text = "Название класса:";
            // 
            // textBoxForeignStudent
            // 
            this.textBoxForeignStudent.Location = new System.Drawing.Point(150, 82);
            this.textBoxForeignStudent.Name = "textBoxForeignStudent";
            this.textBoxForeignStudent.Size = new System.Drawing.Size(152, 20);
            this.textBoxForeignStudent.TabIndex = 32;
            // 
            // labelForeignStudent
            // 
            this.labelForeignStudent.AutoSize = true;
            this.labelForeignStudent.Location = new System.Drawing.Point(21, 85);
            this.labelForeignStudent.Name = "labelForeignStudent";
            this.labelForeignStudent.Size = new System.Drawing.Size(121, 13);
            this.labelForeignStudent.TabIndex = 31;
            this.labelForeignStudent.Text = "Иностранный студент:";
            // 
            // textBoxDistrict
            // 
            this.textBoxDistrict.Location = new System.Drawing.Point(108, 56);
            this.textBoxDistrict.Name = "textBoxDistrict";
            this.textBoxDistrict.Size = new System.Drawing.Size(194, 20);
            this.textBoxDistrict.TabIndex = 30;
            // 
            // labelDistrict
            // 
            this.labelDistrict.AutoSize = true;
            this.labelDistrict.Location = new System.Drawing.Point(21, 59);
            this.labelDistrict.Name = "labelDistrict";
            this.labelDistrict.Size = new System.Drawing.Size(41, 13);
            this.labelDistrict.TabIndex = 29;
            this.labelDistrict.Text = "Район:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(115, 30);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(187, 20);
            this.textBoxName.TabIndex = 28;
            // 
            // labelSchedule
            // 
            this.labelSchedule.AutoSize = true;
            this.labelSchedule.Location = new System.Drawing.Point(21, 33);
            this.labelSchedule.Name = "labelSchedule";
            this.labelSchedule.Size = new System.Drawing.Size(60, 13);
            this.labelSchedule.TabIndex = 27;
            this.labelSchedule.Text = "Название:";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(24, 164);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(278, 23);
            this.buttonCancel.TabIndex = 26;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(24, 135);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(278, 23);
            this.buttonSave.TabIndex = 25;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 206);
            this.Controls.Add(this.comboBoxClass);
            this.Controls.Add(this.labelClass);
            this.Controls.Add(this.textBoxForeignStudent);
            this.Controls.Add(this.labelForeignStudent);
            this.Controls.Add(this.textBoxDistrict);
            this.Controls.Add(this.labelDistrict);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelSchedule);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Name = "StudentForm";
            this.Text = "Студент";
            this.Load += new System.EventHandler(this.StudentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxClass;
        private System.Windows.Forms.Label labelClass;
        private System.Windows.Forms.TextBox textBoxForeignStudent;
        private System.Windows.Forms.Label labelForeignStudent;
        private System.Windows.Forms.TextBox textBoxDistrict;
        private System.Windows.Forms.Label labelDistrict;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelSchedule;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
    }
}