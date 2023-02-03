using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Looker : MonoBehaviour
{
    public GameObject target;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate() 
    {
        this.GetComponent<Transform>().LookAt(target.GetComponent<Transform>()); // target.transform // Look at the player
        this.transform.Translate(new Vector3(0, 0, 0.01f), Space.Self); // Move forward on the local Z axis
    }
}
