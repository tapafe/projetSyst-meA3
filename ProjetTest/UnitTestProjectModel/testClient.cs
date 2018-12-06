﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Salle.model;

namespace UnitTestProjectModel
{
    [TestClass]
    public class testClient
    {
        [TestMethod]
        public void parlerTest()
        {
            maitreHotel mh = new maitreHotel();
            Client cli = new Client();

            (int, int) expectedResult = (1, 2);
            (int, int) actualResult = cli.parler(mh);

            Assert.AreEqual(expectedResult, actualResult);

        }


        [TestMethod]
        public void placementTest()
        {
            Client cli = new Client();
            cli.group = 5;
            maitreRang mr = new maitreRang();

            (int, int) expectedResult = (1, 3);
            (int, int) actualResult = cli.placement(mr);

            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void commanderTest()
        {
            Client cli = new Client();
            Menu menu = new Menu();


            (string, string, string) expectedResult = ("pates", "pates", "pates");
            (string, string, string) actualResult = cli.commande(menu);

            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void payerTest()
        {
            Client cli = new Client();
            maitreHotel mh = new maitreHotel();


            int expectedResult = 50;
            int actualResult = cli.payer();

            Assert.AreEqual(expectedResult, actualResult);

        }
    }
}
