using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prisma.Warehouse.Models
{
  public class WarehouseCommands
  {
    public CompositeCommand AttachCommand { get; } = new CompositeCommand();
    public CompositeCommand DetachCommand { get; } = new CompositeCommand();
  }
}
