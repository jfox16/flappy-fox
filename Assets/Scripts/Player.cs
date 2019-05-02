using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Player is the Flappy Fox that player controls.
public class Player : MonoBehaviour
{
    [SerializeField] float jumpVelocity = 1;
    [SerializeField] float turnRate = 0.5f;
    new Rigidbody rigidbody;

    void Awake() {
        rigidbody = GetComponent<Rigidbody>();
    }

    void Update() {
        // If game is still at start menu, keep Player in place
        // And stop player from falling infinitely
        if (GameController.state == GameController.State.Start
            || transform.position.y < -20) {
            rigidbody.useGravity = false;
            rigidbody.velocity = Vector3.zero;
        }
        else {
            rigidbody.useGravity = true;
        }

        // Read Jump
        if (GameController.state != GameController.State.GameOver) {
            if (Input.GetButtonDown("Jump")) {
                rigidbody.velocity = new Vector3(0, jumpVelocity, 0);
            }
        }
    }

    // Die on entering triggers tagged "Die Zone"
    void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Die Zone")) {
            GameController.state = GameController.State.GameOver;
        }
    }
}

