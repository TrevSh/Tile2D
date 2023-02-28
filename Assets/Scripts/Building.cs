using System;
using UnityEngine;

public class Building : MonoBehaviour 
{

    [SerializeField] int jobPay = 5;
    [SerializeField] float startingTime = 60f;
    float currentTime = 0f;
    bool hasWorked = false;

    void Start()
    {
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
            Debug.Log("You just worked... Go home. We will call when we need you, damn.");
        }
    }

    void Update()
    {
        if (hasWorked)
            //Debug.Log("Timer Started");
        currentTime -= Time.deltaTime;
        if(currentTime <= 0.0f)
        {
            //Debug.Log("Timer Done.");
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
        Debug.Log("You worked today! Fuck it, We'll pay you today too!");
        Wallet.instance.MakeMoney(jobPay);
        hasWorked = true;
    }


}
