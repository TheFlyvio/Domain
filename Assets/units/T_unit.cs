using System;
using UnityEngine;

public class T_unit : T_piece {

  static public int count;
  public long calls;
  public long last_calls;
  private long milliseconds;
  public float vel_x;
  public float vel_y;

  override protected void Awake() {
    base.Awake();
    count++;
    milliseconds = lib.get_milliseconds() + 1000;
    last_calls = 0;
    calls = 0;
    vel_x = 0.01f;
    vel_y = 0.01f;
  }

  override public void on_frame(int frame_no) {
    calls++;
    if(lib.get_milliseconds() >= milliseconds) {
      milliseconds += 1000;
      //milliseconds = get_milliseconds() + 1000;
      last_calls = calls;
      calls = 0;
    }
    move_relative(vel_x, vel_y);
  }

}
