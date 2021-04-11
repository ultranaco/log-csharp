using System;
using System.Collections.Generic;
using System.Text;

namespace Ultranco.Log
{
  public interface ITraceTimer
  {
    void SendMetric(int value, string name, string dimension = null);
  }
}
