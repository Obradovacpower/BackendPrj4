//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;
//using VareDatabase.DBContext;
//using VareDatabase.Models;
//using VareDatabase.Repo;
//using VareDatabase.Interfaces;

//namespace VareDatabase.Controllers
//{
//    [Route("api/[controller]")]
//    public class BidEntitiesController : ControllerBase
//    {
//        private DatabaseLogic _dbLogic;
//        private string json;

//        public BidEntitiesController()
//        {
//            _context = context;
//        }

//        // GET: api/BidEntities
//        [HttpGet]
//        public async Task<ActionResult<IEnumerable<BidEntity>>> GetBids()
//        {
//            return await _context.Bids.ToListAsync();
//        }

//        // GET: api/BidEntities/5
//        [HttpGet("{id}")]
//        public async Task<ActionResult<BidEntity>> GetBidEntity(int id)
//        {
//            var bidEntity = await _context.Bids.FindAsync(id);

//            if (bidEntity == null)
//            {
//                return NotFound();
//            }

//            return bidEntity;
//        }

//        // PUT: api/BidEntities/5
//        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
//        // more details see https://aka.ms/RazorPagesCRUD.
//        [HttpPut("{id}")]
//        public async Task<IActionResult> PutBidEntity(int id, BidEntity bidEntity)
//        {
//            if (id != bidEntity.Id)
//            {
//                return BadRequest();
//            }

//            _context.Entry(bidEntity).State = EntityState.Modified;

//            try
//            {
//                await _context.SaveChangesAsync();
//            }
//            catch (DbUpdateConcurrencyException)
//            {
//                if (!BidEntityExists(id))
//                {
//                    return NotFound();
//                }
//                else
//                {
//                    throw;
//                }
//            }

//            return NoContent();
//        }

//        // POST: api/BidEntities
//        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
//        // more details see https://aka.ms/RazorPagesCRUD.
//        [HttpPost]
//        public async Task<ActionResult<BidEntity>> PostBidEntity(BidEntity bidEntity)
//        {
//            _context.Bids.Add(bidEntity);
//            await _context.SaveChangesAsync();

//            return CreatedAtAction("GetBidEntity", new { id = bidEntity.Id }, bidEntity);
//        }

//        // DELETE: api/BidEntities/5
//        [HttpDelete("{id}")]
//        public async Task<ActionResult<BidEntity>> DeleteBidEntity(int id)
//        {
//            var bidEntity = await _context.Bids.FindAsync(id);
//            if (bidEntity == null)
//            {
//                return NotFound();
//            }

//            _context.Bids.Remove(bidEntity);
//            await _context.SaveChangesAsync();

//            return bidEntity;
//        }

//        private bool BidEntityExists(int id)
//        {
//            return _context.Bids.Any(e => e.Id == id);
//        }
//    }
//}
