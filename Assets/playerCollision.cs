using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCollision : MonoBehaviour {

    void OnTriggerStay(Collider col)
    {
            print("colliding");
            if (Input.GetKeyDown(KeyCode.Space)) //|| Input.GetKeyUp(KeyCode.Space))
            {
                Destroy(col.gameObject);
            }   
    }
}
