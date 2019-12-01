using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour
{
    private float currentTime = 0f;
    private float startTime = 10f;
    public int score=-1;
    [SerializeField] Text countdownText;
    
    [SerializeField] Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = startTime;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        countdownText.text = currentTime.ToString("0");

        if(currentTime<=0) {
            currentTime=0;
            //reset game state

        }

        

    }

    public void addPoint() {
        score++;
        scoreText.text = score.ToString("0");
    }
}
