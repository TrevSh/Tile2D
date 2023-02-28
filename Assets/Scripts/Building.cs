using System;
using UnityEngine;
using TMPro;

public class Building : MonoBehaviour 
{
    public TMP_Text jobText;
    public TMP_Text timeText;
    [SerializeField] int jobPay = 5;
    [SerializeField] float startingTime = 60f;
    float currentTime = 0f;
    bool hasWorked = false;

    void Start()
    {
        if (!hasWorked)
        {
            jobText.text = "You should probably go to work...";
        }
        currentTime = startingTime;   
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player" && !hasWorked)
        {
            GoToWork();
        }       
        else if (hasWorked)
        {
            jobText.text = "Go home. We will call when we need you, damn.";
        }
    }

    void Update()
    {
        if(currentTime == 60f)
        {
            timeText.text = "Go to Work!";
        }
        else
        {
            timeText.text = currentTime.ToString("f0"); 
        }

        if (hasWorked)
            
            //Debug.Log("Timer Started");
        currentTime -= Time.deltaTime;
        if(currentTime <= 0.0f)
        {
            Debug.Log("Timer Done.");
            StopTimer();
        }
        
        
    }

    void StopTimer()
    {
        Debug.Log("Come on back to work!");
        currentTime = startingTime;
        hasWorked = false;
    }

    void GoToWork()
    {
        jobText.text= "You worked today! We'll pay you today too!";
        Wallet.instance.MakeMoney(jobPay);
        hasWorked = true;
    }


}
