﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game1Gen : MonoBehaviour
{
    public GameObject enemy;
    public Vector3 spawnLocation = new Vector3(4.5f, 1, 2);
    public Vector3 endLocation = new Vector3(4.5f, 1, -1);
    public int score;
    public Text scoreText;

    private CountdownTimer ct;
    Color[] colors;
    
    // public float smoothTime = 100f;
    // private Vector3 velocity = Vector3.zero;
    // private float lerpTime = 5;
    // private float moveSpeed = 1f;



    void Start()
    {
        ct = GameObject.FindObjectsOfType<CountdownTimer> ()[0];

        
    }

    // Update is called once per frame
    void Update()
    {
            //    transform.position = Vector3.forward * Time.deltaTime;
            //    

    }



    public void OnColliderEnter(Collider collision)
    {
        //  Destroy(enemy);
    }

    public void destroyObject() {
        Destroy(enemy);
        ct.addPoint();
        Debug.Log(score);

    }
    public void destroyObjects(string tag) {
    GameObject[] gameObjects = GameObject.FindGameObjectsWithTag(tag);
    foreach(GameObject target in gameObjects) {
        GameObject.Destroy(target);
    }
    }

    public void startGame() {
        // setColors();
        GameObject timer = GameObject.FindGameObjectWithTag("FirstGame");
        timer.GetComponent<CountdownTimer>().enabled = true;
        for(int i=0; i<10; i++){
        spawnLocation = new Vector3(Random.Range(3.0f, 6.0f), Random.Range(0.5f, 1.5f), -1.5f);
        Instantiate(enemy, spawnLocation, Quaternion.identity);
        transform.position = enemy.transform.position;

    }

        

    }

    private void setColors(){
        colors= new Color[11];
        colors[0]=Color.red;
        colors[1]=Color.blue;
        colors[2]=Color.cyan;
        colors[3]=Color.grey;
        colors[4]=Color.green;
        colors[5]=Color.yellow;
        colors[6]=Color.magenta;
        colors[7]=Color.black;
        colors[8]=Color.magenta;
        colors[9]=Color.magenta;
    }
    public void setColor() {
        enemy.GetComponent<Renderer>().material.color = Color.red;
    }
}
