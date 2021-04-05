using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Loading1: MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        SceneManager.LoadSceneAsync(1);
    }
}