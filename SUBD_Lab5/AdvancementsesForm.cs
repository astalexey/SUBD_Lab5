using Logic.BindingModels;
using Logic.Logic;
using System;
using System.Windows.Forms;
using Unity;

namespace SUBD_Lab5
{
    public partial class AdvancementsesForm : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly AdvancementsLogic logic;
        public AdvancementsesForm(AdvancementsLogic logic)
        {
            InitializeComponent();
            this.logic = logic;
        }

        private void LoadData()
        {
            try
            {
                var listFull = logic.Read(null);
                if (listFull != null)
                {
                    dataGridViewAdvancements.DataSource = listFull;
                    dataGridViewAdvancements.Columns[0].Visible = false;
                    dataGridViewAdvancements.Columns[2].AutoSizeMode =
                    DataGridViewAutoSizeColumnMode.Fill;
                }
                var listPick = logic.Read(new AdvancementsBM { Grade=3 });
                if (listPick != null)
                {
                    dataGridViewPickAdvancements.DataSource = listPick;
                    dataGridViewPickAdvancements.Columns[0].Visible = false;
                    dataGridViewPickAdvancements.Columns[2].AutoSizeMode =
                    DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<AdvancementsForm>();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewAdvancements.SelectedRows.Count == 1 || dataGridViewPickAdvancements.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Удалить запись", "Вопрос", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id;
                    if (dataGridViewAdvancements.SelectedRows.Count == 1)
                    {
                        id = Convert.ToInt32(dataGridViewAdvancements.SelectedRows[0].Cells[0].Value);
                    }
                    else
                    {
                        id = Convert.ToInt32(dataGridViewPickAdvancements.SelectedRows[0].Cells[0].Value);
                    }
                    try
                    {
                        logic.Delete(new AdvancementsBM { Id = id });
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                    }
                    LoadData();
                }
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewAdvancements.SelectedRows.Count == 1 || dataGridViewPickAdvancements.SelectedRows.Count == 1)
            {
                var form = Container.Resolve<AdvancementsForm>();
                if (dataGridViewAdvancements.SelectedRows.Count == 1)
                {
                    form.Id = Convert.ToInt32(dataGridViewAdvancements.SelectedRows[0].Cells[0].Value);
                }
                else
                {
                    form.Id = Convert.ToInt32(dataGridViewPickAdvancements.SelectedRows[0].Cells[0].Value);
                }
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void AdvancementsesForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
