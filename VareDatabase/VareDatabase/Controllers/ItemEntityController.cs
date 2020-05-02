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
        private IUnitOfWork _unitOfWork;

        public ItemEntityController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public IActionResult GetAllItem()
        {
            List<ItemEntity> items = new List<ItemEntity>();
            try
            {
                items = _unitOfWork.
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
