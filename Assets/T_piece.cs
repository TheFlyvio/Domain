using System;
using System.Collections.Generic;
using UnityEngine;

public class T_piece : MonoBehaviour {

  public SpriteRenderer render;
  public T_map map;

  virtual protected void Awake() {
    render = GetComponent<SpriteRenderer>();
  }

  virtual public void on_frame(int frame_n) {
  }

  protected void move_relative(float rx, float ry) {
    map.move_piece(this, transform.localPosition.x+rx, transform.localPosition.y+ry);
  }

  public float point_direction(Vector3 target_pos) {
    return lib.target_direction(transform.position, target_pos);
  }

  public Vector2 speed_distribution(float speed, float direction) {
    return lib.speed_distribution(speed, direction);
  }
}
