using System;
using System.Threading;

namespace waltonstine.demo.csharpthreadsync
{
    /*
     * Minimal example class for a thread that exposes a "WaitForReady" method.
     *
     */
    public class ThreadWrapper : IDisposable
    {
        private ManualResetEvent mr;
        private Thread           t;

        private bool initDone;

        public bool InitIsDone { get { return initDone; } }

        public bool WaitForReady() 
        {
            mr.WaitOne();
            return true;
        }

        public ThreadWrapper()
        {
            t               = new Thread(ThreadFunction);
            t.IsBackground  = true;

            initDone        = false;

            mr = new ManualResetEvent(false);
        }

        public void StartThread()
        {
            t.Start();
        }

        public void JoinThread()
        {
            t.Join();
        }

        public bool IsAlive { get { return t.IsAlive; } }

        /*
         * ThreadFunction - the function executed when the thead is started.
         * This is a dummy; it represents work that a thread might do.
         */
        private void ThreadFunction()
        {
            Thread.Sleep(2);

            initDone = true;

            mr.Set();

            byte[] randBytes = new byte[512];

            Random rng = new Random();

            int loops = 20;
            while (loops-- > 0) 
            {
                rng.NextBytes(randBytes);
            }

        }

        #region IDisposable Support

        protected virtual void Dispose(bool disposing)
        {
            if (mr != null)
            {
                if (disposing)
                {
                    mr.Dispose();
                }

                mr = null;
            }
        }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
        }
        #endregion
    }

}
