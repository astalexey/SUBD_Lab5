
namespace SUBD_Lab5
{
    partial class ClassesesForm
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
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.dataGridViewPickClasses = new System.Windows.Forms.DataGridView();
            this.dataGridViewClasses = new System.Windows.Forms.DataGridView();
            this.labelBusy = new System.Windows.Forms.Label();
            this.labelFree = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPickClasses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClasses)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(631, 177);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(157, 46);
            this.buttonBack.TabIndex = 23;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(631, 125);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(157, 46);
            this.buttonEdit.TabIndex = 22;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(631, 73);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(157, 46);
            this.buttonDelete.TabIndex = 21;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(631, 21);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(157, 46);
            this.buttonAdd.TabIndex = 20;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // dataGridViewPickClasses
            // 
            this.dataGridViewPickClasses.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewPickClasses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPickClasses.Location = new System.Drawing.Point(12, 245);
            this.dataGridViewPickClasses.Name = "dataGridViewPickClasses";
            this.dataGridViewPickClasses.Size = new System.Drawing.Size(613, 202);
            this.dataGridViewPickClasses.TabIndex = 25;
            // 
            // dataGridViewClasses
            // 
            this.dataGridViewClasses.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewClasses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClasses.Location = new System.Drawing.Point(12, 21);
            this.dataGridViewClasses.Name = "dataGridViewClasses";
            this.dataGridViewClasses.Size = new System.Drawing.Size(613, 202);
            this.dataGridViewClasses.TabIndex = 24;
            // 
            // labelBusy
            // 
            this.labelBusy.AutoSize = true;
            this.labelBusy.Location = new System.Drawing.Point(12, 5);
            this.labelBusy.Name = "labelBusy";
            this.labelBusy.Size = new System.Drawing.Size(70, 13);
            this.labelBusy.TabIndex = 27;
            this.labelBusy.Text = "Все классы:";
            // 
            // labelFree
            // 
            this.labelFree.AutoSize = true;
            this.labelFree.Location = new System.Drawing.Point(12, 226);
            this.labelFree.Name = "labelFree";
            this.labelFree.Size = new System.Drawing.Size(111, 13);
            this.labelFree.TabIndex = 26;
            this.labelFree.Text = "Классы с выборкой:";
            // 
            // ClassesesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelBusy);
            this.Controls.Add(this.labelFree);
            this.Controls.Add(this.dataGridViewPickClasses);
            this.Controls.Add(this.dataGridViewClasses);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Name = "ClassesesForm";
            this.Text = "Классы";
            this.Load += new System.EventHandler(this.ClassesesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPickClasses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClasses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridView dataGridViewPickClasses;
        private System.Windows.Forms.DataGridView dataGridViewClasses;
        private System.Windows.Forms.Label labelBusy;
        private System.Windows.Forms.Label labelFree;
    }
}