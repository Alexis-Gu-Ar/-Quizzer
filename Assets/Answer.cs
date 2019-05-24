using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;
using UnityEngine.UI;


public class Answer : MonoBehaviour
{
    public bool isCorrect;
    public string text;
    private TextMeshProUGUI textMesh;

    // Start is called before the first frame update
    void Start()
    {
        textMesh = getTextMesh(gameObject);
        textMesh.text = text;
        textMesh.enableVertexGradient = true;
        textMesh.colorGradientPreset = Resources.Load<TMP_ColorGradient>("TextGradients/Option");
    }
    
    public void highlight()
    {
        if (isCorrect)
        {
            textMesh.colorGradientPreset = Resources.Load<TMP_ColorGradient>("TextGradients/Correct");
        }
        else
        {
            textMesh.colorGradientPreset = Resources.Load<TMP_ColorGradient>("TextGradients/Incorrect");
        }
    }

    public void disableColider()
    {
        gameObject.GetComponent<Button>().interactable = false;

    }

    static private TextMeshProUGUI getTextMesh(GameObject answer)
    {
        return answer.transform.Find("TextMeshOption").gameObject.GetComponent<TextMeshProUGUI>();
    }
}
