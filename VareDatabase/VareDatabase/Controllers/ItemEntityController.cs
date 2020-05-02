using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using Newtonsoft.Json;
using VareDatabase.Repo;
using VareDatabase.Interfaces;
using VareDatabase.Models;
using VareDatabase.Repo.Auction;

namespace VareDatabase.Controllers
{
    [RoutePrefix("item")]
    public class ItemEntityController : ApiController
    {
        private DatabaseLogic _dbLogic;
        private string json;

        public ItemEntityController(/*DatabaseLogic dbLogic*/)
        {
            var db = new DBContext.VareDataModelContext();
            IItemRepository repo = new ItemRepository(db);
            var unit = new AuctionUnitOfWork(db);
            var dbLogic = new DatabaseLogic(unit, repo);
            _dbLogic = dbLogic;
        }

        [HttpGet]
        //Get on ID
        [Route("item/{id:int}")]
        public string GetItem(int id)
        {
            json = JsonConvert.SerializeObject(_dbLogic.GetSingle(id), Formatting.Indented);
            return json;
        }

        [Route("item")]
        [HttpGet]
        public string GetAllItems()
        {
            json = JsonConvert.SerializeObject(_dbLogic.GetAll(), Formatting.Indented);
            return json;
        }

        [HttpPost]
        //Post = Create
        public void CreateEntity(ItemEntity item)
        {
            _dbLogic.AddItem(item);
            _dbLogic.Save();
        }

        [HttpPut]
        //Update eller replace
        public void EditItemEntity(int id, ItemEntity item)
        {
            //En eller anden update func MANGLER HER
            _dbLogic.Save();
        }

        [HttpDelete]
        public void DeleteItem(ItemEntity item)
        { 
            _dbLogic.Delete(item);
        }
    }
}
