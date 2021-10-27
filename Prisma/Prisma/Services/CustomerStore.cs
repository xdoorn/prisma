using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prisma.Services
{
  public interface ICustomerStore
  {
    List<string> GetAll();
  }


  public class DbCustomerStore : ICustomerStore
  {
    public List<string> GetAll()
    {
      return new List<string>()
        {
          "customer 1",
          "customer 2",
          "customer 3",
        };
    }
  }
}