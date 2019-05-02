using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// TextFlasher is for displaying flashing text.
public class TextFlasher : MonoBehaviour
{
    [SerializeField] float flashTime = 0.5f;
    Text flashText;

    void Awake() {
        flashText = GetComponent<Text>();
    }

    void Start() {
        InvokeRepeating("Flash", 0, flashTime);
    }

    void Flash() {
        flashText.enabled = !flashText.enabled;
    }
}
