using System;
using System.Text.RegularExpressions;
using NUnit.Framework;

namespace TestBaseGenerator.Tests
{
    public abstract class SpecificationBase
    {
        [SetUp]
        public void Setup()
        {
            Given();
            When();
        }

        public virtual void Given(){}
        public virtual void When(){}
    }
}
