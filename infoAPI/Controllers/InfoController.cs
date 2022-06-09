using infoAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace infoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InfoController : ControllerBase
    {
        static List<Info>_info = new List<Info>()
        {
            new Info()
            {
                 Id = 1,
                 EmailAddress = "xyz.com",
                 FirstName = "John",
                 LastName = "Doe",
                 DateOfBirth = "23-1-1990",
                 ContactNumber = "070849302901",
                 OfficeNumber = 6
            }
        };
        public IEnumerable<Info> Get()
        {
            return _info;
        }
        [HttpPost]
        public void Post([FromBody] Info info)
        {
            _info.Add(info);
        }
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Info info)
        {
            _info[id] = info;
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _info.RemoveAt(id);
        }
    }
}
