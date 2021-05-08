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
            return Ok(this.pessoaService.Post(pessoaViewModel));
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(this.pessoaService.GetById(id));
        }


    }
}