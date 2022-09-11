using AutoMapper;
using VoteSystem.Application.User.Command;
using VoteSystem.Application.Vote.Command;
using VoteSystem.Entity;

namespace VoteSystem.Common{

    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<CreateVoteModel,Election>();
            CreateMap<CreateUserModel,Account>();

        }
    }
}