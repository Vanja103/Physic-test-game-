using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class PhysicGameScript : MonoBehaviour
{

    static int good = 0;
    static int bad = 0;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    void OnMouseDown(){
       good = good + 1;
       print("catchet" + good);
       
       Destroy(gameObject);

    }

    void OnCollisionEnter(Collision col){
        if(col.gameObject.tag == "Dirt"){
            bad = bad + 1;
            print("destroyed" + bad);
            Destroy(gameObject);
        }

        if(col.gameObject.tag == "greenCubes"){
            rb.AddForce(200f,0,0);
        }
    }
}
