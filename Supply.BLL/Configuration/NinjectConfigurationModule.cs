using Ninject.Modules;
using Supply.DAL.EF;
using Supply.DAL.Interfaces;

namespace Supply.BLL.Configuration
{
    class NinjectConfigurationModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IUnitOfWork>().To<EFUnitOfWork>().InTransientScope();
        }
    }
}
