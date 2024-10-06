using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using Entities;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RacesController : ControllerBase
    {

        private readonly HttpClient _httpClient;

        public RacesController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        // GET: api/<RacesController>
        [HttpGet]
        public async Task<List<Race>> Get()
        {
            IDataAccess db = new DbAccess();
            List<Race> racelist = db.GetRaces();

            return racelist;
        }

        // GET api/<RacesController>
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

    }
}
