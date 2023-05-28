using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingStar : MonoBehaviour
{
    // Start is called before the first frame update
    private int speed = 75;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(transform.rotation.x * -1, -3,0) * speed * Time.deltaTime);
        if(transform.position.y < 100)
        {
            Destroy(gameObject);
        }
    }
}
