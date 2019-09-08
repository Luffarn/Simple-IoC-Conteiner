using System;
using System.Collections.Generic;
using System.Text;

namespace Develier.SimpleIoC.Tests.Fakes
{
    public class Person : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}
