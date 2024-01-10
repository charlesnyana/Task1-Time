using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class Turret : MonoBehaviour
{
    public float speed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float aim = Input.GetAxis("Vertical") * speed;
        transform.Rotate(0, 0, aim * Time.deltaTime);
    }
}
