using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obsctacle : MonoBehaviour
{
    Rigidbody2D rb;


    //[SerializeField] permet de serializer un champ private, ce qui l’expose automatiquement dans l’inspecteur et on peu le modifier
    [SerializeField]
    private float moveSpeed;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

  

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -15f)
        {
            Destroy(gameObject);
        }
        
    }

    private void FixedUpdate()
    {
        rb.velocity = Vector2.left * moveSpeed;
    }
}
