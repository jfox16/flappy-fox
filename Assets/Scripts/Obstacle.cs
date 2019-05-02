using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Obstacle moves left and is eventually destroyed.
public class Obstacle : MonoBehaviour
{
    [SerializeField] float moveSpeed = 1f;
    [SerializeField] GameObject topPipe;
    [SerializeField] GameObject bottomPipe;

    new Rigidbody rigidbody;

    void Awake() {
        rigidbody = GetComponent<Rigidbody>();
    }

    void Update() {
        // Move left while game is running.
        if (GameController.state == GameController.State.Running) {
            transform.Translate(-moveSpeed, 0, 0);
        }
        // Destroy Obstacle when it goes off screen.
        if (transform.position.x < -20) {
            Destroy(gameObject);
        }
    }
}
