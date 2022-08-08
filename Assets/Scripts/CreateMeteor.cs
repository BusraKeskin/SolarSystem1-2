using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateMeteor : MonoBehaviour
     
{
    [SerializeField]
    public float MeteorSpwnRange = 5f;
    public GameObject meteor;
    Vector3 Pos;

    [SerializeField]
    public int initialMeteorSpeed = 20;

    void Start()
    {
        //start coroutine OrbitCamera
        StartCoroutine(MeteorSpawn()); // start coroutine
    }

    IEnumerator MeteorSpawn()
    {
        while (true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Vector3 pos = new Vector3(
                    Random.Range(-MeteorSpwnRange, MeteorSpwnRange),
                    0,
                    Random.Range(-MeteorSpwnRange, MeteorSpwnRange)
                );
                GameObject meteorInstance = Instantiate(meteor, pos, Quaternion.identity);

                //after instantiate meteor apply force to meteor through x axis
                meteorInstance
                    .GetComponent<Rigidbody>()
                    .AddForce(meteorInstance.transform.forward * initialMeteorSpeed);

                //after instantiate meteor apply force to meteor through z axis
                meteorInstance
                    .GetComponent<Rigidbody>()
                    .AddForce(meteorInstance.transform.right * initialMeteorSpeed);

                Debug.Log(
                    "Meteor instantiated at "
                        + pos
                        + " with"
                        + initialMeteorSpeed.ToString()
                        + " force"
                );

            }
            yield return null;
        }
    }
}
