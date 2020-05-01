using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VareDatabase
{
    public class DatabaseLogic
    {
        private IItemRepository _itemRepo;
        //private ILoginRepository _loginRepo; //does not exist atm
        public DatabaseLogic(IItemRepository itemRepo)
        {
            _itemRepo = itemRepo;
        }
        public void AddItem(int buyOut, int userId, int expire, string[] tags, string title, string description, string[] images)
        {
            _itemRepo.AddItem(buyOut, userId, expire, tags, title, description, images);
        }
        public int GetUserId()
        {
            //return _loginRepo.GetUserId();
            return 14;
        }
    }
}
