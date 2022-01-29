using System;

public class lib {

  static public long get_milliseconds() {
    return DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
  }

}
