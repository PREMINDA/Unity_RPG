﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D _rg;
    float speed = 5f;
    private Animator _playerAnimator;
    public static Player instance;
    public CameraContraller cam;

    public string areaTransestionName;

    private Vector3 bottomLeft;
    private Vector3 topRight;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
    void Start()
    {

        _rg = GetComponent<Rigidbody2D>();
        _playerAnimator = GetComponent<Animator>();
        DontDestroyOnLoad(gameObject);
        cam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<CameraContraller>();
        
    }
    // Update is called once per frame
    void Update()
    {

        float Hmove = Input.GetAxisRaw("Horizontal");
        float Vmove = Input.GetAxisRaw("Vertical");

        _playerAnimator.SetFloat("moveX", Hmove);
        _playerAnimator.SetFloat("moveY", Vmove);


        _rg.velocity = new Vector2(Hmove *speed, Vmove * speed);
       

        if (Hmove == 1 || Hmove == -1 || Vmove == 1 || Vmove == -1)
        {
            _playerAnimator.SetFloat("lastMoveX",Hmove);
            _playerAnimator.SetFloat("lastMoveY", Vmove);
        }

        transform.position = new Vector3(Mathf.Clamp(transform.position.x, bottomLeft.x, topRight.x), Mathf.Clamp(transform.position.y, bottomLeft.y, topRight.y), transform.position.z);
    }

    public void playerLimit(Vector3 botLeft,Vector3 tpRight)
    {
        bottomLeft = botLeft + new Vector3(1f,1f,0);
        topRight = tpRight + new Vector3(-1f, -1f, 0);
    }
}
