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
            List<Race> raceList = new List<Race>();
            string fileName = "sampleData/races.json";
            string filePath = Path.Combine(AppContext.BaseDirectory, "data", "races.json");
            string jsonData = System.IO.File.ReadAllText(filePath);

            raceList = JsonSerializer.Deserialize<List<Race>>(jsonData);

            return raceList;
        }

        // GET api/<RacesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

    }
}
