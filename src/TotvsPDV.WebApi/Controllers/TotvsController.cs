using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TotvsPDV.Application.Defaults;
using TotvsPDV.Application.ViewModels;

namespace TotvsPDV.WebApi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class TotvsController : ControllerBase
  {
    private readonly Calculation _calculation;
    public TotvsController(Calculation calculation)
    {
      _calculation = calculation;
    }

    // GET: api/Totvs/GetTroco
    [HttpGet(Name = "GetTroco")]
    public string GetTroco([FromBody] CalculationViewModel value)
    {
      var result = _calculation.getTroco(value.ValorTotal, value.ValorTotal);
      return result == null ? NoContent().ToString() : result;
    }


  }
}
