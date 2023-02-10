using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionResponse : MonoBehaviour
{
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject == player)
        {
            Vector3 force = this.transform.position - collision.collider.gameObject.transform.position; // One posistion - other posistion to make ball move forward
            force.Normalize(); // Always have a force of exactly 200
            force = force * 200f; // Scales vector, and reduces magnitude
            this.GetComponent<Rigidbody>().AddForce(force); // Force changes the accleration
        }
    }
}
