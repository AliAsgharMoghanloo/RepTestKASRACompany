using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestKASRACompany.Data;
using TestKASRACompany.Models;

namespace TestKASRACompany.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Testkasra : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        public Testkasra(IConfiguration configuration
           , ApplicationDbContext db) 
        {
            _db = db; 
        }

        [Route("test2add")]
        [HttpPost]
        public async Task<IActionResult> test2add([FromBody] Product Product)
        {
             
            try
            {
                if(!ModelState.IsValid)
                    return BadRequest(ModelState);

                 await _db.Product.AddAsync(Product);
                 await _db.SaveChangesAsync();
                 
                return Ok(Product);
                 
            }
            catch (Exception)
            {
                //more code...
                throw;
                
            }

        }

        [Route("test2getAll")]
        [HttpGet]
        public async Task<IActionResult> test2getAll()
        {

            try
            {
                var ll = _db.Product.ToList();
                if (ll==null)
                    return NotFound();
                else
                return Ok(ll);

            }
            catch (Exception)
            {
                //more code...
                throw;

            }

        }

        [Route("GetTest3")]
        [HttpGet]
        public async Task<IActionResult> GetTest3([FromQuery] int num)
        {

            try
            {
              return Ok(BracketCombinations(num));
            }
            catch (Exception)
            {
                //more code...
                throw;

            }

        }

       private int BracketCombinations(int num) {
            if (0 > num)
                return 0;
            if (1 == num)
                return 1;
            if (2 == num)
                return 2;
            int ww = 1;
            for (int i = 1; num - i >1; i++)
            {
                ww += (2 * BracketCombinations(i) * BracketCombinations(num - (i+1))) ;
            }
             
            return ww + BracketCombinations(num - 1);
        }

    }
}
