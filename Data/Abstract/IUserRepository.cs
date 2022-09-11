namespace VoteSystem.Data.Abstract
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using System.Threading.Tasks;
    using VoteSystem.Entity;

    public interface IUserRepository : IGenericRepository<Account>
    {
        public List<Account> GetUserWithVotes(int userId);
    }
}