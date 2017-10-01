using System;
using Xunit;
using waltonstine.demo.csharptemplate;

namespace waltonstine.demo.csharptemplate.unittests
{
    public class MyCSharpTemplateUnitTests
    {
        [Fact]
        public void CtorSmokeTest()
        {
            MyClass mine = new MyClass();
            Assert.True(true);
        }
 
    }
}
