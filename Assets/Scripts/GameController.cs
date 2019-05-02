using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/* GameController handles game state, menu input, and points. */
public class GameController : MonoBehaviour
{
    public enum State {Start, Running, GameOver}
    public static State state = State.Start;

    public static float points = 0;
    public float pointRate = 0.1f;

    void Awake() {
        points = 0;
    }

    void Update() {
        if (Input.GetButton("Jump")) {
            switch (state) {
                // Start game if space is pressed on start screen
                case State.Start:
                    state = State.Running;
                    break;
                // Restart scene if space is pressed on game over screen
                case State.GameOver:
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                    state = State.Running;
                    break;
            }
        }
    }

    // Increment points once a frame while game is running.
    void FixedUpdate() {
        if (state == State.Running) {
            points += pointRate;
        }
    }
}
