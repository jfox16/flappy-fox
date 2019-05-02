using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* ConditionalUI is for rendering UI components depending on the current game state. */
public class ConditionalUI : MonoBehaviour
{
    [SerializeField] GameController.State displayOnState;
    [SerializeField] GameObject displayObject;

    void Update() {
        // if the current state matches displayOnState, render displayObject.
        displayObject.SetActive(GameController.state == displayOnState);
    }
}
