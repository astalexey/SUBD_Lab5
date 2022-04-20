using Logic.BindingModels;
using Logic.Logic;
using System;
using System.Windows.Forms;
using Unity;

namespace SUBD_Lab5
{
    public partial class CityForm : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        public int Id { set { id = value; } }
        private readonly CityLogic logic;
        private int? id;

        public CityForm(CityLogic logic)
        {
            InitializeComponent();
            this.logic = logic;
        }

        private void CreateCityForm_Load(object sender, EventArgs e)
        {
            if (id.HasValue)

            {
                try
                {
                    var view = logic.Read(new CityBM { Id = id })?[0];
                    if (view != null)
                    {
                        textBoxInitials.Text = view.Initials;
                        textBoxRegion.Text = view.Region;
                        textBoxPopulation.Text = view.Population.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxInitials.Text))
            {
                MessageBox.Show("Введите название", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxRegion.Text))
            {
                MessageBox.Show("Введите регион", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxPopulation.Text))
            {
                MessageBox.Show("Введите население", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }
            try
            {
                logic.CreateOrUpdate(new CityBM
                {
                    Id = id,
                    Initials = textBoxInitials.Text,
                    Region = textBoxRegion.Text,
                    Population = Convert.ToInt32(textBoxPopulation.Text)
                });
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
    }
}
