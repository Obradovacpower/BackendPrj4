using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using VareDatabase.Repo;
using VareDatabase.Interfaces;
using VareDatabase.Models;

namespace VareDatabase.Controllers
{
    [RoutePrefix("item")]
    public class ItemEntityController : ApiController
    {
        private DatabaseLogic _dbLogic;

        public ItemEntityController(DatabaseLogic dbLogic)
        {
            _dbLogic = dbLogic;
        }

        [HttpGet]
        //Get on ID
        [Route("item/{id:int}")]
        public ItemEntity GetItem(int id)
        {
            return _dbLogic.GetSingle(id);
        }

        [Route("item")]
        [HttpGet]
        public IEnumerable<ItemEntity> GetAllItems()
        {
            return _dbLogic.GetAll();
        }

        [HttpPost]
        //Post = Create
        public void CreateEntity(ItemEntity item)
        {
            _dbLogic.AddItem(item);
        }

        [HttpPut]
        //Update eller replace
        public ItemEntity EditItemEntity(int id, ItemEntity item)
        {
            _dbLogic.
        }

        [HttpDelete]
        public ItemEntity deleteItem(int id)
        {
            //delete
        }
    }
}
