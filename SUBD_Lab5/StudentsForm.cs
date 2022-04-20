using Logic.BindingModels;
using Logic.Logic;
using System;
using System.Windows.Forms;
using Unity;

namespace SUBD_Lab5
{
    public partial class StudentsForm : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly StudentLogic logic;
        public StudentsForm(StudentLogic logic)
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
                    dataGridViewStudents.DataSource = listFull;
                    dataGridViewStudents.Columns[0].Visible = false;
                    dataGridViewStudents.Columns[2].AutoSizeMode =
                    DataGridViewAutoSizeColumnMode.Fill;
                }
                var listPick = logic.Read(new StudentBM { District="Leninskyi" });
                if (listPick != null)
                {
                    dataGridViewPickStudents.DataSource = listPick;
                    dataGridViewPickStudents.Columns[0].Visible = false;
                    dataGridViewPickStudents.Columns[2].AutoSizeMode =
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
            var form = Container.Resolve<StudentForm>();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewStudents.SelectedRows.Count == 1 || dataGridViewPickStudents.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Удалить запись", "Вопрос", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id;
                    if (dataGridViewStudents.SelectedRows.Count == 1)
                    {
                        id = Convert.ToInt32(dataGridViewStudents.SelectedRows[0].Cells[0].Value);
                    }
                    else
                    {
                        id = Convert.ToInt32(dataGridViewPickStudents.SelectedRows[0].Cells[0].Value);
                    }
                    try
                    {
                        logic.Delete(new StudentBM { Id = id });
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
            if (dataGridViewStudents.SelectedRows.Count == 1 || dataGridViewPickStudents.SelectedRows.Count == 1)
            {
                var form = Container.Resolve<StudentForm>();
                if (dataGridViewStudents.SelectedRows.Count == 1)
                {
                    form.Id = Convert.ToInt32(dataGridViewStudents.SelectedRows[0].Cells[0].Value);
                }
                else
                {
                    form.Id = Convert.ToInt32(dataGridViewPickStudents.SelectedRows[0].Cells[0].Value);
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

        private void StudentsForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
