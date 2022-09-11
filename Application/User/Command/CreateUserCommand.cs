using AutoMapper;
using VoteSystem.Data.EntityFramework;
using VoteSystem.Entity;
using System;


namespace VoteSystem.Application.User.Command{

    public class CreateUserCommand
    {
        EfUserRepository _userRepository;
        private readonly IMapper _mapper;

        public CreateUserModel Model { get; set; }

        public CreateUserCommand(EfUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public void Handle()
        {
            var user = _mapper.Map<Account>(Model);

            _userRepository.Insert(user);
        }
    }

    public class CreateUserModel
    {
        public int Id { get; set; }
        public string userName { get; set; }
        public string surName { get; set; }
        public string email { get; set; }
        public int password { get; set; }
    }
}