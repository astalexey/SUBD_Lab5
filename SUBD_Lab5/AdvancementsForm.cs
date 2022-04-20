using Logic.BindingModels;
using Logic.ViewModels;
using Logic.Logic;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Unity;

namespace SUBD_Lab5
{
    public partial class AdvancementsForm : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        public int Id { set { id = value; } }
        private readonly AdvancementsLogic Vlogic;
        private readonly StudentLogic Flogic;
        private int? id;
        public AdvancementsForm(AdvancementsLogic Vlogic, StudentLogic Flogic)
        {
            InitializeComponent();
            this.Vlogic = Vlogic;
            this.Flogic = Flogic;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxSubject.Text))
            {
                MessageBox.Show("Введите название предмета", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxGrade.Text))
            {
                MessageBox.Show("Введите оценку", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxDate.Text))
            {
                MessageBox.Show("Введите дату", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxRemark.Text))
            {
                MessageBox.Show("Введите замечание", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }
            if (comboBoxStudent.SelectedValue == null)
            {
                MessageBox.Show("Выберите студента", "Ошибка", MessageBoxButtons.OK,
              MessageBoxIcon.Error);
                return;
            }

            try
            {
                AdvancementsBM classes = new AdvancementsBM
                {
                    Id = id,
                    Subject = textBoxSubject.Text,
                    Grade = Convert.ToInt32(textBoxGrade.Text),
                    Date = DateTime.Parse(textBoxDate.Text),
                    Remark = textBoxRemark.Text,
                    StudentId = Convert.ToInt32(comboBoxStudent.SelectedValue),
                };

                Vlogic.CreateOrUpdate(classes);
                MessageBox.Show("Сохранение прошло успешно", "Сообщение",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void AdvancementsForm_Load(object sender, EventArgs e)
        {
            try
            {
                List<StudentVM> list = Flogic.Read(null);
                if (list != null)
                {
                    comboBoxStudent.DisplayMember = "Name";
                    comboBoxStudent.ValueMember = "Id";
                    comboBoxStudent.DataSource = list;
                    comboBoxStudent.SelectedItem = null;
                }
                if (id.HasValue)
                {
                    var view = Vlogic.Read(new AdvancementsBM { Id = id })?[0];
                    if (view != null)
                    {
                        textBoxSubject.Text = view.Subject;
                        textBoxGrade.Text = view.Grade.ToString();
                        textBoxDate.Text = view.Date.ToString();
                        textBoxRemark.Text = view.Remark.ToString();
                        StudentVM city = Flogic.Read(new StudentBM { Name = view.StudentName })?[0];
                        foreach (var currentStudent in list)
                        {
                            if (currentStudent.Name == city.Name)
                            {
                                comboBoxStudent.SelectedItem = currentStudent;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }
    }
}
