using System;
using System.IO;
using NUnit.Framework;
using Ucu.Poo.TestDateFormat;

namespace Library.Tests
{
    public class DataFormatterTests
    {

        // Creo un test para la fecha correcta
        [Test]
        public void TestCorrectDate()
        {
            const string myDate = "02/04/2002";
            const string dateExpected = "2002-04-02";

            string newFormatDate = DateFormatter.ChangeFormat(myDate);

            Assert.AreEqual(dateExpected, newFormatDate);
        }

        // Creo un test para chequear la fecha incorrecta
        [Test]
        public void TestIncorrectDate()
        {
            const string myDate = "2/04/2002";
            const string dateExpected = "La longitud de la fecha tiene que tener 10 caracteres";

            string newFormatDate = DateFormatter.ChangeFormat(myDate);

            Assert.AreEqual(dateExpected, newFormatDate);
        }

        // Creo un test para chequear la fecha en blanco
        [Test]
        public void TestBlankDate()
        {
            const string myDate = "";
            const string dateExpected = "La fecha no puede ser vacía";

            string newFormatDate = DateFormatter.ChangeFormat(myDate);

            Assert.AreEqual(dateExpected, newFormatDate);
        }
    }
}