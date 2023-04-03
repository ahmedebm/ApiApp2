using System;

using System.Collections.Generic;

using System.Linq;

using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;

using CalcClassLibEnterp;

namespace SampleAPIUseLibrary.Controllers

{

    [Route("api/[controller]")]

    [ApiController]

    public class ValuesController : ControllerBase

    {

        Calc calc = new Calc();



        [HttpGet("/average")]

        public int Average([FromQuery] int[] nums)

        {

            return calc.Average(nums);

        }

        [HttpGet("/smallest")]

        public int Smallest([FromQuery] int[] nums)

        {

            return calc.Smallest(nums);

        }

        [HttpGet("/largest")]

        public int Largest([FromQuery] int[] nums)

        {

            return calc.Largest(nums);

        }

    }

}