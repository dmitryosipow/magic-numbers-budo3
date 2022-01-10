using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartScene : MonoBehaviour
{
    public InputField MinimumField;
    public InputField MaximumField;

    public Button StartBtn;

    void Start()
    {
        StartBtn.onClick.AddListener(GotoMain);
    }

    private void GotoMain()
    {
        if (MaximumField.text != String.Empty && MinimumField.text != String.Empty)
        {
            GameManager.MinNum = Convert.ToInt32(MinimumField.text);
            GameManager.MaxNum = Convert.ToInt32(MaximumField.text);
        }
        else
        {
            GameManager.MinNum = 0;
            GameManager.MaxNum = 1000;
        }
        
        GameManager.LoadScene("MainScene");
    }
}
