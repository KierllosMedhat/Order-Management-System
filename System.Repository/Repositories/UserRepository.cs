using System;
using System.Collections.Generic;
using System.Data.Context;
using System.Data.Entities;
using System.Linq;
using System.Repository.Interfaces;
using System.Text;
using System.Threading.Tasks;

namespace System.Repository.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly OrderManagementDbContext context;

        public UserRepository(OrderManagementDbContext context)
        {
            this.context = context;
        }

        public void Login()
        {
            throw new NotImplementedException();
        }

        public void RegisterUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
