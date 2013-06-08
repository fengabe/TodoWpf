using AutoMapper;
using Microsoft.Practices.Unity;
using TodoWpf.Business;
using TodoWpf.Model;
using TodoWpf.ViewModel;

namespace TodoWpf
{
    /// <summary>
    /// Application bootstrapper / IoC container
    /// and mapper configuraions
    /// </summary>
    public class Bootstraper
    {
        public IUnityContainer Container { get; set; }

        public Bootstraper()
        {
            Container = new UnityContainer();
            ConfigureContainer();
            ConfigureMapper();
        }

        /// <summary>
        /// IoC container
        /// </summary>
        private void ConfigureContainer()
        {
            Container.RegisterType<ITodoRepository, TodoRepository>();
        }

        /// <summary>
        /// Mapping configurations
        /// </summary>
        private void ConfigureMapper()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<TodoItem, TodoItemViewModel>();
                cfg.CreateMap<TodoItemViewModel, TodoItem>();
            });
        }
    }
}
