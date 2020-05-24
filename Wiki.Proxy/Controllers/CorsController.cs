using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace Wiki.Proxy.Controllers
{
    [Route("api/[Controller]")]
    public class CorsController : ControllerBase
    {
        private readonly HttpClient _httpClient;

        public CorsController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        [HttpGet("{url}")]
        public async Task<string> GetAsync(string url) 
            => await _httpClient.GetStringAsync(Uri.UnescapeDataString(url));
    }
}
