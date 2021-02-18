using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D _rg;
    float speed = 3f;
    private Animator _playerAnimator;
    public static Player instance;
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
    }

    // Update is called once per frame
    void Update()
    {

        float Hmove = Input.GetAxisRaw("Horizontal");
        float Vmove = Input.GetAxisRaw("Vertical");

        _playerAnimator.SetFloat("moveX", Hmove);
        _playerAnimator.SetFloat("moveY", Vmove);


        _rg.velocity = new Vector2(Hmove *speed, Vmove * speed);

        if(Hmove == 1 || Hmove == -1 || Vmove == 1 || Vmove == -1)
        {
            _playerAnimator.SetFloat("lastMoveX",Hmove);
            _playerAnimator.SetFloat("lastMoveY", Vmove);
        }
    }
}
