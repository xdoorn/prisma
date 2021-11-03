using Prism.Commands;
using Prisma.Infrastructure.Application.Models;
using Prisma.Infrastructure.Browser.Interfaces;
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
    public BrowserViewModel(IBrowsableObjectService i_browserObjectService)
    {
      m_browsableObjectService = i_browserObjectService;
      BrowsableObjects.AddRange(i_browserObjectService.GetBrowsableObjects());

      AttachCommand = new DelegateCommand(OnAttach);
      DetachCommand = new DelegateCommand(OnDetach, CanDetach).ObservesProperty(() => SelectedBrowsableObject);
    }
    

    public ICommand AttachCommand { get => GetProperty<ICommand>(); set => SetProperty(value); }
    public ICommand DetachCommand { get => GetProperty<ICommand>(); set => SetProperty(value); }


    public IBrowsableObject SelectedBrowsableObject { get => GetProperty<IBrowsableObject>(); set => SetProperty(value); }
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


    private readonly IBrowsableObjectService m_browsableObjectService;
  }
}
