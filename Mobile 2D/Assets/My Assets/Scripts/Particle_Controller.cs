﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Particle_Controller : MonoBehaviour {

    private Transform canvas;
    public GameObject extraLifeCanvas;

    private ParticleSystem ps;

	// Use this for initialization
	void Start () {
        //Sets ps as the particle system attached to this script
        ps = GetComponent<ParticleSystem>();


        //Searchs for the Canvas and links it to this script
        canvas = transform.Find("/Canvas");
	}
	
	// Update is called once per frame
	void Update () {
        //Declares psAlive as the state of ps (wether is alive or nor)
        bool psAlive = ps.IsAlive();

        //Checks if the particles are not alive
        if (!psAlive) {

            //Load GameOver Scene
            SceneManager.LoadScene("GameOverScreen");
        }
	}
}
