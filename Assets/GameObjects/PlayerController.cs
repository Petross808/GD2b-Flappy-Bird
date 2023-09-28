using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    private Transform _canvas;
    private Rigidbody2D _rb;
    private int _score;
    private Animator _anim;

    // Start is called before the first frame update
    void Start()
    {
        _canvas = GameObject.FindGameObjectWithTag("Canvas").transform;
        _rb = GetComponent<Rigidbody2D>();
        _anim = GetComponent<Animator>();
        PlayerInput input = GetComponent<PlayerInput>();
        input.actions["Jump"].started += Jump;
        _score = 0;
    }

    void Jump(InputAction.CallbackContext context)
    {
        _rb.velocityY = 5;
        _anim.ResetTrigger("Flap");
        _anim.SetTrigger("Flap");

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        foreach(Transform child in _canvas)
        {
            child.gameObject.SetActive(true);
        }
        _canvas.Find("GameOverText").GetComponent<Text>().text = "Score: " + _score;
        _score = 0;
        gameObject.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        _score++;
    }

    private void OnGUI()
    {
        GUI.color = Color.black;
        GUI.Label(new(10, 10, 200, 100), "Score: " + _score);

    }
}
