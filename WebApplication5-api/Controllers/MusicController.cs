using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication5_api.Entities;

namespace WebApplication5_api.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class MusicController : ControllerBase
    {
        private readonly MyAppContext _context;
        public MusicController(MyAppContext context)
        {
            _context = context;
        }

        [HttpGet("getsongs")]
        public IActionResult Index()
        {
            var musics = _context.Musics.ToList();

            return Ok(musics);
        }

        [HttpPost("addsong")]
        public async Task<IActionResult>  AddSong([FromBody] Music model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var res = _context.Add(model);
                    await _context.SaveChangesAsync();
                    return Ok(res);

                }
                catch(Exception e)
                {
                    return Problem(e.Message, null, 500);
                }

            }
            else
            {
                return  Ok(model);
            }
        }
    }
}
