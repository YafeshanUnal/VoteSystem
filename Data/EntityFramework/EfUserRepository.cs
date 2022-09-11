using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using VoteSystem.Data.Abstract;
using VoteSystem.Data.Database;
using VoteSystem.Data.Repositories;
using VoteSystem.Entity;

namespace VoteSystem.Data.EntityFramework{
    public class EfUserRepository : GenericRepository<Account>, IUserRepository
    {
        private readonly DatabaseContext _context;
        public EfUserRepository(DatabaseContext context) : base(context)
        {
            _context = context;
        }

        public List<Account> GetUserWithVotes(int userId)
        {
            return _context.Users.Where(x => x.Id == userId).Include(x => x.Elections).ToList();;   
        }
    }

}