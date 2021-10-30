using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Prisma.Infrastructure.Application.Models
{
  public class ModelBase : INotifyPropertyChanged
  {
    #region Public

    public void OnPropertyChanged([CallerMemberName] string i_propertyName = null)
    {
      PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(i_propertyName));
    }


    public bool SetProperty(object i_newValue, bool i_notifySubscribers = true, [CallerMemberName] string i_propertyName = null)
    {
      object oldValue = GetProperty(i_propertyName);

      bool isValueChanged = IsValueChanged(oldValue, i_newValue);
      if (isValueChanged)
      {
        m_properties[i_propertyName] = i_newValue;

        if (i_notifySubscribers)
        {
          OnPropertyChanged(i_propertyName);
        }
      }

      return isValueChanged;
    }


    public T GetProperty<T>([CallerMemberName] string i_propertyName = null)
    {
      T propertyValue = default(T);

      object value = GetProperty(i_propertyName);
      if (value != null)
      {
        propertyValue = (T) value;
      }

      return propertyValue;
    }


    public object GetProperty([CallerMemberName] string i_propertyName = null)
    {
      object value = null;
      m_properties.TryGetValue(i_propertyName, out value);
      return value;
    }


    public event PropertyChangedEventHandler PropertyChanged;

    #endregion

    #region Private

    private bool IsValueChanged(object i_left, object i_right)
    {
      bool isChanged = false;

      if (i_left == null)
      {
        isChanged = i_right != null;
      }
      else
      {
        isChanged = !i_left.Equals(i_right);
      }

      return isChanged;
    }


    private readonly Dictionary<string, object> m_properties = new Dictionary<string, object>();

    #endregion
  }
}
