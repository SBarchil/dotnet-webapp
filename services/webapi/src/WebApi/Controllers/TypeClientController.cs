using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/typeClient")]
    [ApiController]
    public class TypeClientController: ControllerBase
    {
        [HttpGet]
        public string GetTypeClients()
        {
            return "TypeClientController get action  OK ";
        }
        [HttpGet("{codeType}/{name}")]
        public string GetTypeClientById(string codeType, [FromRoute] string name)
        {
            return " get one type client by id   OK " + codeType + " : " + name ;
        }



    }
}
