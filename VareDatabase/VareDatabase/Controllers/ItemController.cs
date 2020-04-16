using System;
using System.Collections.Generic;
using System.Linq;
using VareDatabase.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace VareDatabase.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ItemController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<ItemController> _logger;

        public ItemController(ILogger<ItemController> logger)
        {
            _logger = logger;
        }
        /*public IActionResult Edit(int id)
        {
            return ControllerContext.
        }*/
        [HttpPost]
        public IActionResult Edit(int id)
        {
            return ControllerContext.
        }
        [HttpGet]
        public IEnumerable<ItemEntity> Get()
        {

            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new ItemEntity
            {
                ItemId = 1
            })
            .ToArray();
        }
    }
}
