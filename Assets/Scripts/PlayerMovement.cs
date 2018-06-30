using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rigidbody;
    public float forwardForce = 2000f;
    public float sidewaysForce = 2000f;

    // Use Fixed Update for Physics
    void FixedUpdate () {
        // Add a forward force
        rigidbody.AddForce(0, 0, forwardForce * Time.deltaTime);


        if ( Input.GetKey("d") )
        {
            rigidbody.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if ( Input.GetKey("a") )
        {
            rigidbody.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rigidbody.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }

}
