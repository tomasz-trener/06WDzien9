using Microsoft.VisualStudio.TestTools.UnitTesting;
using P03AplikacjaZawodnicy.Core.Repositories;
using P03AplikacjaZawodnicy.ViewModels;
using System;

namespace P06TestRepozytorium
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ZawodnicyRepository zr = new ZawodnicyRepository();

            zr.Zawodnicy = new ZawodnikVM[]
            {
                new ZawodnikVM(){ Imie = "jan1"},
                new ZawodnikVM(){ Imie = "jan2"},
                new ZawodnikVM(){ Imie = "jan3"},
                new ZawodnikVM(){ Imie = "jan4"},
                new ZawodnikVM(){ Imie = "jan5"},
                new ZawodnikVM(){ Imie = "jan6"},
            };

            zr.Strona(1);


            Assert.AreEqual(5, zr.Zawodnicy.Length);

        }

        [TestMethod]
        public void TestMethod2()
        {
            ZawodnicyRepository zr = new ZawodnicyRepository();

            zr.Zawodnicy = new ZawodnikVM[]
            {
                new ZawodnikVM(){ Imie = "jan1"},
                new ZawodnikVM(){ Imie = "jan2"},
                new ZawodnikVM(){ Imie = "jan3"},
                new ZawodnikVM(){ Imie = "jan4"},
                new ZawodnikVM(){ Imie = "jan5"},
                new ZawodnikVM(){ Imie = "jan6"},
            };

            zr.Strona(2);


            Assert.AreEqual(6, zr.Zawodnicy.Length);

        }
    }
}
