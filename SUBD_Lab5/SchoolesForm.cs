using Logic.BindingModels;
using Logic.Logic;
using System;
using System.Windows.Forms;
using Unity;

namespace SUBD_Lab5
{
    public partial class SchoolesForm : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly SchoolLogic logic;
        public SchoolesForm(SchoolLogic logic)
        {
            InitializeComponent();
            this.logic = logic;
        }

        private void LoadData()
        {
            try
            {
                var listFull = logic.Read( null );
                if (listFull != null)
                {
                    dataGridViewSchooles.DataSource = listFull;
                    dataGridViewSchooles.Columns[0].Visible = false;
                    dataGridViewSchooles.Columns[2].AutoSizeMode =
                    DataGridViewAutoSizeColumnMode.Fill;
                }
                var listPick = logic.Read(new SchoolBM { Name="first" });
                if (listPick != null)
                {
                    dataGridViewPickSchooles.DataSource = listPick;
                    dataGridViewPickSchooles.Columns[0].Visible = false;
                    dataGridViewPickSchooles.Columns[2].AutoSizeMode =
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
            var form = Container.Resolve<SchoolForm>();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewSchooles.SelectedRows.Count == 1 || dataGridViewPickSchooles.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Удалить запись", "Вопрос", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id;
                    if (dataGridViewSchooles.SelectedRows.Count == 1)
                    {
                        id = Convert.ToInt32(dataGridViewSchooles.SelectedRows[0].Cells[0].Value);
                    }
                    else
                    {
                        id = Convert.ToInt32(dataGridViewPickSchooles.SelectedRows[0].Cells[0].Value);
                    } 
                    try
                    {
                        logic.Delete(new SchoolBM { Id = id });
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
            if (dataGridViewSchooles.SelectedRows.Count == 1 || dataGridViewPickSchooles.SelectedRows.Count == 1)
            {
                var form = Container.Resolve<SchoolForm>();
                if (dataGridViewSchooles.SelectedRows.Count == 1)
                {
                    form.Id = Convert.ToInt32(dataGridViewSchooles.SelectedRows[0].Cells[0].Value);
                }
                else
                {
                    form.Id = Convert.ToInt32(dataGridViewPickSchooles.SelectedRows[0].Cells[0].Value);
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

        private void SchoolesForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
