using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static int MinNum = 0;
    public static int MaxNum = 1000;

    public static void LoadScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }
}
