using HotelListingM.Data;

namespace HotelListingM.Contracts
{
    public interface ICountriesRepository:IGenericRepository<Country>
    {
        Task<Country> GetDetails(int id);
    }
}
