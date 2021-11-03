using Prism.Commands;
using Prism.Events;
using Prisma.Infrastructure.Application.Models;
using Prisma.Infrastructure.Browser.Events;
using Prisma.Infrastructure.Browser.Interfaces;
using Prisma.Warehouse.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Prisma.Warehouse.ViewModels
{
  public class BrowserViewModel : ModelBase
  {
    public BrowserViewModel(
      IEventAggregator i_eventAggregator,
      WarehouseCommands i_warehouseCommands, 
      IBrowsableObjectService i_browserObjectService)
    {
      m_eventAggregator = i_eventAggregator;

      AttachCommand = new DelegateCommand(OnAttach);
      DetachCommand = new DelegateCommand(OnDetach, CanDetach).ObservesProperty(() => SelectedBrowsableObject);
      i_warehouseCommands.AttachCommand.RegisterCommand(AttachCommand);
      i_warehouseCommands.DetachCommand.RegisterCommand(DetachCommand);

      m_browsableObjectService = i_browserObjectService;
      BrowsableObjects.AddRange(i_browserObjectService.GetBrowsableObjects());
    }
    

    public ICommand AttachCommand { get => GetProperty<ICommand>(); set => SetProperty(value); }
    public ICommand DetachCommand { get => GetProperty<ICommand>(); set => SetProperty(value); }


    public IBrowsableObject SelectedBrowsableObject 
    { 
      get => GetProperty<IBrowsableObject>();
      set
      {
        if (SetProperty(value))
        {
          m_eventAggregator.GetEvent<BrowsableObjectSelectedEvent>().Publish(value);
        }
      }
    }


    public ObservableCollection<IBrowsableObject> BrowsableObjects { get; } = new ObservableCollection<IBrowsableObject>();


    private void OnAttach()
    {
      BrowsableObjects.Add(m_browsableObjectService.AttachBrowsableObject());
    }


    private bool CanDetach()
    {
      return SelectedBrowsableObject != null;
    }


    private void OnDetach()
    {
      BrowsableObjects.Remove(SelectedBrowsableObject);
    }


    private readonly IEventAggregator m_eventAggregator;
    private readonly IBrowsableObjectService m_browsableObjectService;
  }
}
