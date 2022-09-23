using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float lrspeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow)){
            this.transform.position += Vector3.right * lrspeed;   
        } 

        if (Input.GetKeyDown(KeyCode.LeftArrow)){
            this.transform.position += Vector3.left * lrspeed;   
        } 
    }
}