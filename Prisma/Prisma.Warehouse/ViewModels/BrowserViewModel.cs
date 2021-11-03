using Prisma.Infrastructure.Application.Models;
using Prisma.Infrastructure.Browser.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prisma.Warehouse.ViewModels
{
  public class BrowserViewModel : ModelBase
  {
    public BrowserViewModel(IBrowsableObjectService i_browserObjectService)
    {
      m_browsableObjectService = i_browserObjectService;
      BrowsableObjects.AddRange(i_browserObjectService.GetBrowsableObjects());
    }


    public ObservableCollection<IBrowsableObject> BrowsableObjects { get; } = new ObservableCollection<IBrowsableObject>();


    private readonly IBrowsableObjectService m_browsableObjectService;
  }
}
