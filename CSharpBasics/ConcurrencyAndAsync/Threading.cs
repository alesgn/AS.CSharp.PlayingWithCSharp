using System;
using System.Threading;

namespace CSharpBasics.ConcurrencyAndAsync
{
    //THREAD: an execution path that can proceed independently of others. Runs within an operating system process (provides an isolated environment)
    //- single-threaded program: just one thread runs in the process’s isolated environment, and so that thread has exclusive access to it.
    //- multithreaded program: multiple threads run in a single process, sharing the same execution environment (memory, in particular). Data share by two or more threads is called "Shared State"

    //Client program starts in a single "main" thread created by OS. It is single-threaded until more threads are created (directly or indirectly - CLR for garbage collection).
    public class Threading
    {
        public void CreateAndRunThread()
        {
            Thread t = new Thread(WriteY); // Create a new thread passing a ThreadStartdelegate (parameterless method indicating begin of execution)
            t.Start(); // running WriteY()
                       
            for (int i = 0; i < 1000; i++) Console.Write("x"); // Simultaneously, do something on the main thread.
        }

        private static void WriteY()
        {
            for (int i = 0; i < 1000; i++) Console.Write("y");
        }
    }
}