using Logic.BindingModels;
using Logic.ViewModels;
using Logic.Logic;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Unity;

namespace SUBD_Lab5
{
    public partial class SchoolForm : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        public int Id { set { id = value; } }
        private readonly SchoolLogic Vlogic;
        private readonly CityLogic Flogic;
        private int? id;
        public SchoolForm(SchoolLogic Vlogic, CityLogic Flogic)
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
            if (string.IsNullOrEmpty(textBoxSchoolNumber.Text))
            {
                MessageBox.Show("Введите номер школы", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxNumberOfStudents.Text))
            {
                MessageBox.Show("Введите количество студентов", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }
            if (comboBoxCity.SelectedValue == null)
            {
                MessageBox.Show("Выберите город", "Ошибка", MessageBoxButtons.OK,
              MessageBoxIcon.Error);
                return;
            }
            try
            {
                SchoolBM school = new SchoolBM
                {
                    Id = id,
                    Name = textBoxName.Text,
                    School_Number = Convert.ToInt32(textBoxSchoolNumber.Text),
                    Number_Of_Students = Convert.ToInt32(textBoxNumberOfStudents.Text),
                    CityId = Convert.ToInt32(comboBoxCity.SelectedValue),
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

        private void SchoolForm_Load(object sender, EventArgs e)
        {
            try
            {
                List<CityVM> list = Flogic.Read(null);
                if (list != null)
                {
                    comboBoxCity.DisplayMember = "Initials";
                    comboBoxCity.ValueMember = "Id";
                    comboBoxCity.DataSource = list;
                    comboBoxCity.SelectedItem = null;
                }
                if (id.HasValue)
                {
                    var view = Vlogic.Read(new SchoolBM { Id = id })?[0];
                    if (view != null)
                    {
                        textBoxName.Text = view.Name;
                        textBoxSchoolNumber.Text = view.School_Number.ToString();
                        textBoxNumberOfStudents.Text = view.Number_Of_Students.ToString();
                        CityVM city = Flogic.Read(new CityBM { Initials = view.CityName })?[0]; 
                        foreach (var currentCity in list)
                        {
                            if (currentCity.Initials == city.Initials)
                            {
                                comboBoxCity.SelectedItem = currentCity;
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
