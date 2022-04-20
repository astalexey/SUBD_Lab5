using Logic.BindingModels;
using Logic.Logic;
using System;
using System.Windows.Forms;
using Unity;

namespace SUBD_Lab5
{
    public partial class ClassesesForm : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly ClassesLogic logic;
        public ClassesesForm(ClassesLogic logic)
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
                    dataGridViewClasses.DataSource = listFull;
                    dataGridViewClasses.Columns[0].Visible = false;
                    dataGridViewClasses.Columns[2].AutoSizeMode =
                    DataGridViewAutoSizeColumnMode.Fill;
                }
                var listPick = logic.Read(new ClassesBM { Course = 3 });
                if (listPick != null)
                {
                    dataGridViewPickClasses.DataSource = listPick;
                    dataGridViewPickClasses.Columns[0].Visible = false;
                    dataGridViewPickClasses.Columns[2].AutoSizeMode =
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
            var form = Container.Resolve<ClassesForm>();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewClasses.SelectedRows.Count == 1 || dataGridViewPickClasses.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Удалить запись", "Вопрос", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id;
                    if (dataGridViewClasses.SelectedRows.Count == 1)
                    {
                        id = Convert.ToInt32(dataGridViewClasses.SelectedRows[0].Cells[0].Value);
                    }
                    else
                    {
                        id = Convert.ToInt32(dataGridViewPickClasses.SelectedRows[0].Cells[0].Value);
                    }
                    try
                    {
                        logic.Delete(new ClassesBM { Id = id });
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
            if (dataGridViewClasses.SelectedRows.Count == 1 || dataGridViewPickClasses.SelectedRows.Count == 1)
            {
                var form = Container.Resolve<ClassesForm>();
                if (dataGridViewClasses.SelectedRows.Count == 1)
                {
                    form.Id = Convert.ToInt32(dataGridViewClasses.SelectedRows[0].Cells[0].Value);
                }
                else
                {
                    form.Id = Convert.ToInt32(dataGridViewPickClasses.SelectedRows[0].Cells[0].Value);
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

        private void ClassesesForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
