using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PointsManager : MonoBehaviour
{
    private int points;
    private TextMeshProUGUI textMesh;
    // Start is called before the first frame update
    void Start()
    {
        points = 0;
        textMesh = transform.Find("TextPoints").gameObject.GetComponent<TextMeshProUGUI>();
        updateText();
    }

    public void increasePoints()
    {
        points += 1;
        updateText();
    }

    public void decreasePoints()
    {
        points -= 2;
        updateText();
    }

    private void updateText()
    {
        textMesh.text = "Puntos: " + points.ToString();
    }
}
