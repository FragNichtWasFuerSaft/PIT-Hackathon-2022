using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isColliding : MonoBehaviour
{    // Start is called before the first frame update
    public SpriteRenderer sr;
    public Sprite sp;

    void Start()
    {
        spawn(1, 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void spawn(float x, float y, float z){
        this.transform.position = new Vector3(x, y, z);
    }

    void OnTriggerEnter2D(Collider2D col) {
        if(col.name == "BrummBrumm") {
            Debug.Log("SHEESH");
            //Auto muss jetzt verlangsamt werden! (und Log muss weg xD)
        }
        sr.sprite = sp;
    }
}
