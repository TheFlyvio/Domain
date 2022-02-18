using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T_camera : MonoBehaviour{
  Vector3 mouse_pos;
  float camera_move;
  int camera_threshold;

  private void Awake() {
    camera_move = 0.25f;
    camera_threshold = 40;
  }

  void Update() {
    mouse_pos = Input.mousePosition;
    if((mouse_pos.x < camera_threshold) && (transform.position.x > 0)) {
      transform.position -= new Vector3(camera_move, 0, 0);
    }
    if((mouse_pos.y < camera_threshold) && (transform.position.y > 0)) {
      transform.position -= new Vector3(0, camera_move, 0);
    }
    if((mouse_pos.x > (Screen.width - camera_threshold)) && (transform.position.x < Screen.width)) {
      transform.position += new Vector3(camera_move, 0, 0);
    }
    if((mouse_pos.y > (Screen.height - camera_threshold)) && (transform.position.y < Screen.height)) {
      transform.position += new Vector3(0, camera_move, 0);
    }
    if(transform.position.x < 0){
      transform.position = new Vector3(0, transform.position.y, transform.position.z);
    }
    if(transform.position.y < 0){
      transform.position = new Vector3(transform.position.x, 0, transform.position.z);
    }
    if(transform.position.x > Screen.width){
      transform.position = new Vector3(Screen.width, transform.position.y, transform.position.z);
    }
    if(transform.position.y > Screen.height){
      transform.position = new Vector3(transform.position.x, Screen.height, transform.position.z);
    }
  }
}
