using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Linq;

namespace lab1
{
    [ApiController]
    [Route("[controller]")]
    public class MenuController : ControllerBase
    {
        [HttpGet("ShowWordCount/{count}")]
        public ActionResult ShowWordCount(int count)
        {
            var text = System.IO.File.ReadAllText("lorem.txt");
            var words = text.Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            return Ok(words.Take(count));
        }

        [HttpGet("PerformMathOperation/{operation}")]
        public ActionResult PerformMathOperation(string operation)
        {
            var result = new System.Data.DataTable().Compute(operation, null);
            return Ok(result);
        }
    }
}

