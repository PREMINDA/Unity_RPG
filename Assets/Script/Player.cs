using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D _rg;
    float speed = 1f;
    void Start()
    {
        _rg = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        float Hmove = Input.GetAxisRaw("Horizontal");
        float Vmove = Input.GetAxisRaw("Vertical");


        _rg.velocity = new Vector2(Hmove *speed, Vmove * speed);
    }
}
