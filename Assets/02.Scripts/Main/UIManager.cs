﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour 
{
    
    public void OnClickStartBtn()
    {
        Debug.Log("Click Button");
        SceneManager.LoadScene("Play", LoadSceneMode.Single);
    }
}
