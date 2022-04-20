
namespace SUBD_Lab5
{
    partial class AdvancementsesForm
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
            this.dataGridViewPickAdvancements = new System.Windows.Forms.DataGridView();
            this.dataGridViewAdvancements = new System.Windows.Forms.DataGridView();
            this.labelBusy = new System.Windows.Forms.Label();
            this.labelFree = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPickAdvancements)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdvancements)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(631, 182);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(157, 46);
            this.buttonBack.TabIndex = 23;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(631, 130);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(157, 46);
            this.buttonEdit.TabIndex = 22;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(631, 78);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(157, 46);
            this.buttonDelete.TabIndex = 21;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(631, 26);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(157, 46);
            this.buttonAdd.TabIndex = 20;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // dataGridViewPickAdvancements
            // 
            this.dataGridViewPickAdvancements.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewPickAdvancements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPickAdvancements.Location = new System.Drawing.Point(12, 250);
            this.dataGridViewPickAdvancements.Name = "dataGridViewPickAdvancements";
            this.dataGridViewPickAdvancements.Size = new System.Drawing.Size(613, 202);
            this.dataGridViewPickAdvancements.TabIndex = 25;
            // 
            // dataGridViewAdvancements
            // 
            this.dataGridViewAdvancements.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewAdvancements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAdvancements.Location = new System.Drawing.Point(12, 26);
            this.dataGridViewAdvancements.Name = "dataGridViewAdvancements";
            this.dataGridViewAdvancements.Size = new System.Drawing.Size(613, 202);
            this.dataGridViewAdvancements.TabIndex = 24;
            // 
            // labelBusy
            // 
            this.labelBusy.AutoSize = true;
            this.labelBusy.Location = new System.Drawing.Point(12, 10);
            this.labelBusy.Name = "labelBusy";
            this.labelBusy.Size = new System.Drawing.Size(48, 13);
            this.labelBusy.TabIndex = 27;
            this.labelBusy.Text = "Оценки:";
            // 
            // labelFree
            // 
            this.labelFree.AutoSize = true;
            this.labelFree.Location = new System.Drawing.Point(12, 231);
            this.labelFree.Name = "labelFree";
            this.labelFree.Size = new System.Drawing.Size(110, 13);
            this.labelFree.TabIndex = 26;
            this.labelFree.Text = "Оценки с выборкой:";
            // 
            // AdvancementsesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelBusy);
            this.Controls.Add(this.labelFree);
            this.Controls.Add(this.dataGridViewPickAdvancements);
            this.Controls.Add(this.dataGridViewAdvancements);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Name = "AdvancementsesForm";
            this.Text = "Оценки";
            this.Load += new System.EventHandler(this.AdvancementsesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPickAdvancements)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdvancements)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridView dataGridViewPickAdvancements;
        private System.Windows.Forms.DataGridView dataGridViewAdvancements;
        private System.Windows.Forms.Label labelBusy;
        private System.Windows.Forms.Label labelFree;
    }
}