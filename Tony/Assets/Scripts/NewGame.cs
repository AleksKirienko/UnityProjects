﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewGame : MonoBehaviour {
    
    public void Next() {
        SceneManager.LoadScene("Level1");
        //Application.LoadLevel ("Level1");
    }
}
