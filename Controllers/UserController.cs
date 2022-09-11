using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using VoteSystem.Application.User.Command;
using VoteSystem.Data.EntityFramework;
using VoteSystem.Data.Repositories;
using VoteSystem.Entity;

namespace VoteSystem.Controllers{

    [ApiController]
    [Route("[controller]s")]
    public class UserController : ControllerBase
    {
        EfUserRepository _userRepository;
        private readonly IMapper _mapper;


        public UserController( EfUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }
      

        // [HttpPost]
        // public IActionResult Login([FromBody] Account account)
        // {
        //     var userInDb = _userRepository.GetById(account.Id);
        //     if (userInDb == null)
        //     {
        //         ModelState.AddModelError("userName", "User name is not found");
        //         return Ok(account);
        //     }

        //     if (userInDb.password != account.password)
        //     {
        //         ModelState.AddModelError("password", "Password is not correct");
        //         return Ok(account);
        //     }

        //     return Ok(account);

           
        // }


        [HttpPost]
        public IActionResult Register([FromBody] CreateUserModel newAccount)
        {
            CreateUserCommand command = new CreateUserCommand(_userRepository, _mapper);
            command.Model = newAccount;
            command.Handle();
            return Ok(newAccount);
        }
       
    }
}