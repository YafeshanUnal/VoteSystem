using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using VoteSystem.Application.Vote.Command;
using VoteSystem.Data.Abstract;
using VoteSystem.Data.Database;
using VoteSystem.Data.Repositories;
using VoteSystem.Entity;

namespace VoteSystem.Data.EntityFramework{
    
    public class EfVoteRepository : GenericRepository<Election>, IVoteRepository
    {
        private readonly DatabaseContext _context;
        public EfVoteRepository(DatabaseContext context) : base(context)
        {
            _context = context;
        }

        public List<Election> GetVoteWithUser(int voteId)
        {
            return _context.Elections.Where(x => x.Id == voteId).Include(x => x.AccountId).ToList();
        }

        internal void Insert(CreateVoteModel vote)
        {
            throw new NotImplementedException();
        }
    }
}