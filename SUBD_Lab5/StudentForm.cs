using Logic.BindingModels;
using Logic.ViewModels;
using Logic.Logic;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Unity;

namespace SUBD_Lab5
{
    public partial class StudentForm : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        public int Id { set { id = value; } }
        private readonly StudentLogic Vlogic;
        private readonly ClassesLogic Flogic;
        private int? id;
        public StudentForm(StudentLogic Vlogic, ClassesLogic Flogic)
        {
            InitializeComponent();
            this.Vlogic = Vlogic;
            this.Flogic = Flogic;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxName.Text))
            {
                MessageBox.Show("Введите название школы", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxDistrict.Text))
            {
                MessageBox.Show("Введите номер школы", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxForeignStudent.Text))
            {
                MessageBox.Show("Введите количество студентов", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }
            if (comboBoxClass.SelectedValue == null)
            {
                MessageBox.Show("Выберите город", "Ошибка", MessageBoxButtons.OK,
              MessageBoxIcon.Error);
                return;
            }
            try
            {
                StudentBM school = new StudentBM
                {
                    Id = id,
                    Name = textBoxName.Text,
                    District = textBoxDistrict.Text,
                    Foreign_Student = bool.Parse(textBoxForeignStudent.Text),
                    ClassesId = Convert.ToInt32(comboBoxClass.SelectedValue),
                };

                Vlogic.CreateOrUpdate(school);
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

        private void StudentForm_Load(object sender, EventArgs e)
        {
            try
            {
                List<ClassesVM> list = Flogic.Read(null);
                if (list != null)
                {
                    comboBoxClass.DisplayMember = "Name";
                    comboBoxClass.ValueMember = "Id";
                    comboBoxClass.DataSource = list;
                    comboBoxClass.SelectedItem = null;
                }
                if (id.HasValue)
                {
                    var view = Vlogic.Read(new StudentBM { Id = id })?[0];
                    if (view != null)
                    {
                        textBoxName.Text = view.Name;
                        textBoxDistrict.Text = view.District.ToString();
                        textBoxForeignStudent.Text = view.Foreign_Student.ToString();
                        ClassesVM city = Flogic.Read(new ClassesBM { Name = view.ClassesName })?[0];
                        foreach (var currentClasses in list)
                        {
                            if (currentClasses.Name == city.Name)
                            {
                                comboBoxClass.SelectedItem = currentClasses;
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
