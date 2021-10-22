using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
// using TodoApp.Data;
using TodoApp.Models;

namespace TodoApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentDetailController : ControllerBase
    {
        private readonly ItemDataContext _context;

        public PaymentDetailController(ItemDataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetItems()
        {
            var items = await _context.Items.ToListAsync();
            return Ok(items);
        }

        [HttpPost]
        public async Task<IActionResult> CreateItem(ItemData data)
        {
            if (ModelState.IsValid)
            {
                await _context.Items.AddAsync(data);
                await _context.SaveChangesAsync();

                return CreatedAtAction("GetItem", new {data.paymentDetailId}, data);
            }
            return new JsonResult("Something went wrong") {StatusCode = 500};
        }

        [HttpGet("{paymentDetailId}")]
        public async Task<IActionResult> GetItem(int paymentDetailId)
        {
            var item = await _context.Items.FirstOrDefaultAsync(x => x.paymentDetailId == paymentDetailId);
            if (item == null)
                return NotFound();
            return Ok(item);
        }

        [HttpPut("{paymentDetailId}")]
        public async Task<ActionResult> UpdateItem(int paymentDetailId, ItemData item)
        {
            if (paymentDetailId != item.paymentDetailId)
                return BadRequest();
            
            var existItem = await _context.Items.FirstOrDefaultAsync(x=>x.paymentDetailId == paymentDetailId);
            if (existItem == null)
                return NotFound();
            
            // existItem.Title = item.Title;
            // existItem.Description = item.Description;
            // existItem.Done = item.Done;

            existItem.cardOwnerName = item.cardOwnerName;
            existItem.cardNumber = item.cardNumber;
            existItem.expirationDate = item.expirationDate;
            existItem.securityCode = item.securityCode;


            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{paymentDetailId}")]
        public async Task<IActionResult> DeleteItem(int paymentDetailId)
        {
            var existItem = await _context.Items.FirstOrDefaultAsync(x=>x.paymentDetailId==paymentDetailId);

            if (existItem==null)
                return NotFound();

            _context.Items.Remove(existItem);
            await _context.SaveChangesAsync();

            return Ok (existItem);
        }


        [Route("TestRun")]
        [HttpGet]

        public ActionResult TestRun()
        {
            return Ok("success");
        }
    }
}