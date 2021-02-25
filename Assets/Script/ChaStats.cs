using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaStats : MonoBehaviour
{
    [SerializeField]
    private string _charName;
    [SerializeField]
    private int _playLevel;
    [SerializeField]
    private int _currejtExp;

    private int _maxHealth = 100;
    public int CurrentHP;

    private int _maxMagicPoint;
    public int _currentHP;

    private int _strength;
    private int _defence;

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
        
    }
}
