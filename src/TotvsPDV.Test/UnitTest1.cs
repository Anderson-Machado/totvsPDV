using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using TotvsPDV.Application.Defaults;
using TotvsPDV.Domain.Defaults;
using TotvsPDV.Domain.Entities;
using TotvsPDV.Domain.Interfaces.Repositories;

namespace TotvsPDV.Test
{
  [TestClass]
  public class UnitTest1
  {
    [TestMethod]
    public void Caso02()
    {
      var valor = 100;
      var pg = 20;
      string result = Troco(valor, pg);

      string esperado = "R$-80---1Nota(s) de R$50---1Nota(s) de R$20---1Nota(s) de R$10";

      Assert.AreEqual(esperado, result, "O Resultado nao foi valido");
    }

    [TestMethod]
    public void Caso01()
    {
      var valor = 20;
      var pg = 50;
      string result = Troco(valor, pg);

      string esperado = "R$30--1Nota(s) de R$20--1Nota(s) de R$10";

      Assert.AreEqual(esperado, result, "O Resultado nao foi valido");
    }

    public string Troco(decimal valor, decimal pago)
    {
      decimal[] notas = { 100, 50, 20, 10, 5, 2, 1 };
      decimal[] moedas = { 50, 25, 10, 5, 1 };
      string nota = "";
      string moeda = "";
      var troco = pago - valor;
      var tr = troco;
      string result = "R$" + troco;

      for (int i = 0; i < notas.Length; i++)
      {
        var ct = (int)(tr / notas[i]);
        if (ct != 0)
        {
          result = result;
          nota = nota + "--" + ct + "Nota(s) de R$" + notas[i];
          tr = tr % notas[i];
        }
      }

      result = result ;

      tr = (int)Math.Round((troco - (int)troco) * 100);
      // int i = 0;

      for (int i = 0; i < moedas.Length; i++)
      {
        var ct = tr / moedas[i];
        if (ct != 0)
        {
          result = result;
          moeda = moeda + "--" + ct + "Moeda(s) de R$ " + moedas[i];
          tr = tr % moedas[i];
        }
      }
      return result + nota + moeda;
    }
  }
}
