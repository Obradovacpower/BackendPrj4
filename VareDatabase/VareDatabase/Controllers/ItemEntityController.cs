using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VareDatabase.Repo;
using VareDatabase.Interfaces;
using VareDatabase.Models;

namespace VareDatabase.Controllers
{
    [Route("api/item")]
    [ApiController]
    public class ItemEntityController
    {
        private AuctionUnitOfWork _unitOfWork;

        public ItemEntityController(AuctionUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public IActionResult GetAllItems()
        {
            List<ItemEntity> items = new List<ItemEntity>();
            try
            {
                items = _unitOfWork.;
                items = _unitOfWork.Auctions.Read(20);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
