using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {
    public bool gameOver;
    public int score;
    public static GameController instance;

	// Use this for initialization
	void Start () {
        /*Inicializamos los atributos*/
        gameOver = false;
        score = 0;
        instance = this;

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
