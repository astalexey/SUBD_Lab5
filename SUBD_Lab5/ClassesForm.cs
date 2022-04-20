using Logic.BindingModels;
using Logic.ViewModels;
using Logic.Logic;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Unity;

namespace SUBD_Lab5
{
    public partial class ClassesForm : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        public int Id { set { id = value; } }
        private readonly ClassesLogic Vlogic;
        private readonly SchoolLogic Flogic;
        private int? id;
        public ClassesForm(ClassesLogic Vlogic, SchoolLogic Flogic)
        {
            InitializeComponent();
            this.Vlogic = Vlogic;
            this.Flogic = Flogic;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxName.Text))
            {
                MessageBox.Show("Введите название класса", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxCurator.Text))
            {
                MessageBox.Show("Введите куратора", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxCourse.Text))
            {
                MessageBox.Show("Введите курс", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxSpecialization.Text))
            {
                MessageBox.Show("Введите специализацию", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }
            if (comboBoxSchool.SelectedValue == null)
            {
                MessageBox.Show("Выберите школу", "Ошибка", MessageBoxButtons.OK,
              MessageBoxIcon.Error);
                return;
            }
            
            try
            {
                ClassesBM classes = new ClassesBM
                {
                    Id = id,
                    Name = textBoxName.Text,
                    Curator = textBoxCurator.Text,
                    Course = Convert.ToInt32(textBoxCourse.Text),
                    Specialization= textBoxCourse.Text,
                    SchoolId = Convert.ToInt32(comboBoxSchool.SelectedValue),
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

        private void ClassesForm_Load(object sender, EventArgs e)
        {
            try
            {
                List<SchoolVM> list = Flogic.Read(null);
                if (list != null)
                {
                    comboBoxSchool.DisplayMember = "Name";
                    comboBoxSchool.ValueMember = "Id";
                    comboBoxSchool.DataSource = list;
                    comboBoxSchool.SelectedItem = null;
                }
                if (id.HasValue)
                {
                    var view = Vlogic.Read(new ClassesBM { Id = id })?[0];
                    if (view != null)
                    {
                        textBoxName.Text = view.Name;
                        textBoxCurator.Text = view.Curator.ToString();
                        textBoxCourse.Text = view.Course.ToString();
                        textBoxSpecialization.Text = view.Course.ToString();
                        SchoolVM city = Flogic.Read(new SchoolBM { Name = view.SchoolName })?[0];
                        foreach (var currentSchool in list)
                        {
                            if (currentSchool.Name == city.Name)
                            {
                                comboBoxSchool.SelectedItem = currentSchool;
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
