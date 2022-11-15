using Project.Data;
using Project.Domain.Entities.Sample;

namespace Project.DataAccess.Repository.SampleRepository
{
    public class SampleRepository : Repository<Sample>, ISampleRepository, IRepositoryIdentifier
    {
        private readonly ApplicationDbContext _context;
        public SampleRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
