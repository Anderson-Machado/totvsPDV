using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TotvsPDV.Domain.Interfaces.Repositories;

namespace TotvsPDV.Domain.Defaults
{
  public class CalculationPDV
  {
    private readonly IMoedasRepository _moedarepository;
    private readonly INotasRepository _notasRepository;
    public CalculationPDV(INotasRepository notasRepository, IMoedasRepository moedasRepository)
    {
      _moedarepository = moedasRepository;
      _notasRepository = notasRepository;
    }

    
    public string Troco(decimal valor, decimal pago)
    {
      var caixa = NotasAndMoedasDisponiveis();
      var notas = caixa.Item1;
      var moedas = caixa.Item2;
      var troco = pago - valor;
      string nota = "";
      string moeda = "";
      var tr = troco;
      string result = "R$" + troco;

    for (int i = 0; i < notas.Length; i++)
      {
        var ct = tr / notas[i];
        if (ct != 0)
        {
          result = result;
          nota = nota + "\n" + ct + "Nota(s) de R$" + notas[i]+"\n";
          tr = tr % notas[i];
        }
      }
     



      result = result + "\n";

      tr = Math.Round((troco - troco) * 100);
      // int i = 0;

      for (int i = 0; i < moedas.Length; i++)
      {
        var ct = tr / moedas[i];
        if (ct != 0)
        {
          result = result;
          moeda = moeda + "\n" + ct + "Moeda(s) de R$ " + moedas[i] + "\n";
          tr = tr % moedas[i];
        }
      }
      return result + nota + moeda;
    }

    private Tuple<decimal[], decimal[]> NotasAndMoedasDisponiveis()
    {
      var notas = _notasRepository.Obter();

      var moedas = _moedarepository.Obter();

      var allNotas = notas.SelectMany(h => new[] { h.Valor })
                          .Distinct()
                          .ToArray();

      var allMoedas = moedas.SelectMany(h => new[] { h.Moeda })
                          .Distinct()
                          .ToArray();
      var tuple = (allNotas, allMoedas);

      return tuple.ToTuple();
    }
  }
}
