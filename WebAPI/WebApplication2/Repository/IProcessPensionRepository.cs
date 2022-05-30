using System.Threading.Tasks;
using WebApplication2.Models;
namespace WebApplication2.Repository
{
    public interface IProcessPensionRepository
    {
        Task<PensionDetail> GetPension(long adhaarId);
    }
}