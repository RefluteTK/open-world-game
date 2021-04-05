
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public string MainMenuScene;
     public GameObject pauseMenu;
    public bool isPaused;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()

    {
//var escapeKey = KeyCode.Escape;
            //    #if UNITY_EDITOR
              //  escapeKey = KeyCode.Tilde;
             //   #endif
             //   if (Input.GetKeyDown(escapeKey))
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(isPaused)
            {
                ResumGame();
            } else
            {
                isPaused = true;
                pauseMenu.SetActive(true);
                Time.timeScale = 0;
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.Confined;

                
            }
        }
    }
    public void ResumGame()
    {
        isPaused = false;
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    
    public void RestartGame()
{
     SceneManager.LoadScene("newGameScene");
}

    
  public void ReturnToMain()
  {
      SceneManager.LoadScene(MainMenuScene);
  }
        }
    

