using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadScreen : MonoBehaviour

{
    public int levelone;
    public GameObject loadingScreen;
    public Slider loadingbar;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.L))
        {
              loadingScreen.SetActive(true);
               //SceneManager.LoadScene(levelone);
               StartCoroutine(LoadLevelAsync());
               
        }
        
    }

    private IEnumerator LoadLevelAsync()
    {
        

    AsyncOperation asyncload = SceneManager.LoadSceneAsync(levelone);
   
    while(!asyncload.isDone)
    {
//loadingbar.value = asyncload.progress;

       yield return null;

    }

    }

}
