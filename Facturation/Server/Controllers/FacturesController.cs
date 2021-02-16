using Facturation.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;

namespace Facturation.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FacturesController : ControllerBase
    {
        private readonly ILogger<FacturesController> _logger;
        private readonly IBusinessData _data;

        public FacturesController(ILogger<FacturesController> logger, IBusinessData data)
        {
            _logger = logger;
            _data = data;
        }

        [HttpGet]
        public IEnumerable<Facture> Get()
            => _data.Factures;

        [HttpGet("{numero}")]
        public ActionResult<Facture> Get(string numero)
        {
            var facture = _data.Factures.Where(f => f.Numero == numero).FirstOrDefault();

            if(facture == null)
            {
                return NotFound("Aucune facture avec ce numero");
            }
            else
            {
                return facture;
            }
        }
         
        [HttpPost]
        public ActionResult<Facture> CreateFacture([FromBody] Facture nouvelleFacture)
        {
            if(ModelState.IsValid)
            {
                _data.Add(nouvelleFacture);
                return nouvelleFacture;
            }
            else
            {
                return BadRequest("Facture non valide");
            }
        }
    }
}
