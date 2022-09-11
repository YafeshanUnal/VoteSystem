using System;
using System.Collections.Generic;
using AutoMapper;
using VoteSystem.Data.EntityFramework;
using VoteSystem.Entity;

namespace VoteSystem.Application.Vote.Query{

    public class GetVoteQuery
    {
        EfVoteRepository _voteRepository;
        private readonly IMapper _mapper;

        public GetVoteQuery(EfVoteRepository voteRepository, IMapper mapper)
        {
            _voteRepository = voteRepository;
            _mapper = mapper;
        }

        public List<Election> Handle()
        {
            Console.WriteLine("GetVoteQuery");
            return _voteRepository.GetListAll();
        }
    }
}