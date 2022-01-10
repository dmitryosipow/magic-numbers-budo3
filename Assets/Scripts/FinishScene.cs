using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinishScene : MonoBehaviour
{
    public Button RestartBtn;

    void Start()
    {
        RestartBtn.onClick.AddListener(GotoStart);
    }

    private void GotoStart()
    {
        GameManager.LoadScene("StartScene");
    }
}