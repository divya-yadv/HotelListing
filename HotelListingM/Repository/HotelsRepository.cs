using HotelListingM.Contracts;
using HotelListingM.Data;

namespace HotelListingM.Repository
{
    public class HotelsRepository : GenericRepository<Hotel>, IHotelsRepository
    {
        public HotelsRepository(HotelListingDbContext context) : base(context)
        {
        }
    }
}
