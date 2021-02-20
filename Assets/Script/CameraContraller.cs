using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class CameraContraller : MonoBehaviour
{
    
    private Transform playerTRG;
    public Tilemap tileMap;

    private Vector3 bottomLeft;
    private Vector3 topRight;
    private float halfHeight;
    private float halfWidth;
    


    void Start()
    {
        playerTRG = Player.instance.transform;

        halfHeight = Camera.main.orthographicSize;
        halfWidth = halfHeight * Camera.main.aspect;

        bottomLeft = tileMap.localBounds.min + new Vector3(halfWidth,halfHeight,0f);
        topRight = tileMap.localBounds.max + new Vector3(-halfWidth, -halfHeight, 0f);
        Player.instance.playerLimit(tileMap.localBounds.min, tileMap.localBounds.max);
         
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(playerTRG.position.x, playerTRG.position.y, transform.position.z);


        transform.position = new Vector3(Mathf.Clamp(transform.position.x,bottomLeft.x,topRight.x), Mathf.Clamp(transform.position.y,bottomLeft.y,topRight.y), transform.position.z);
        
    }
}
