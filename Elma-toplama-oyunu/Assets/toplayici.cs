using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toplayici : MonoBehaviour
{
    public float hiz;
    int skor = 0;


    private void OnCollisionEnter2D(Collision2D lision)
    {
        if (lision.gameObject.tag == "meyve")
        {
            skor += 5;
            Debug.Log(skor.ToString());

            //float rast = Random.Range(6.66f, -6.66f);


            lision.gameObject.transform.position = new Vector3(40, 37, 0);
        }
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