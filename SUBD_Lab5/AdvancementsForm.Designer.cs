
namespace SUBD_Lab5
{
    partial class AdvancementsForm
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
            this.textBoxRemark = new System.Windows.Forms.TextBox();
            this.labelRemark = new System.Windows.Forms.Label();
            this.comboBoxStudent = new System.Windows.Forms.ComboBox();
            this.labelStudent = new System.Windows.Forms.Label();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.labeDate = new System.Windows.Forms.Label();
            this.textBoxGrade = new System.Windows.Forms.TextBox();
            this.labelGrade = new System.Windows.Forms.Label();
            this.textBoxSubject = new System.Windows.Forms.TextBox();
            this.labelSubject = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxRemark
            // 
            this.textBoxRemark.Location = new System.Drawing.Point(139, 87);
            this.textBoxRemark.Name = "textBoxRemark";
            this.textBoxRemark.Size = new System.Drawing.Size(152, 20);
            this.textBoxRemark.TabIndex = 48;
            // 
            // labelRemark
            // 
            this.labelRemark.AutoSize = true;
            this.labelRemark.Location = new System.Drawing.Point(10, 90);
            this.labelRemark.Name = "labelRemark";
            this.labelRemark.Size = new System.Drawing.Size(80, 13);
            this.labelRemark.TabIndex = 47;
            this.labelRemark.Text = "Комментарий:";
            // 
            // comboBoxStudent
            // 
            this.comboBoxStudent.FormattingEnabled = true;
            this.comboBoxStudent.Location = new System.Drawing.Point(115, 108);
            this.comboBoxStudent.Name = "comboBoxStudent";
            this.comboBoxStudent.Size = new System.Drawing.Size(176, 21);
            this.comboBoxStudent.TabIndex = 46;
            // 
            // labelStudent
            // 
            this.labelStudent.AutoSize = true;
            this.labelStudent.Location = new System.Drawing.Point(10, 111);
            this.labelStudent.Name = "labelStudent";
            this.labelStudent.Size = new System.Drawing.Size(83, 13);
            this.labelStudent.TabIndex = 45;
            this.labelStudent.Text = "Имя студента :";
            // 
            // textBoxDate
            // 
            this.textBoxDate.Location = new System.Drawing.Point(139, 64);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(152, 20);
            this.textBoxDate.TabIndex = 44;
            // 
            // labeDate
            // 
            this.labeDate.AutoSize = true;
            this.labeDate.Location = new System.Drawing.Point(10, 67);
            this.labeDate.Name = "labeDate";
            this.labeDate.Size = new System.Drawing.Size(36, 13);
            this.labeDate.TabIndex = 43;
            this.labeDate.Text = "Дата:";
            // 
            // textBoxGrade
            // 
            this.textBoxGrade.Location = new System.Drawing.Point(97, 38);
            this.textBoxGrade.Name = "textBoxGrade";
            this.textBoxGrade.Size = new System.Drawing.Size(194, 20);
            this.textBoxGrade.TabIndex = 42;
            // 
            // labelGrade
            // 
            this.labelGrade.AutoSize = true;
            this.labelGrade.Location = new System.Drawing.Point(10, 41);
            this.labelGrade.Name = "labelGrade";
            this.labelGrade.Size = new System.Drawing.Size(48, 13);
            this.labelGrade.TabIndex = 41;
            this.labelGrade.Text = "Оценка:";
            // 
            // textBoxSubject
            // 
            this.textBoxSubject.Location = new System.Drawing.Point(104, 12);
            this.textBoxSubject.Name = "textBoxSubject";
            this.textBoxSubject.Size = new System.Drawing.Size(187, 20);
            this.textBoxSubject.TabIndex = 40;
            // 
            // labelSubject
            // 
            this.labelSubject.AutoSize = true;
            this.labelSubject.Location = new System.Drawing.Point(10, 15);
            this.labelSubject.Name = "labelSubject";
            this.labelSubject.Size = new System.Drawing.Size(55, 13);
            this.labelSubject.TabIndex = 39;
            this.labelSubject.Text = "Предмет:";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(13, 164);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(278, 23);
            this.buttonCancel.TabIndex = 38;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(13, 135);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(278, 23);
            this.buttonSave.TabIndex = 37;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // AdvancementsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 216);
            this.Controls.Add(this.textBoxRemark);
            this.Controls.Add(this.labelRemark);
            this.Controls.Add(this.comboBoxStudent);
            this.Controls.Add(this.labelStudent);
            this.Controls.Add(this.textBoxDate);
            this.Controls.Add(this.labeDate);
            this.Controls.Add(this.textBoxGrade);
            this.Controls.Add(this.labelGrade);
            this.Controls.Add(this.textBoxSubject);
            this.Controls.Add(this.labelSubject);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Name = "AdvancementsForm";
            this.Text = "Оценки";
            this.Load += new System.EventHandler(this.AdvancementsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxRemark;
        private System.Windows.Forms.Label labelRemark;
        private System.Windows.Forms.ComboBox comboBoxStudent;
        private System.Windows.Forms.Label labelStudent;
        private System.Windows.Forms.TextBox textBoxDate;
        private System.Windows.Forms.Label labeDate;
        private System.Windows.Forms.TextBox textBoxGrade;
        private System.Windows.Forms.Label labelGrade;
        private System.Windows.Forms.TextBox textBoxSubject;
        private System.Windows.Forms.Label labelSubject;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
    }
}