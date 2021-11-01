using Prism;
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
  public class RibbonTabViewModel : ModelBase, IMainModule, IActiveAware
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


    public bool IsActive
    {
      get { return GetProperty<bool>(); }
      set
      {
        if (SetProperty(value))
        {
          m_regionManager.RequestNavigate("WorkspaceRegion", "WarehouseMainView");
          IsActiveChanged?.Invoke(this, new EventArgs());
        }
      }
    }

    public event EventHandler IsActiveChanged;


    private readonly IRegionManager m_regionManager = null;
  }
}
