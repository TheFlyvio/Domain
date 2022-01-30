using System;
using UnityEngine;

public class T_unit : T_piece {

  static public int count;

  public long calls;
  public long last_calls;
  public float target_x;
  public float target_y;
  public float speed;

  private long milliseconds;
  private float move_angle;
  private Vector2 mag_dist;

  override protected void Awake() {
    base.Awake();
    count++;
    milliseconds = lib.get_milliseconds() + 1000;
    last_calls = 0;
    calls = 0;
    target_x = 83f;
    target_y = 17f;
    speed = 0.01f;
  }

  override public void on_frame(int frame_no) {
    calls++;
    if(lib.get_milliseconds() >= milliseconds) {
      milliseconds += 1000;
      //milliseconds = get_milliseconds() + 1000;
      last_calls = calls;
      calls = 0;
    }
    //move_relative(vel_x, vel_y);
    move_angle = point_direction(new Vector3(target_x, target_y));
    mag_dist = speed_distribution(speed, move_angle);
    move_relative(mag_dist.x, mag_dist.y);
  }

  private void Update() {
    //move_angle = point_direction(new Vector3(target_x, target_y));
    //mag_dist = speed_distribution(speed, move_angle);
    //move_relative(mag_dist.x, mag_dist.y);
  }

}
