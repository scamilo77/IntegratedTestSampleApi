using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CheckController : ControllerBase
    {
        /// <summary>
        /// Verifica se o serviço está online
        /// </summary>
        /// <returns>TRUE ou FALSE</returns>
        [HttpGet("online")]
        public ContentResult Online()
        {
            return new ContentResult
            {
                StatusCode = 200,
                Content = true.ToString()
            };
        }
    }
}