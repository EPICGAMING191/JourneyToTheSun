using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public GameObject player;
    //public float x;
    //public float y;
    //public Vector3 pos;
    //Vector3 rotateValue;
    public float pt5 = 2.5f;
    public int state = 0;
    public int horizontalInput;
    public int verticalInput;
    public float horizontalSpeed = 2.0f;
    public float verticalSpeed = 2.0f;
    public float maxy;
    public float miny;
    public float adjusted_y;
    //private SceneController sc;

    //Start is called before the first frame update
    void Start(){
        transform.rotation = Quaternion.Euler(0,0,0);  
        //sc = GetComponent<SceneController>();  
    }

    // Update is called once per frame
    void LateUpdate(){
        double yadd = (double) pt5;
        transform.position=player.transform.position + new Vector3(0,pt5,0);
        if (state !=-1){
            float h = horizontalSpeed * Input.GetAxis("Mouse X");
            float v = verticalSpeed * Input.GetAxis("Mouse Y");
            transform.Rotate(0,h,0);
        }
        
    }
}
