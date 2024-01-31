using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddles : MonoBehaviour
{
    public float angle = 45f;
    public GameObject leftPivot;
    public GameObject rightPivot;



    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 paddleUp = new Vector3(0, 0, angle); // fixed rotation transformation for paddles
        if (Input.GetKey(KeyCode.Space))
        {
            Debug.Log("Paddles UP!");

            leftPivot.transform.eulerAngles = paddleUp * -1; //https://docs.unity3d.com/ScriptReference/Transform-eulerAngles.html
            rightPivot.transform.eulerAngles = paddleUp;
        }
        else {
            Debug.Log("Paddles DOWN!");

            leftPivot.transform.eulerAngles = Vector3.zero;
            rightPivot.transform.eulerAngles = Vector3.zero;
        }
    }
}
