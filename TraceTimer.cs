using Ultranaco.Objects;
using System;
using System.Diagnostics;

namespace Ultranaco.Log
{
  public class TraceTimer:IDisposable
  {
    private Stopwatch _sw;
    private bool _isEnabled = Environment.GetEnvironmentVariable("enable_trace").GetBoolean();
    private bool _isEnabledLog = Environment.GetEnvironmentVariable("enable_log").GetBoolean();
    private string _id;
    public TraceTimer(string id)
    {
      if (_isEnabled)
      {
        _sw = new Stopwatch();
        _sw.Start();
        _id = id;
        if(_isEnabledLog)
          Console.WriteLine("[Starting '{0}': DateTime: {1}]", _id, DateTime.Now.ToString("yyyy-MM-ddTHH\\:mm\\:ss.fffffffzzz"));
      }
    }

    public void Dispose()
    {
      if (_isEnabled)
      {
        _sw.Stop();
        if (_isEnabledLog)
          Console.WriteLine("[Ending '{0}': Elapsed: {1}ms, DateTime: {2}]",_id, _sw.ElapsedMilliseconds, DateTime.Now.ToString("yyyy-MM-ddTHH\\:mm\\:ss.fffffffzzz"));
      }
    }
  }
}
