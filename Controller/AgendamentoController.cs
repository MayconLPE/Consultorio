using Consultorio.Models.Entities;
using Consultorio.Services;
using Microsoft.AspNetCore.Mvc;

namespace Consultorio.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class AgendamentoController : ControllerBase
    {
        private readonly IEmailService _emailService;
        List<Agendamento> agendamentos = new List<Agendamento>();

        public AgendamentoController(IEmailService emailService)
        {
            agendamentos.Add(new Agendamento()
            {
                Id = 1,
                NomePaciente = "Maycon",
                Horario = new DateTime(2024, 06, 26)
            });
            _emailService = emailService;
            
        }


        [HttpGet]
       public IActionResult Get()
        {
            return Ok(agendamentos);
        }

        [HttpGet("busca-agendamento/{id}")]
        public IActionResult GetById(int id)
        {
           var agendamentoSelecionado = agendamentos.FirstOrDefault(x => x.Id == id);
            return agendamentoSelecionado != null
                 ? Ok(agendamentoSelecionado)
                 : BadRequest("Erro ao buscar o agendamento");
        }

        [HttpPost]
        public IActionResult Post()
        {
            var pacienteAgendado = true;

            

            if (pacienteAgendado)
            {
                _emailService.EnviarEmail("maycon@gmail.com");
            }
            return Ok();
        }


    }
}
