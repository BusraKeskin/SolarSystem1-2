using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolarSystemManagement : MonoBehaviour
{
    //readonly float G = 100f; //Gravitational constant
    //public float rotationSpeed;
    //public float orbitSpeed;
    //public float orbitRadius;
    //public float orbitDistance;
    //public float orbitDirection;
    //public float dampAmt;
    public Transform target;
    public int speed;


    //GameObject[] celestials; //This array holds all the planets 
   

    // Start is called before the first frame update
    void Start()
    {
        //celestials = GameObject.FindGameObjectsWithTag("Celestial");
        //InitialVelocity();
    }
    void Update()
    {
        transform.RotateAround(target.transform.position, target.transform.up, speed * Time.deltaTime);
    }
    /*
    private void FixedUpdate(){
        Gravity();    
    }   
    //Newton's law of universal gravitation

    void Gravity() //Calculates interplanetary gravity
    {
        foreach(GameObject a in celestials)
        {
            foreach(GameObject b in celestials)
            {
                if(!a.Equals(b))
                {
                    float m1 = a.GetComponent<Rigidbody>().mass;
                    float m2 = b.GetComponent<Rigidbody>().mass;
                    float r  = Vector3.Distance(a.transform.position, b.transform.position);
                    
                    a.GetComponent<Rigidbody>().AddForce((b.transform.position - a.transform.position).normalized * ( G * (m1 * m2) / (r * r)));
                }
            }
        }
    }

    void InitialVelocity() //Applies planetary motions
    {
        foreach(GameObject a in celestials)
        {
            foreach(GameObject b in celestials)
            {
                if(!a.Equals(b))
                {
                    float m2 = b.GetComponent<Rigidbody>().mass;
                    float r = Vector3.Distance(a.transform.position, b.transform.position);
                    a.transform.LookAt(b.transform);
                    a.GetComponent<Rigidbody>().velocity += a.transform.right * Mathf.Sqrt((G * m2) / r); //Circular Orbital speed
                    
                    
                }
            }
        }
    }
    */
}


