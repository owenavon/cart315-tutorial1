using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour {

    public float rotationSpeed = 0.3f;

    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame. Do not assume that every GPU can play back at 60 FPS. Iputs, key presses must be in Update.
    void Update() {

    }

    // If you need to make changes in regular intervals
    void FixedUpdate() {
        this.GetComponent<Transform>().Rotate(0, rotationSpeed, 0);
    }
}
