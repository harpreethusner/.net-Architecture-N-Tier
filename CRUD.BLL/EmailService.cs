using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.BLL
{
    public class EmailService : IEmailService
    {
        private Guid _id = Guid.NewGuid();
        public Guid GetId() => _id;
    }
}
