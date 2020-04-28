using System;
using System.Collections.Generic;
using System.Linq;
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
    public class ItemEntitiesController : ControllerBase
    {
        private readonly VareDataModelContext _context;

        public ItemEntitiesController(VareDataModelContext context)
        {
            _context = context;
        }

        // GET: api/ItemEntities
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ItemEntity>>> GetItems()
        {
            return await _context.Items.ToListAsync();
        }

        // GET: api/ItemEntities/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ItemEntity>> GetItemEntity(int id)
        {
            var itemEntity = await _context.Items.FindAsync(id);

            if (itemEntity == null)
            {
                return NotFound();
            }

            return itemEntity;
        }

        // PUT: api/ItemEntities/5
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

        // POST: api/ItemEntities
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<ItemEntity>> PostItemEntity(ItemEntity itemEntity)
        {
            _context.Items.Add(itemEntity);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetItemEntity", new { id = itemEntity.ItemId }, itemEntity);
        }

        // DELETE: api/ItemEntities/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ItemEntity>> DeleteItemEntity(int id)
        {
            var itemEntity = await _context.Items.FindAsync(id);
            if (itemEntity == null)
            {
                return NotFound();
            }

            _context.Items.Remove(itemEntity);
            await _context.SaveChangesAsync();

            return itemEntity;
        }

        private bool ItemEntityExists(int id)
        {
            return _context.Items.Any(e => e.ItemId == id);
        }
    }
}
