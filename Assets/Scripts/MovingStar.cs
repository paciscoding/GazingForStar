using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingStar : MonoBehaviour
{
    // Start is called before the first frame update
    private int speed = 100;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(-5, -3,0) * speed * Time.deltaTime);
        if(transform.position.y < 100)
        {
            Destroy(gameObject);
        }
    }
}
