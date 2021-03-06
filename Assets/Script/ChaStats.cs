﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaStats : MonoBehaviour
{
    [SerializeField]
    private string _charName;
    [SerializeField]
    private int _playLevel = 1;
    [SerializeField]
    private int _currentExp=0;
    private int _nextLevelExp = 100;

    private int _maxHealth = 100;
    public int CurrentHP;

    private int _maxMagicPoint = 50;
    public int _currentHP;

    [SerializeField]
    private int _strength = 15;
    [SerializeField]
    private int _defence = 12;

    public int WpPower;
    public int ArPower;

    public string EquipWp;
    public string EquipAr;

    [SerializeField]
    private Sprite CharImage;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            _currentExp += 50;
            LevelUp();
        }
        
    }



    public void LevelUp()
    {
        if (_currentExp >= _nextLevelExp)
        {
            _currentExp = 0;
            _playLevel++;
            _nextLevelExp += 50;
            _maxHealth += 2;
            ArWpPowerup();


        }
    }

    public void ArWpPowerup()
    {
        if(_playLevel%2 == 0)
        {
            _strength += 5;
        }
        else
        {
            _defence += 5;
        }
    }
}
