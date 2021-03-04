using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class karakterharaket : MonoBehaviour
{
    public int hiz; 
    public int ziplamagucu;
    Rigidbody2D body2d;
    void Start()
    {
        body2d = GetComponent<Rigidbody2D>();
    }


    void FixedUpdate()
    {
        SaðSolHareket();
        Zýplama();
    }

    void SaðSolHareket() 
    {
        float h = Input.GetAxisRaw("Horizontal");
        body2d.velocity = new Vector2(h* hiz*Time.deltaTime, body2d.velocity.y);

    }

    void Zýplama()
    {

        if (Input.GetButtonDown("Jump"))
        {
            body2d.AddForce(Vector2.up*ziplamagucu*100);
        }       
        
    }
        



        
     
           
        

    
     
    
}