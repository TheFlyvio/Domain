using System;
using System.Collections.Generic;
using UnityEngine;

public class T_map : MonoBehaviour {
  static private List<T_piece> list = new List<T_piece>();
  public bool fixedu;
  private int frame_n;
  public GameObject building;

  private void Awake() {
    T_building b;
    //
    b = (T_building)new_instance(gameObject, building, 0.5f, 28);
    b.speed = 0.01f;
    //
    b = (T_building)new_instance(gameObject, building, 0.5f, 5.5f);
    b.speed = 0.01f;

    Debug.Log(lib.speed_distribution(1, 0));
    Debug.Log(lib.speed_distribution(1, 0));
    Debug.Log(lib.speed_distribution(1, 0));
    Debug.Log(lib.speed_distribution(1, 0));
    Debug.Log(lib.speed_distribution(1, 0));
    Debug.Log(lib.speed_distribution(1, 0));
    Debug.Log(lib.speed_distribution(1, 0));
    Debug.Log(lib.speed_distribution(1, 0));
  }

  private void FixedUpdate() {
    if(fixedu) {
      int count = list.Count;
      for(int i=0; i<count; i++) {
        list[i].on_frame(++frame_n);
      }
    }
  }

  private void Update() {
    if(!fixedu) {
      int count = list.Count;
      for(int i = 0; i < count; i++) {
        list[i].on_frame(++frame_n);
      }
    }
  }

  public void move_piece(T_piece p, float x, float y) {
    p.transform.localPosition = new Vector3(x, y, y);
    p.render.sortingOrder = 10000 - (int)(y * 10);
  }

  public T_piece new_instance(GameObject owner, GameObject g, float rel_x, float rel_y) {
    Vector3 v = owner.transform.localPosition + new Vector3(rel_x, rel_y, 0);
    T_piece p = (T_piece)Instantiate(g, v, Quaternion.identity).GetComponent(typeof(T_piece));
    p.map = this;
    move_piece(p, v.x, v.y);
    list.Add(p);
    return p;
  }
}
