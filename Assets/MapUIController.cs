﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MapUIController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnUploadPressed()
    {
        SceneManager.LoadScene(2);
    }
    public void OnLogOut()
    {
        SceneManager.LoadScene(0);
    }
}