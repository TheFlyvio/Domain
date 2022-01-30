using System;
using System.Drawing;
using UnityEngine;

public class lib {

  static public long get_milliseconds() {
    return DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
  }

  static public Vector2 speed_distribution(float speed, float angle) {
    Vector2 p = new Vector2(0, 0);
    float mag;
    if(angle < 0) {
      angle += 360;
    }
    if(angle <= 90) {
      mag = angle / 90;
      p.x = speed*(1-mag);
      p.y = speed * mag;
    } else if(angle <= 180) {
      angle -= 90;
      mag = angle / 90;
      p.x = -(speed * mag);
      p.y = speed * (1 - mag);
    } else if(angle <= 270) {
      angle -= 180;
      mag = angle / 90;
      p.x = -(speed * (1 - mag));
      p.y = -(speed * mag);
    } else {
      angle -= 270;
      mag = angle / 90;
      p.x = speed * mag;
      p.y = -(speed * (1 - mag));
    }
    return p;
  }

  static public float target_direction(Vector3 base_pos, Vector3 target_pos) {
    float angle = 0;
    Vector3 direction = target_pos - base_pos;
    if(direction != Vector3.zero) {
      angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
    }
    return angle;
  }
}
