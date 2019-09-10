using System;
using System.Collections.Generic;
using System.Text;
using TotvsPDV.Domain.Defaults;

namespace TotvsPDV.Application.Defaults
{
  public class Calculation
  {
    private readonly CalculationPDV _calculationPDV;

    public Calculation(CalculationPDV calculationPDV)
    {
      _calculationPDV = calculationPDV;
    }

    public string getTroco(decimal valor, decimal pago)
    {
      return _calculationPDV.Troco(valor, pago);
    }

  }
}
