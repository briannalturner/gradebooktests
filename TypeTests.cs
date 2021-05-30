using System;
using System.Collections.Generic;
using Xunit;

namespace GradeBook.Tests
{
    public delegate string WriteLogDelegate(string logMessage);
    public class TypeTests
    {
        [Fact]
        public void WriteLogDelegateCanPointToMethod()
        {
            WriteLogDelegate log;

            log = ReturnMessage;

            var result = log("hello");
            Assert.Equal("hello", result);
        }

        string ReturnMessage(string message)
        {
            return message;
        }

        [Fact]
        public void GetBookReturnsDifferentObjects()
        {
            var book1 = GetBookByName("Bri's GradeBook");
            var book2 = GetBookByName("Not Bri's GradeBook");

            // assert
            Assert.Equal("Bri's GradeBook", book1.Name);
            Assert.NotEqual("Bri's GradeBook", book2.Name);
        }

        InMemoryBook GetBookByName(string name)
        {
            return new InMemoryBook(name: name, grades: new List<double>() { });
        }
    }
}
