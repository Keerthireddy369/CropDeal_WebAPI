using Crop_Deal_Web_API.Models;
using Crop_Deal_Web_API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crop_Deal_Web_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvoiceController : Controller
    {
        public readonly InvoiceService _invoiceService;
        public InvoiceController(InvoiceService invoiceService)
        {
            _invoiceService = invoiceService;
        }

        #region GetById
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById([FromRoute] int id)   // working
        {

            var invoice = await _invoiceService.GetById(id);
            if (invoice == null)
            {
                return NotFound();
            }
            return Ok(invoice);

        }

        #endregion

        #region GetAll
        [HttpGet]
        [Route("Getall")]
        public async Task<IActionResult> GetAll()
        {

            var invoices = await _invoiceService.GetAll();
            return Ok(invoices);


        }
        #endregion

        #region Edit
        [HttpPut]
        [Route("put")]
        public async Task<IActionResult> Edit(int id,[FromBody] Invoice invoice)  // not working in swagger but working in postman
        {
            try
            {
                await _invoiceService.Edit(id,invoice);
                await _invoiceService.Save();
                return Ok(invoice);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        #endregion

        #region Delete
        [HttpDelete]
        [Route("{id:int}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {

            await _invoiceService.Delete(id);
            return Ok();

        }
        #endregion

        #region Add
        [HttpPost]
        [Route("AddOrder")]
        public async Task<IActionResult> Add([Bind()] Invoice entity)
        {

            await _invoiceService.Add(entity);
            await _invoiceService.Save();
            return (Ok());


        }
        #endregion
    }
}
