using System;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using VoteSystem.Application.Vote.Command;
using VoteSystem.Application.Vote.Query;
using VoteSystem.Data.EntityFramework;
using VoteSystem.Data.Repositories;
using VoteSystem.Entity;

namespace VoteSystem.Controllers
{

    [ApiController]
    [Route("[controller]s")]
    public class VoteController : ControllerBase
    {


        EfVoteRepository _voteRepository;
        private readonly IMapper _mapper;

        public VoteController(EfVoteRepository voteRepository, IMapper mapper)
        {
            _voteRepository = voteRepository;
            _mapper = mapper;
        }


        [HttpGet]
        public IActionResult GetListAll()
        {
            GetVoteQuery query = new GetVoteQuery(_voteRepository, _mapper);
            var result = query.Handle();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_voteRepository.GetById(id));
        }

        [HttpPost]
        public IActionResult Post([FromBody] CreateVoteModel newVote)
        {
            CreateVoteCommand command = new CreateVoteCommand(_voteRepository, _mapper);
            command.Model = newVote;
            command.Handle();
            return Ok(newVote);
        }

        [HttpPut]
        public IActionResult Put([FromBody] Election vote)
        {
            _voteRepository.Update(vote);
            return Ok(vote);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _voteRepository.Delete(id);
            return Ok();
        }

    }
}