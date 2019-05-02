using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// PointsDisplay displays point with text appended to it.
public class PointsDisplay : MonoBehaviour
{
    [SerializeField] string displayText = "Points: ";
    Text pointsText;

    void Awake() {
        pointsText = GetComponent<Text>();
    }

    void Update() {
        // Update text with points.
        pointsText.text = displayText + (int)GameController.points;
    }
}
