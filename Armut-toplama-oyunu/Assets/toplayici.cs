using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toplayici : MonoBehaviour
{
    // Start is called before the first frame update

    public float hiz;
    int skor = 0;
    private void OnCollisionEnter(Collision collision)
    {
      if (collision.gameObject.tag == "armut")
      {
            skor += 10;
            Debug.Log(skor.ToString());

            collision.gameObject.transform.position = new Vector3(7, 2, -7);
      }
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {      
        if (Input.GetKey(KeyCode.RightArrow))

        {
            transform.Translate(hiz * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.LeftArrow))

        {
            transform.Translate(-hiz * Time.deltaTime, 0, 0);
        }   
    }
}
