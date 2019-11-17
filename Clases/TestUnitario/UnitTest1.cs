using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades.Estacionamientos.starter;

namespace TestUnitario
{
  [TestClass]
  public class UnitTest1
  {
    [TestMethod]
    public void TestMethod1()
    {
      Estacionamiento e = new Estacionamiento(10);
      Assert.IsNotNull(e.Autos);
    }

    [TestMethod]
    public void EspacioEstacionamientoIncorrecto()
    {
      Estacionamiento e = new Estacionamiento(101);
      Estacionamiento e2 = new Estacionamiento(0);

      if (e.EspacioDisponible != 101)
      {
        Assert.Fail("Espacio es incorrecto {0}", e.EspacioDisponible);
      }

      //Assert.AreNotEqual(e2.EspacioDisponible, 1);

      if(e2.EspacioDisponible != 0)
      {
        Assert.Fail("Espacio es incorrecto {0}", e.EspacioDisponible);
      }
    }

    [TestMethod]
    public void AgregarAutoEstacionamiento()
    {
      Estacionamiento e = new Estacionamiento(2);
      Auto a1 = new Auto("AAA", ConsoleColor.Black);
      Auto a2 = new Auto("BBB", ConsoleColor.Blue);
      Auto a3 = new Auto("CCC", ConsoleColor.DarkRed);

      try
      {
        e += a1;
        e += a2;
        e += a3;

        //.Fail("Error carga de Autos");
      }
      catch (Exception ex)
      {
        Assert.IsInstanceOfType(ex, typeof(EstacionamientoLlenoException));
        //throw;
      }
    }

    [TestMethod]
    public void AgregarAutoEspacioDisponible()
    {
      Estacionamiento e = new Estacionamiento(2);
      Auto a1 = new Auto("AAA", ConsoleColor.Black);
      Auto a2 = new Auto("BBB", ConsoleColor.Blue);
      
      e += a1;

      Assert.AreEqual(e.EspacioDisponible, 1);
      e += a2;
      Assert.AreEqual(e.EspacioDisponible, 0);
    }
  }
}
