using VoteSystem.Data.Database;
using VoteSystem.Entity;

namespace VoteSystem.Data.Repositories{

    public class VoteRepository : GenericRepository<Election> 
    {
        public VoteRepository(DatabaseContext context) : base(context)
        {
        }

       
    }
}