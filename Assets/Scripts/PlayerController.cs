using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float moveSpeed = 0.5f;
    private void Update()
    {
        float xValue = Input.GetAxis("Horizontal")* moveSpeed*Time.deltaTime;
        float yValue = Input.GetAxis("Vertical")*moveSpeed*Time.deltaTime;
        transform.Translate(xValue, yValue, 0);
    }
}
