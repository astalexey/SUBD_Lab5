using Logic.Logic;
using Logic.Interfaces;
using Implements.Implements;
using System;
using System.Windows.Forms;
using Unity;
using Unity.Lifetime;

namespace SUBD_Lab5
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var container = BuildUnityContainer();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(container.Resolve<MainForm>());
        }
        private static IUnityContainer BuildUnityContainer()
        {
            var currentContainer = new UnityContainer();
            currentContainer.RegisterType<ICityStorage, CityStorage>(new
           HierarchicalLifetimeManager());
            currentContainer.RegisterType<ISchoolStorage, SchoolStorage>(new
          HierarchicalLifetimeManager());
            currentContainer.RegisterType<IStudentStorage, StudentStorage>(new
          HierarchicalLifetimeManager());
            currentContainer.RegisterType<IClassesStorage, ClassesStorage>(new
          HierarchicalLifetimeManager());
            currentContainer.RegisterType<IAdvancementsStorage, AdvancementsStorage>(new
          HierarchicalLifetimeManager());
            currentContainer.RegisterType<CityLogic>(new
           HierarchicalLifetimeManager());
            currentContainer.RegisterType<SchoolLogic>(new
           HierarchicalLifetimeManager());
            currentContainer.RegisterType<ClassesLogic>(new
           HierarchicalLifetimeManager());
            currentContainer.RegisterType<AdvancementsLogic>(new
           HierarchicalLifetimeManager());
            currentContainer.RegisterType<StudentLogic>(new
           HierarchicalLifetimeManager());
            return currentContainer;
        }
    }
}
