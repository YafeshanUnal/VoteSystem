using System;
using AutoMapper;
using VoteSystem.Data.EntityFramework;
using VoteSystem.Entity;

namespace VoteSystem.Application.Vote.Command
{

    public class CreateVoteCommand
    {

        EfVoteRepository _voteRepository;
        private readonly IMapper _mapper;

        public CreateVoteModel Model { get; set; }

        public CreateVoteCommand(EfVoteRepository voteRepository, IMapper mapper)
        {
            _voteRepository = voteRepository;
            _mapper = mapper;
        }

        public void Handle()
        {

            var vote = _mapper.Map<Election>(Model);

            vote.totalOfVote += Model.numberOfVote;
            int percent;

            percent = Model.numberOfVote * 100 / (int)vote.totalOfVote;

            Console.WriteLine("Oy:" + Model.numberOfVote + "Toplam Oy:" + vote.totalOfVote+"Yüzde:%"+percent);

            _voteRepository.Insert(vote);
        }



    }

    public class CreateVoteModel
    {
        public int Id { get; set; }
        public string party { get; set; }
        public int numberOfVote { get; set; }
        public string city { get; set; }
        public string district { get; set; }
        public string neighborhood { get; set; }

        public int AccountId { get; set; }
    }
}