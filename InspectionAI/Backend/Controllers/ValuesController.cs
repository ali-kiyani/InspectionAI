using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exhibition.DTO;
using Microsoft.AspNetCore.Mvc;

namespace Exhibition.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        public ValuesController()
        {
        }

        [HttpPost]
        public ActionResult UpdateNewDetection([FromBody] NewDetection Detection)
        {
            Program.MainForm.Invoke(new Action(() =>
            {
                Program.MainForm.UIHandler(Detection);
            }));
            return Ok();
        }

        /*[HttpGet]
        public async Task<List<NewDetection>> GetlatestDetections()
        {
            List<NewDetection> allDec = await _context.Detection.OrderByDescending(x => x.Datetime).Take(4).ToListAsync();
            return await Task.FromResult(allDec);
        }*/
    }
}