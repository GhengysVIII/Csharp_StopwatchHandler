
using System.Collections.Generic;
/// <summary>
/// Stopwatch Handler is used to manage 
/// multiple Stopwatches for the time duration management
/// </summary>
/// 
namespace Csharp_StopwatchHandler {
    public class StopwatchHandler {

        // Container of all StopWatch
        private Dictionary<string, MyStopWatch> Stopwatchs;

        // CTOR
        public StopwatchHandler() {
            Stopwatchs = new Dictionary<string, MyStopWatch>(); 
        }

        // indexer of StopWatches
        public MyStopWatch this[int i] { get => Stopwatchs[i.ToString()]; }
        public MyStopWatch this[string s] { get => Stopwatchs[s]; }

        // this function create a Watch in Watch list
        public MyStopWatch CreateWatch(int watchNum) { return CreateWatch(watchNum.ToString()); }
        public MyStopWatch CreateWatch(string watchName) {
            if (!Stopwatchs.ContainsKey(watchName)) {
                Stopwatchs.Add(watchName, new MyStopWatch());
            }
            else {
                RemoveWatch(watchName);
                Stopwatchs.Add(watchName, new MyStopWatch());
            }
            return this[watchName];
        }

        // this function remove the selected Watch
        public void RemoveWatch(int watchNum) { RemoveWatch(watchNum.ToString()); }
        public void RemoveWatch(string key) {
            if (Stopwatchs.ContainsKey(key)) {
                Stopwatchs.Remove(key);
            }
        }
    }
}
