using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mierda : MonoBehaviour
{

    [SerializeField]
    private GameObject camera;
    [SerializeField]
    private double speed;

    private double baseSpeed;
    // Start is called before the first frame update
    void Start()
    {
        this.baseSpeed = 0.5;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
        {
            Vector3 pos = camera.transform.position;
            pos.z = pos.z +((float)this.baseSpeed * (float)this.speed);
            camera.transform.position = pos;
        }
        if (Input.GetKey("a"))
        {
            Vector3 pos = camera.transform.position;
            pos.x = pos.x - ((float)this.baseSpeed * (float)this.speed);
            camera.transform.position = pos;
        }
        if (Input.GetKey("s"))
        {
            Vector3 pos = camera.transform.position;
            pos.z = pos.z - ((float)this.baseSpeed * (float)this.speed);
            camera.transform.position = pos;
        }
        if (Input.GetKey("d"))
        {
            Vector3 pos = camera.transform.position;
            pos.x = pos.x + ((float)this.baseSpeed * (float)this.speed);
            camera.transform.position = pos;
        }
        if (Input.GetKey("q"))
        {
            Quaternion rotation = camera.transform.rotation;
            Vector3 vector = rotation.eulerAngles;
            vector.y -= 0.5f;
            rotation.eulerAngles = vector;
            camera.transform.rotation = rotation;
        }
        if (Input.GetKey("e"))
        {
            Quaternion rotation = camera.transform.rotation;
            Vector3 vector = rotation.eulerAngles;
            vector.y += 0.5f;
            rotation.eulerAngles = vector;
            camera.transform.rotation = rotation;
        }
    }
}
