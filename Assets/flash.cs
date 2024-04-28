using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flash : MonoBehaviour

{ 
 public Material hit;
private SpriteRenderer thisSprite;
private Material chacheSprite;

void Start()
{
    thisSprite = GetComponent<SpriteRenderer>();
    chacheSprite = thisSprite.material;
}

void Update()
{
    if (Input.GetKeyDown(KeyCode.Space))
    {
        thisSprite.material = hit;
    }
    if (Input.GetKeyUp(KeyCode.Space))
    {
        thisSprite.material = chacheSprite;
    }
}
}
