using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MagicNumbers : MonoBehaviour
{
    private int _guess;
    private int _turnsNum;
    private int _min;
    private int _max;

    [SerializeField] private Text logger;
    [SerializeField] private Text turnsLabel;
    [SerializeField] private Button moreBtn;
    [SerializeField] private Button lessBtn;
    [SerializeField] private Button correctBtn;
    
    // Start is called before the first frame update
    void Start()
    {
        Init();
        CalculateGuess();
    }

    private void Init()
    {
        _min = GameManager.MinNum;
        _max = GameManager.MaxNum;
        _turnsNum = 0;
        lessBtn.onClick.AddListener(LessNumber);
        moreBtn.onClick.AddListener(MoreNumber);
        correctBtn.onClick.AddListener(CorrectNumber);
    }

    private void LessNumber()
    {
        _max = _guess;
        CalculateGuess();
    }
    
    private void MoreNumber()
    {
        _min = _guess;
        CalculateGuess();
    }
    
    private void CorrectNumber()
    {
        GameManager.LoadScene("FinishScene");
    }

    private void CalculateGuess()
    {
        _turnsNum++;
        _guess = (_min + _max) / 2;
        logger.text = $"Is your number {_guess}?";
        turnsLabel.text = $"Turns total is {_turnsNum}";
    }
}
