using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeLogic : MonoBehaviour
{
    private float _speed;

    // Start is called before the first frame update
    void Start()
    {
        _speed = 0.1f;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position += Vector3.left * _speed;
        if (transform.position.x < -14)
        {
            Destroy(gameObject);
        }

    }
}
