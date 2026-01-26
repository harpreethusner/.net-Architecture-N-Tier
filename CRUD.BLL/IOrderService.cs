using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.BLL
{
    public interface IOrderService
    {
        Guid GetId();
    }

    public class OrderService : IOrderService
    {
        private Guid _id = Guid.NewGuid();
        public Guid GetId() => _id;
    }
}
