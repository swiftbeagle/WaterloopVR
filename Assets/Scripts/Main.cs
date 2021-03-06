﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{

    //myModel.gameObject.transform.position = new Vector3(10, 10, 10);
    public GameObject myModel;
    void Start() {
        myModel = GameObject.FindGameObjectWithTag("Model");
    }
    
    // Update is called once per frame
    void Update() {
        // myModel.transform.position = new Vector3(10f, 10f, 10f);
        if (Input.GetKey("up")) {
            
            myModel.transform.position = new Vector3(myModel.transform.position.x, myModel.transform.position.y + 0.2f, myModel.transform.position.z);
        }
        
        if (Input.GetKey("down")) {
            myModel.transform.position = new Vector3(myModel.transform.position.x, myModel.transform.position.y - 0.2f, myModel.transform.position.z);
        }
        if (Input.GetKey("left")) {
            myModel.transform.position = new Vector3(myModel.transform.position.x - 0.2f, myModel.transform.position.y, myModel.transform.position.z);
        }
        if (Input.GetKey("right")) {
            myModel.transform.position = new Vector3(myModel.transform.position.x + 0.2f, myModel.transform.position.y, myModel.transform.position.z);
        }

    }
}
