﻿using System;
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
        //Get on ID
        [Route("item/{id}")]
        public IActionResult GetSpecificItem(int id)
        { 
            IEnumerable<ItemEntity> item = _unitOfWork.Edits.GetItem(id);
        }

        [HttpGet]
        //Get All
        public List<ItemEntity> GetAllEntities() { }

        [HttpPost]
        //Post = Create
        public ItemEntity CreateEntity(ItemEntity item)
        {
            //create
        }

        [HttpPut]
        //Update eller replace
        public ItemEntity EditItemEntity(int id, ItemEntity item)
        {
            //Ændrer bestemt item
        }

        [HttpDelete]
        public ItemEntity deleteItem(int id)
        {
            //delete
        }
    }
}
