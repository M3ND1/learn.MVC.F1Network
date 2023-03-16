using F1Network.Models;

namespace F1Network.Data.Services
{
    public interface ICarsService
    {
        //connecting with Dbcontext
        IEnumerable<Car> GetAll();
    }
}
