namespace VoteSystem.Data.Abstract
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using System.Threading.Tasks;
    using VoteSystem.Entity;

    public interface IVoteRepository : IGenericRepository<Election>
    {
        public List<Election> GetVoteWithUser(int voteId);
    }
}