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

        [HttpGet("{v}")]
        public ActionResult UpdateModel(String v)
        {
            if (v.Equals("v1"))
            {
                Program.MainForm.Invoke(new Action(() =>
                {
                    Program.MainForm.SetCurrentDeployment(1);
                }));
            } 
            else if (v.Equals("v2"))
            {
                Program.MainForm.Invoke(new Action(() =>
                {
                    Program.MainForm.SetCurrentDeployment(2);
                }));
            }
            return Ok();
        }

        [HttpPost]
        public ActionResult FillData([FromBody] List<NewDetection> Detections)
        {
            Program.MainForm.Invoke(new Action(() =>
            {
                Program.MainForm.UIHandlerForBulk(Detections);
            }));
            return Ok();
        }
    }
}