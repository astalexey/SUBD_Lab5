
namespace SUBD_Lab5
{
    partial class CityForm
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
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxInitials = new System.Windows.Forms.TextBox();
            this.textBoxRegion = new System.Windows.Forms.TextBox();
            this.labelRegion = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelPopulation = new System.Windows.Forms.Label();
            this.textBoxPopulation = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(9, 17);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(60, 13);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Название:";
            // 
            // textBoxInitials
            // 
            this.textBoxInitials.Location = new System.Drawing.Point(75, 14);
            this.textBoxInitials.Name = "textBoxInitials";
            this.textBoxInitials.Size = new System.Drawing.Size(215, 20);
            this.textBoxInitials.TabIndex = 2;
            // 
            // textBoxRegion
            // 
            this.textBoxRegion.Location = new System.Drawing.Point(56, 40);
            this.textBoxRegion.Name = "textBoxRegion";
            this.textBoxRegion.Size = new System.Drawing.Size(234, 20);
            this.textBoxRegion.TabIndex = 5;
            // 
            // labelRegion
            // 
            this.labelRegion.AutoSize = true;
            this.labelRegion.Location = new System.Drawing.Point(9, 43);
            this.labelRegion.Name = "labelRegion";
            this.labelRegion.Size = new System.Drawing.Size(46, 13);
            this.labelRegion.TabIndex = 4;
            this.labelRegion.Text = "Регион:";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(12, 94);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(278, 23);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(12, 123);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(278, 23);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelPopulation
            // 
            this.labelPopulation.AutoSize = true;
            this.labelPopulation.Location = new System.Drawing.Point(9, 69);
            this.labelPopulation.Name = "labelPopulation";
            this.labelPopulation.Size = new System.Drawing.Size(66, 13);
            this.labelPopulation.TabIndex = 7;
            this.labelPopulation.Text = "Население:";
            // 
            // textBoxPopulation
            // 
            this.textBoxPopulation.Location = new System.Drawing.Point(75, 66);
            this.textBoxPopulation.Name = "textBoxPopulation";
            this.textBoxPopulation.Size = new System.Drawing.Size(215, 20);
            this.textBoxPopulation.TabIndex = 8;
            // 
            // CityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 158);
            this.Controls.Add(this.textBoxPopulation);
            this.Controls.Add(this.labelPopulation);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.textBoxRegion);
            this.Controls.Add(this.labelRegion);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxInitials);
            this.Controls.Add(this.labelName);
            this.Name = "CityForm";
            this.Text = "Город";
            this.Load += new System.EventHandler(this.CreateCityForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxInitials;
        private System.Windows.Forms.TextBox textBoxRegion;
        private System.Windows.Forms.Label labelRegion;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelPopulation;
        private System.Windows.Forms.TextBox textBoxPopulation;
    }
}