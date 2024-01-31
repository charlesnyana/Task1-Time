using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class Paddles : MonoBehaviour
{
    public float speed = 2f;
    public float amp = 2f;
    public float angle = 45f;
    public GameObject leftPivot;
    public GameObject rightPivot;
    float baseSpeed;



    // Start is called before the first frame update
    void Start()
    {
        baseSpeed = speed;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Debug.Log("Paddles UP!");
            
            if (angle >= speed)
            {
                leftPivot.transform.localRotation = Quaternion.Euler(0, 0, -speed);
                rightPivot.transform.localRotation = Quaternion.Euler(0, 0, speed);
                speed = speed * amp;
            }
        }
        else {
            leftPivot.transform.eulerAngles = Vector2.zero; //https://docs.unity3d.com/ScriptReference/Transform-eulerAngles.html
            rightPivot.transform.eulerAngles = Vector2.zero;
            speed = baseSpeed;
        }
    }
}
