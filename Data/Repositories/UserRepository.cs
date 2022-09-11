using VoteSystem.Data.Database;
using VoteSystem.Entity;

namespace VoteSystem.Data.Repositories{

    public class UserRepository : GenericRepository<Account> 
    {
        public UserRepository(DatabaseContext context) : base(context)
        {
        }

     
    }
}