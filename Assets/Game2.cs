using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game2 : MonoBehaviour
{

    Vector3[] loca = {
    new Vector3(5.774f, 0.965f, -2.012f),
    new Vector3(5.68f, 1.5f, -1.803f),
   new Vector3(5.67f, 1.205f, -1.885f),
   new Vector3(5.75f, 1.438f, -2.82f),
   new Vector3(5.75f, 1.153f, -2.733f),
   new Vector3(5.75f, 0.967f, -2.589f)};
    public GameObject enemy;
    public GameObject blinker;

    public Vector3 spawnLocation = new Vector3(0, 0, 0);
    public int score;
    public Text scoreText;

    private CountdownTimer ct;

    void Start()
    {
        ct = GameObject.FindObjectsOfType<CountdownTimer> ()[0];
 
    }

    // Update is called once per frame


    void Update()
    {
        
    }

    public void startGame() {
        // setColors();
        GameObject timer = GameObject.FindGameObjectWithTag("Game2Object");

        spawnLocation = new Vector3(6.54f, 1.2f, -0.394f);
        Instantiate(enemy, spawnLocation, Quaternion.identity);
        transform.position = enemy.transform.position;

        generateBlinker();
        
// new Vector3(6.5042f, 1.1f, -0.5f)


        timer.GetComponent<CountdownTimer>().enabled = true;

        // spawnLocation = new Vector3(0,0,0);
        // Instantiate(enemy, spawnLocation, Quaternion.identity);
        // transform.position = enemy.transform.position;        

    }
    public void generateBlinker(){
        for(int i=0; i<6; i++){
        spawnLocation = new Vector3(6.54f, 1.2f, -0.394f);
        Instantiate(blinker,loca[i], Quaternion.identity);
    }
    }
    public void destroyObject() {
            Destroy(enemy);
        }
}
// -1.0258, 0.1355, -2.378
// 5.53, 1.498, -2.378
// +4.5042, +1.3625, 