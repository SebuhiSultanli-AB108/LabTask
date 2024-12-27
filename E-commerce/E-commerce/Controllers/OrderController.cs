using E_commerce.BL.Service.Orders;
using E_commerce.BL.DTOs.Order;
using Microsoft.AspNetCore.Mvc;

namespace E_commerce.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class OrderController(IOrderService _service,/*IMapper _mapper*/) : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> Post(OrderCreateDTO dto)
    {
        // map dto to order
        //_service.Create();
        return Ok();
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var data = _service.GetAll();
        //map data to getDTO
        return Ok(data);
    }
}
