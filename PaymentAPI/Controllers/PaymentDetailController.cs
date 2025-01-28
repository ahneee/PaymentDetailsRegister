using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PaymentAPI.Models;

namespace PaymentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentDetailController : ControllerBase
    {
        private readonly PaymentDetailContext _context;

        public PaymentDetailController(PaymentDetailContext context)
        {
            _context = context;
        }

        // GET: api/PaymentDetail
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PaymentDetailModels>>> GetPaymentDetails()
        {
            return await _context.PaymentDetails.ToListAsync();
        }

        // GET: api/PaymentDetail/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PaymentDetailModels>> GetPaymentDetailModels(int id)
        {
            var paymentDetailModels = await _context.PaymentDetails.FindAsync(id);

            if (paymentDetailModels == null)
            {
                return NotFound();
            }

            return paymentDetailModels;
        }

        // PUT: api/PaymentDetail/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPaymentDetailModels(int id, PaymentDetailModels paymentDetailModels)
        {
            if (id != paymentDetailModels.PaymentDetailId)
            {
                return BadRequest();
            }

            _context.Entry(paymentDetailModels).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PaymentDetailModelsExists(id))
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

        // POST: api/PaymentDetail
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PaymentDetailModels>> PostPaymentDetailModels(PaymentDetailModels paymentDetailModels)
        {
            _context.PaymentDetails.Add(paymentDetailModels);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPaymentDetailModels", new { id = paymentDetailModels.PaymentDetailId }, paymentDetailModels);
        }

        // DELETE: api/PaymentDetail/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePaymentDetailModels(int id)
        {
            var paymentDetailModels = await _context.PaymentDetails.FindAsync(id);
            if (paymentDetailModels == null)
            {
                return NotFound();
            }

            _context.PaymentDetails.Remove(paymentDetailModels);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PaymentDetailModelsExists(int id)
        {
            return _context.PaymentDetails.Any(e => e.PaymentDetailId == id);
        }
    }
}
