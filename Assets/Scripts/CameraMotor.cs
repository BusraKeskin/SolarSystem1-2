using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMotor : MonoBehaviour
{
   /*
    public Transform target;
    public int speed;
    public static bool camIsPaused;

    void Update(){
        transform.RotateAround(target.transform.position, target.transform.up, speed * Time.deltaTime);
        

        if(Input.GetMouseButton(0))
        {
            camIsPaused = !camIsPaused;
            PauseCamMove(); 
            System.Threading.Thread.Sleep(3000);
            
        }
        
       
       

       
    }

     void PauseCamMove()
    {
        if(camIsPaused)
        {
            Time.timeScale = 0f;
             
        }
            Time.timeScale = 1f;
       
    }

    */

    [SerializeField]
    public GameObject panel;
    public bool test = false; // test variable

    public Transform target;
    public int speed;
 
  
    // Start is called before the first frame update
    void Start()
    {
        //start coroutine OrbitCamera
        StartCoroutine(OrbitCamera()); // start coroutine
    }

    // Update is called once per frame
    void Update() {

  
    }

    IEnumerator OrbitCamera()
    {
        while (true)
        {
            //mousemoveevent
            if (
                Input.GetAxis("Mouse X") != 0
                || Input.GetAxis("Mouse Y") != 0
                || Input.GetMouseButton(0) && panel.activeSelf
            )
            {
                //if panel.activeSelf is true wait until it is false
                while (panel.activeSelf)
                {
                    yield return null;
                }
                //Debug.Log("Mouse moved");
                yield return new WaitForSeconds(5f);
            }
            else
            {
                transform.RotateAround(target.transform.position, target.transform.up, speed * Time.deltaTime);
                yield return null;
            }
        }
    }
}
