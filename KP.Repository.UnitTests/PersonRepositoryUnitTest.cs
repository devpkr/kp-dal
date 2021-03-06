﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KP.Repository.UnitTests
{
    [TestClass]
    public class PersonRepositoryUnitTest
    {
        [TestMethod]
        public void Should_Return_Person_Object_That_Matches_Identifier()
        {
            // Arrange
            var id = 1;
            var personRepository = new PersonRepository();

            // Act
            Person person = personRepository.GetById(id);

            // Assert
            Assert.AreEqual(id, person.PersonId);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Should_Get_ArgumentException_When_Id_Is_Not_Positive_Integer()
        {
            // Arrange
            var id = -1;
            var personRepository = new PersonRepository();

            // Act
            Person person = personRepository.GetById(id);
        }
    }
}
