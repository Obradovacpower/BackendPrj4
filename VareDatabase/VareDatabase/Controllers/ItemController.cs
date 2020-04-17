using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VareDatabase.DBContext;
using VareDatabase.Models;

namespace VareDatabase.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private readonly VareDataModelContext _context;

        public ItemController(VareDataModelContext context)
        {
            _context = context;
        }

        public string Index(string name, int numTimes = 1)
        {
            return "Hey hva sker der makker";
        }

        // GET: api/Item
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ItemEntity>>> GetItem()
        {
            return await _context.Item.ToListAsync();
        }

        // GET: api/Item/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ItemEntity>> GetItemEntity(int id)
        {
            var itemEntity = await _context.Item.FindAsync(id);

            if (itemEntity == null)
            {
                return NotFound();
            }

            return itemEntity;
        }

        // PUT: api/Item/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutItemEntity(int id, ItemEntity itemEntity)
        {
            if (id != itemEntity.ItemId)
            {
                return BadRequest();
            }

            _context.Entry(itemEntity).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ItemEntityExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Item
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<ItemEntity>> PostItemEntity(ItemEntity itemEntity)
        {
            _context.Item.Add(itemEntity);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetItemEntity", new { id = itemEntity.ItemId }, itemEntity);
        }

        // DELETE: api/Item/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ItemEntity>> DeleteItemEntity(int id)
        {
            var itemEntity = await _context.Item.FindAsync(id);
            if (itemEntity == null)
            {
                return NotFound();
            }

            _context.Item.Remove(itemEntity);
            await _context.SaveChangesAsync();

            return itemEntity;
        }

        private bool ItemEntityExists(int id)
        {
            return _context.Item.Any(e => e.ItemId == id);
        }
    }
}
