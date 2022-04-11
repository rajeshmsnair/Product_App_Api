using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DeliVeggie.Price.Infrastructure.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DeliVeggie.Prices.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PricesController : ControllerBase
    {
        private readonly IPriceService _priceService;
        private readonly ILogger<PricesController> _logger;
        public PricesController(IPriceService priceService, ILogger<PricesController> logger)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _priceService = priceService ?? throw new ArgumentNullException(nameof(priceService));
        }
        [HttpGet("GetDiscount/{weekDay}")]
        public async Task<IActionResult> GetDiscountByWeek(int weekDay)
        {
            var reduction = await _priceService.getReductionByWeekDay(weekDay).ConfigureAwait(false);
            return Ok(reduction);

        }
    }
}