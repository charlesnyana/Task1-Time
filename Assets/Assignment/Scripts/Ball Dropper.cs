using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallDropper : MonoBehaviour
{
<<<<<<< HEAD
    public float speed = 5f;
=======
    public float speed = 3;
>>>>>>> 906389b5000566e40c06c5c11ddde50e2c1cafed
    public GameObject pinball;
    public Transform spawn;

    // Start is called before the first frame update
    void Start()
    {
<<<<<<< HEAD
        Instantiate(pinball, spawn.position, spawn.rotation);
=======
        
>>>>>>> 906389b5000566e40c06c5c11ddde50e2c1cafed
    }

    // Update is called once per frame
    void Update()
    {
        float direction = Input.GetAxis("Horizontal");
        transform.Translate(1 * direction * Time.deltaTime, 0, 0);

<<<<<<< HEAD
        if (pinball.activeInHierarchy == false)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(pinball, spawn.position, spawn.rotation);
            }
        } else {
            Debug.Log("You may not drop a ball.");
=======
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(pinball, spawn.position, spawn.rotation);
>>>>>>> 906389b5000566e40c06c5c11ddde50e2c1cafed
        }
    }
}
