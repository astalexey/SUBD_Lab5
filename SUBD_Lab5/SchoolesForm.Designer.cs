
namespace SUBD_Lab5
{
    partial class SchoolesForm
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
            this.dataGridViewSchooles = new System.Windows.Forms.DataGridView();
            this.dataGridViewPickSchooles = new System.Windows.Forms.DataGridView();
            this.labelFree = new System.Windows.Forms.Label();
            this.labelBusy = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSchooles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPickSchooles)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(631, 168);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(157, 46);
            this.buttonBack.TabIndex = 19;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(631, 116);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(157, 46);
            this.buttonEdit.TabIndex = 18;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(631, 64);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(157, 46);
            this.buttonDelete.TabIndex = 17;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(631, 12);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(157, 46);
            this.buttonAdd.TabIndex = 16;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // dataGridViewSchooles
            // 
            this.dataGridViewSchooles.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewSchooles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSchooles.Location = new System.Drawing.Point(12, 15);
            this.dataGridViewSchooles.Name = "dataGridViewSchooles";
            this.dataGridViewSchooles.Size = new System.Drawing.Size(613, 202);
            this.dataGridViewSchooles.TabIndex = 15;
            // 
            // dataGridViewPickSchooles
            // 
            this.dataGridViewPickSchooles.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewPickSchooles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPickSchooles.Location = new System.Drawing.Point(12, 236);
            this.dataGridViewPickSchooles.Name = "dataGridViewPickSchooles";
            this.dataGridViewPickSchooles.Size = new System.Drawing.Size(613, 202);
            this.dataGridViewPickSchooles.TabIndex = 20;
            // 
            // labelFree
            // 
            this.labelFree.AutoSize = true;
            this.labelFree.Location = new System.Drawing.Point(12, 220);
            this.labelFree.Name = "labelFree";
            this.labelFree.Size = new System.Drawing.Size(107, 13);
            this.labelFree.TabIndex = 21;
            this.labelFree.Text = "Школы с выборкой:";
            // 
            // labelBusy
            // 
            this.labelBusy.AutoSize = true;
            this.labelBusy.Location = new System.Drawing.Point(12, -1);
            this.labelBusy.Name = "labelBusy";
            this.labelBusy.Size = new System.Drawing.Size(66, 13);
            this.labelBusy.TabIndex = 22;
            this.labelBusy.Text = "Все школы:";
            // 
            // SchoolesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelBusy);
            this.Controls.Add(this.labelFree);
            this.Controls.Add(this.dataGridViewPickSchooles);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridViewSchooles);
            this.Name = "SchoolesForm";
            this.Text = "Школы";
            this.Load += new System.EventHandler(this.SchoolesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSchooles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPickSchooles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridView dataGridViewSchooles;
        private System.Windows.Forms.DataGridView dataGridViewPickSchooles;
        private System.Windows.Forms.Label labelFree;
        private System.Windows.Forms.Label labelBusy;
    }
}