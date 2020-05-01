using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VareDatabase.DBContext;
using VareDatabase.Models;

namespace VareDatabase.Repo
{
    public class CreateUserRepository
    {
        private VareDataModelContext db;
        public CreateUserRepository(VareDataModelContext db)
        {
            this.db = db;
        }
        public void AddUser()
        {

        }
        //maybe?
        public void RemoveUser()
        {

        }
    }
}
