using System.Collections.Generic;
using System.ComponentModel;
using Logic.BindingModels;
using Logic.Logic;
using Logic.ViewModels;
using System;
using System.Windows.Forms;
using Unity;

namespace SUBD_Lab5
{
    public partial class MainForm : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        public MainForm()
        {
            InitializeComponent();
        }

        private void фирмыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<CitysForm>();
            form.ShowDialog();
        }


        private void вакансииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<SchoolesForm>();
            form.ShowDialog();
        }

        private void классыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<ClassesesForm>();
            form.ShowDialog();
        }

        private void студентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<StudentsForm>();
            form.ShowDialog();
        }

        private void оценкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<AdvancementsesForm>();
            form.ShowDialog();
        }
    }
}
