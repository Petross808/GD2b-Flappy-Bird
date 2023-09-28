using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParalaxBg : MonoBehaviour
{
    public float _speed;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position += Vector3.left * _speed;
        if (transform.position.x < -12)
        {
            transform.position += Vector3.right * 12;
        }
    }
}
