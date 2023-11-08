using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextureScroll : MonoBehaviour
{
    public float scrollSpeed;
    public bool scroll = true; //variable pour faire bouger le background

    Material backgroundMaterial;

    private void Awake()
    {
        //acces to our background
        backgroundMaterial = GetComponent<Renderer>().material;
    }

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        
        if (scroll)
        {
            Vector2 offset = new Vector2(scrollSpeed * Time.time, 0);
            backgroundMaterial.mainTextureOffset = offset;
        }
    }
}
