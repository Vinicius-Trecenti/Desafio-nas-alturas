using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aviao : MonoBehaviour
{
    private Rigidbody2D fisica;

    [SerializeField]
    private float forca = 10;
    


    private void Awake()
    {
        this.fisica = this.GetComponent<Rigidbody2D>();
    }
   
    // Update is called once per frame
    private void Update()

    {
        if(Input.GetButtonDown("Fire1"))
        {
            this.Impulsionar();
  
        }
        
    }

    private void Impulsionar()
    {
        this.fisica.velocity = Vector2.zero;
        this.fisica.AddForce(Vector2.up * this.forca, ForceMode2D.Impulse);
    }
}
