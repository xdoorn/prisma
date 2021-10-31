using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using Prisma.Warehouse.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prisma.Warehouse
{
  public class WarehouseModule : IModule
  {
    public void RegisterTypes(IContainerRegistry i_containerRegistry)
    {
      i_containerRegistry.Register<MainView>();
    }


    public void OnInitialized(IContainerProvider i_containerProvider)
    {
      var regionManager = i_containerProvider.Resolve<IRegionManager>();
      regionManager.RegisterViewWithRegion("MainRegion", () => i_containerProvider.Resolve<MainView>());
    }

  }
}
