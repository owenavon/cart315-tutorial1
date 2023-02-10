using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Caster : MonoBehaviour
{
    public GameObject prefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray theRay = Camera.main.ScreenPointToRay(Input.mousePosition); // Point and a vector / Camera to mouse pointer
            RaycastHit rayHitInfo; // Object that holds results
            if (Physics.Raycast(theRay, out rayHitInfo)) // Do ray cast, and put output in the ray cast hit. Return true if it does hit, otherwise false
            {
                if (rayHitInfo.collider.gameObject.CompareTag("Pickup"))
                {
                    GameObject.Destroy(rayHitInfo.collider.gameObject); // Destroy cube
                }
                else
                {
                    GameObject.Instantiate(prefab, rayHitInfo.point, Quaternion.identity); // Makes a copy of the gmaeObject. Quaeternion.identiy means rotation that does not do anything.
                }
            }
        }
    }
}
