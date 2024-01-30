using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallDropper : MonoBehaviour
{
    public float speed = 5f;
    public GameObject pinball;
    public Transform spawn;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(pinball, spawn.position, spawn.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        float direction = Input.GetAxis("Horizontal");
        transform.Translate(1 * direction * Time.deltaTime, 0, 0);
        
        if (Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(pinball, spawn.position, spawn.rotation);
            }
    }
}
