﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;





public class MainMenu : MonoBehaviour

{
    public String newGameScene;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()

    {

    }

        public void NewGame()
        {
        SceneManager.LoadScene(ADD Your Scene Name Here );
        }

    public void QuitGame() 
    {
 Application.Quit();
    }
}
