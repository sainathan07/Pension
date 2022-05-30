using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebApplication2.Repository;
namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class ProcessPension : Controller
    {
        private readonly IProcessPensionRepository _processPensionRepository;
        public ProcessPension(IProcessPensionRepository processPensionRepository)
        {
            _processPensionRepository = processPensionRepository;
        }

        [HttpGet("{adhaarId}")]
        public async Task<IActionResult> Get(long adhaarId)
        {
            var pensioner = await _processPensionRepository.GetPension(adhaarId);
            return new OkObjectResult(pensioner);
        }
    }
}