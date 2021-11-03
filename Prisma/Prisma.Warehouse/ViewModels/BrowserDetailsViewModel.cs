using Prism.Events;
using Prisma.Infrastructure.Application.Models;
using Prisma.Infrastructure.Browser.Events;
using Prisma.Infrastructure.Browser.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prisma.Warehouse.ViewModels
{
  public class BrowserDetailsViewModel : ModelBase
  {
    public BrowserDetailsViewModel(IEventAggregator i_eventAggregator)
    {
      i_eventAggregator.GetEvent<BrowsableObjectSelectedEvent>().Subscribe(OnBrowsableObjectSelected);
    }


    public IBrowsableObject BrowsableObject { get => GetProperty<IBrowsableObject>(); set => SetProperty(value); }

    private void OnBrowsableObjectSelected(IBrowsableObject i_selectedBrowsableObject)
    {
      BrowsableObject = i_selectedBrowsableObject;
    }
  }
}
