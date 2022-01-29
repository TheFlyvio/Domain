using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T_building : T_piece {
  public int spawn_rate;
  public long last_spawn;
  public GameObject[] prefab;
  public float vel_x;
  public float vel_y;

  override protected void Awake() {
    base.Awake();
    spawn_rate = 1000;
    last_spawn = lib.get_milliseconds();
  }

  override public void on_frame(int frame_no) {
    if(lib.get_milliseconds() > last_spawn + spawn_rate) {
      spawn();
    }
  }

  private void spawn() {
    last_spawn = lib.get_milliseconds();
    T_unit instance = (T_unit)map.new_instance(gameObject, prefab[0], vel_x*10, vel_y*10);
    instance.vel_x = vel_x;
    instance.vel_y = vel_y;
  }

}
