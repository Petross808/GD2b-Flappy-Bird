using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnerScript : MonoBehaviour
{
    public Transform pipe;
    private float _timer;

    // Start is called before the first frame update
    void Start()
    {
        _timer = 2;
    }

    // Update is called once per frame
    void Update()
    {
        if (_timer > 0)
        {
            _timer -= Time.deltaTime;
        }
        else
        {
            float offset = Random.Range(-3.5f, 3.5f);
            Instantiate(pipe, new Vector3(transform.position.x, offset, 1), new(0,0,0,0));
            _timer = 2;
        }
    }
}
