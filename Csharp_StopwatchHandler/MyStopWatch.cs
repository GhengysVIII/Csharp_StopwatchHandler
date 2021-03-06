
using System.Diagnostics;
/// <summary>
/// Override the Stopwatch Class to make the only important things
/// </summary>
/// 
namespace Csharp_StopwatchHandler {
    public class MyStopWatch {

        // Original Stopwatch
        private Stopwatch sw;

        // CTOR
        public MyStopWatch() {
            sw = new Stopwatch();
        }

        // this function start/continue the count on a Watch
        public void StartWatch() { sw.Start(); }

        // this function stop the count on a Watch
        public void StopWatch() { sw.Stop(); }

        // this function Reset the time on selected Watch
        public void ResetWatch() { sw.Reset(); }

        // this function return the time in milliseconds on a Watch
        public long GetTimeWatch() { return sw.ElapsedMilliseconds; }
    }
}
