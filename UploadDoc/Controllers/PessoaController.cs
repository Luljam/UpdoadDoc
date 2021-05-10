using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UploadDoc.Application.Interfaces;
using UploadDoc.Application.ViewModels;

namespace UploadDoc.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PessoaController : ControllerBase
    {
        private readonly IPessoaService pessoaService;

        public PessoaController(IPessoaService pessoaService)
        {
            this.pessoaService = pessoaService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(this.pessoaService.Get());
        }

        [HttpPost]
        public IActionResult Post(PessoaViewModel pessoaViewModel)
        {
            try
            {
                var pessoa = this.pessoaService.Post(pessoaViewModel);
                if (pessoa)
                {
                    return Ok();
                }
                // Quando já existe prontuário
                return UnprocessableEntity();
            }
            catch (Exception)
            {
                return BadRequest();
            }

        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(this.pessoaService.GetById(id));
        }

        [HttpPut]
        public IActionResult Put(PessoaViewModel pessoaViewModel)
        {
            return Ok(this.pessoaService.Put(pessoaViewModel));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(this.pessoaService.Delete(id));
        }
    }
}