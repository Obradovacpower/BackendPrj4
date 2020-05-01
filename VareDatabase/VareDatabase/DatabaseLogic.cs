using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VareDatabase.Interfaces;

namespace VareDatabase
{
    public class DatabaseLogic
    {
        private readonly IUnitOfWork uow;
        //private ILoginRepository _loginRepo; //does not exist atm
        public DatabaseLogic(IUnitOfWork unit)
        {
            uow = unit;
        }
        public void AddItem(/*json string*/) //json as param?
        {
            //ItemEntity i = ReadJson();
            //uow.GetRepository<ItemEntity>().Create(i);
            uow.Commit();
        }
        public int GetUserId()
        {
            //return _loginRepo.GetUserId();
            return 14; //temp
        }
    }
}
