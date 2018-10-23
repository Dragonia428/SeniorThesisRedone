using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invisible_Walls : MonoBehaviour {

    private void OnCollisionEnter(Collision collision)
    {
        //Prevents player from just carelessly wandering onto the tracks.
        if (collision.collider.tag == "Train")
            Destroy(this.gameObject);
    }
}
