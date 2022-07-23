using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolarSystemManagement : MonoBehaviour
{

    public Transform target;
    public float speed;
    private bool isTriggered = false;

    void Update()
    {
        TurnAround();
    }

    private void TurnAround()
    {
        transform.RotateAround(target.transform.position, target.transform.up, speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!isTriggered)
        {
            if (
                other.gameObject.tag == "YearCounter"
                && gameObject.tag == "Celestial" && target.tag == "Sun"
            )
            {
                Debug.Log(gameObject.name + " completed one year!");
                isTriggered = true;

            }
            
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "YearCounter" && gameObject.tag == "Celestial" && target.tag == "Sun")
        {
            isTriggered = false;
        }
    }
    
}


