﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToHomeScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // trigger next scene
    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene(0);
    }
}
