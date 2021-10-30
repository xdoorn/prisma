// Using .NET
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Using Prism
using Prism.Commands;
using Prism.Mvvm;

// Using Prisma
using Prisma.Services;


namespace Prisma.ViewModels
{
  public class ShellViewModel : BindableBase
  {
    private Services.ICustomerStore _customerStore = null;

    public ShellViewModel(ICustomerStore customerStore)
    {
      _customerStore = customerStore;
    }


    public ObservableCollection<string> Customers { get; private set; } = new ObservableCollection<string>();


    private string _selectedCustomer = null;
    public string SelectedCustomer
    {
      get => _selectedCustomer;
      set
      {
        if (SetProperty<string>(ref _selectedCustomer, value))
        {
          Debug.WriteLine(_selectedCustomer ?? "no customer selected");
        }
      }
    }

    private DelegateCommand _commandLoad = null;
    public DelegateCommand CommandLoad => _commandLoad ?? (_commandLoad = new DelegateCommand(CommandLoadExecute));

    private void CommandLoadExecute()
    {
      Customers.Clear();
      foreach (string customer in _customerStore.GetAll())
      {
        Customers.Add(customer);
      }
    }
  }
}
