using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using VareDatabase.Repo;
using VareDatabase.Interfaces;
using VareDatabase.Models;
using VareDatabase.Repo.Auction;

namespace VareDatabase.Controllers
{
    public class ItemEntityController : Controller
    {
        private DatabaseLogic _dbLogic;
        private string json;

        public ItemEntityController()
        {
            var db = new DBContext.VareDataModelContext();
            IItemRepository repo = new ItemRepository(db);
            var unit = new AuctionUnitOfWork(db);
            var dbLogic = new DatabaseLogic(unit, repo);
            _dbLogic = dbLogic;
        }

        [HttpGet]
        [Route("Home/item/{id?}")]
        //Get on ID
        public ActionResult<string> GetItem(int id)
        {
            json = JsonConvert.SerializeObject(_dbLogic.GetSingle(id), Formatting.Indented);
            return json;
        }
        [HttpGet]
        [Route("Home/item")]
        public ActionResult<string> GetAllItems()
        {
            json = JsonConvert.SerializeObject(_dbLogic.GetAll(), Formatting.Indented);
            return json;
        }

        [HttpGet]
        [Route("Home/item/tag/{search?}")]
        public ActionResult<string> GetTag(string search)
        {
            json = JsonConvert.SerializeObject(_dbLogic.Search(search), Formatting.Indented);
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
            _dbLogic.Save();
        }
    }
}
