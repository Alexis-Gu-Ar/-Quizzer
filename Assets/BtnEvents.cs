using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.EventSystems;

public class BtnEvents : MonoBehaviour
{
    private float gazeTimer;
    private bool gazeAt;
    private float gazeTime;

    // Start is called before the first frame update
    void Start()
    {
        gazeTimer = 0f;
        gazeTime = 2f;
        gazeAt = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (gazeAt)
        {
            gazeTimer += Time.deltaTime;

            if (gazeTime < gazeTimer)
            {
                ExecuteEvents.Execute(gameObject, new PointerEventData(EventSystem.current), ExecuteEvents.pointerClickHandler);
                gazeTimer = 0;
            }
        }
    }

    public void PointerEnter()
    {
        gazeAt = true;
        Debug.Log("pointer enter");

    }

    public void PointerExit()
    {
        gazeAt = false;
        gazeTimer = 0;
        Debug.Log("pointer exit");

    }
}
