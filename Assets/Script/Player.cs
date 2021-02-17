using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D _rg;
    float speed = 1f;
    private Animator _playerAnimator;
    void Start()
    {
        _rg = GetComponent<Rigidbody2D>();
        _playerAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        float Hmove = Input.GetAxisRaw("Horizontal");
        float Vmove = Input.GetAxisRaw("Vertical");

        _playerAnimator.SetFloat("moveX", Hmove);
        _playerAnimator.SetFloat("moveY", Vmove);


        _rg.velocity = new Vector2(Hmove *speed, Vmove * speed);
    }
}
