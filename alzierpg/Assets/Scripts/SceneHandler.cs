using System;
using UnityEngine;

public class SceneHandler : MonoBehaviour
{
    private TextHandler textHandler;

    private void Awake()
    {
        textHandler = GetComponent<TextHandler>();
    }

    void Start()
    {
        if (textHandler != null)
        {
            textHandler.SetTexts();
        }
    }

}
