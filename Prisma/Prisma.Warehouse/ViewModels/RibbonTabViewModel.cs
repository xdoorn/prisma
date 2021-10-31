using Prism.Regions;
using Prisma.Infrastructure.Application.Models;
using Prisma.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prisma.Warehouse.ViewModels
{
  public class RibbonTabViewModel : ModelBase, IMainModule
  {
    public RibbonTabViewModel(IRegionManager i_regionManager)
    {
      m_regionManager = i_regionManager;
    }


    public string Title
    {
      get { return GetProperty<string>("Warehouse"); }
      set { SetProperty(value); }
    }


    public bool IsSelected
    {
      get { return GetProperty<bool>(); }
      set
      {
        if (SetProperty(value))
        {
          m_regionManager.RequestNavigate("WorkspaceRegion", "WarehouseMainView");
        }
      }
    }


    private readonly IRegionManager m_regionManager = null;
  }
}
