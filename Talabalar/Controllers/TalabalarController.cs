using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Talabalar.Data;
using Talabalar.Dtos;
using Talabalar.Models;

namespace Talabalar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TalabalarController : ControllerBase
    {
        private readonly ITalabaRepository _repository;
        private readonly IMapper _mapper;
        public TalabalarController(ITalabaRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> CreateTalaba(TalabaCreatedDto talabaCreatedDto)
        {
            var talabaModel = _mapper.Map<Talaba>(talabaCreatedDto);
            await _repository.CreateTalaba(talabaModel);
            await _repository.SaveChanges();
            var talabaReadDto = _mapper.Map<TalabaReadDto>(talabaModel);
            return Created("", talabaReadDto);
        }
        [HttpGet]
        public async Task<IActionResult> GetTalabalar()
        {
            var talabalar = await _repository.GetAllTalabalar();
            return Ok(_mapper.Map<IEnumerable<TalabaReadDto>>(talabalar));
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetTalabaById(int id)
        {
            var talaba = await _repository.GetTalabaById(id);
            if (talaba is null)
                return NotFound();
            return Ok(_mapper.Map<TalabaReadDto>(talaba));
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTalaba(int id)
        {
            var talabaModelFromRepository = await _repository.GetTalabaById(id);
            if (talabaModelFromRepository is null)
                return NotFound();
            _repository.DeleteTalaba(talabaModelFromRepository);
            await _repository.SaveChanges();
            return NoContent();
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateTalaba(int id, TalabaUpdateDto talabaUpdateDto)
        {
            var talabaModelFromRepository = await _repository.GetTalabaById(id);
            if (talabaModelFromRepository is null)
                return NotFound();
            _mapper.Map(talabaUpdateDto, talabaModelFromRepository);
            await _repository.UpdataTalaba(talabaModelFromRepository);
            await _repository.SaveChanges();
            return NoContent();
        }
    }
}
