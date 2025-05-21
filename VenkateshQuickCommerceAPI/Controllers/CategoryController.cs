using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace VenkateshQuickCommerceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        [HttpGet("GetAllCategory")]
        public void GetAllCategory()
        { 
        
        }
    }
}
