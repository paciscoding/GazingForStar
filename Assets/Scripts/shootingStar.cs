using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootingStar : MonoBehaviour
{
    public GameObject shootingstarPrefab;
    public float time = 0.0f;
    public float repeatRate = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawn", time, repeatRate * Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (Input.GetKey("w")) {
            InvokeRepeating("spawn", time * Time.deltaTime, repeatRate * Time.deltaTime);
        }*/

    }
    
    private void spawn()
    {
        Instantiate(shootingstarPrefab, new Vector3(Random.Range(-1500,0), Random.Range(50,600), Random.Range(-2000, 2000)), shootingstarPrefab.transform.rotation);
    }
}
