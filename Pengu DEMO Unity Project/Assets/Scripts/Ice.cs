using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ice : MonoBehaviour
{
    public float velocity = 1f;
    public float speed = 1f;

    public float life = 10f;

    void FixedUpdate()
    {

        transform.position += Vector3.left * Time.deltaTime * speed;
    }


    private void Update()
    {
        life -= 1f * Time.deltaTime;
        if (life <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
