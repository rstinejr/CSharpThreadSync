using System;
using System.Threading;
using Xunit;
using waltonstine.demo.csharpthreadsync;

namespace waltonstine.demo.csharpthreadsync.unittests
{
    public class MyCSharpTemplateUnitTests
    {
        [Fact]
        public void CheckWait()
        {
            /* 
             * Show that wait works for letting the Thread finish initializaion.
             */
            ThreadWrapper tw = new ThreadWrapper();
            tw.StartThread();
            Assert.False(tw.InitIsDone);
            tw.WaitForReady();
            Assert.True(tw.InitIsDone);
 
        }
 
        [Fact]
        public void ManyWaits()
        {
            /*
             * Show that multiple waits are benign.
             */
            ThreadWrapper tw = new ThreadWrapper();
            tw.StartThread();

            tw.WaitForReady();
            tw.WaitForReady();
            Assert.True(tw.InitIsDone);
            Thread.Sleep(4);
            Assert.True(tw.InitIsDone);
            tw.WaitForReady();
        }
    }
}
