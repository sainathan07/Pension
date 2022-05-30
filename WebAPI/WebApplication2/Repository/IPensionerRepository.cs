using System.Collections.Generic;
using WebApplication2.Models;

namespace WebApplication2.Repository
{
    public interface IPensionerRepository
    {
        IEnumerable<PensionerModel> GetPensioners();
        PensionerModel GetProductByID(long adhaarId);
        void InsertProduct(PensionerModel pensioner);
        void DeletePensioner(long adhaarId);
        void Save();
    }

}