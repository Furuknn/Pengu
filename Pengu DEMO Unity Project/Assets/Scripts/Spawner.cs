using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float maxTime = 1;
    public float timer = 0;
    public float maxTime2 = 1;
    public float timer2 = 0;
    public GameObject Ice;
    public GameObject Ice2;
    public float space;
    public float space1;
    public float space2;
    public float space3;

    void Start()
    {
        GameObject ice = Instantiate(Ice);
        ice.transform.position = transform.position + new Vector3(6, Random.Range(space,space1), 0);
        GameObject ice2 = Instantiate(Ice2);
        ice2.transform.position = transform.position + new Vector3(0, Random.Range(space2, space3), 0);
    }

    void Update()
    {
        if(timer2 > maxTime2)
        {
            GameObject ice = Instantiate(Ice);
            ice.transform.position = transform.position + new Vector3(6, Random.Range(space, space1), 0);
            timer2 = 0;
            
        }
        if (timer > maxTime)
        {
            GameObject ice2 = Instantiate(Ice2);
            ice2.transform.position = transform.position + new Vector3(0, Random.Range(space2, space3), 0);
            timer = 0;
        }

        timer += Time.deltaTime;
        timer2 += Time.deltaTime;
    }
}
