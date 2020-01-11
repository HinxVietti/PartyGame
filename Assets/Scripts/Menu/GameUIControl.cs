using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameUIControl : UIPanel
{
    [SerializeField] Button StartGame = null;
    [SerializeField] Button Setting = null;
    [SerializeField] Button Quit = null;


    protected override void Start()
    {
        RegisterEvent();
    }

    private void RegisterEvent()
    {
        StartGame.onClick.AddListener(StartGameClicked);
        Setting.onClick.AddListener(GlobalSettingClick);
        Quit.onClick.AddListener(QuitGameClick);
    }

    private void QuitGameClick()
    {
        Application.Quit();
    }

    private void GlobalSettingClick()
    {

    }

    private void StartGameClicked()
    {

    }
}
