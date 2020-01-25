using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hole : MonoBehaviour
{
    bool fallIn;
    public string activeTag;
public bool IsFallIn(){
    return fallIn;
}
void OnTriggerEnter(Collider collider){
    if(collider.gameObject.tag==activeTag){
        fallIn=true;
    }
}
void OnTriggerExit(Collider collider){
    if(collider.gameObject.tag==activeTag){
        fallIn =false;
    }
}
    void OnTriggerStay(Collider collider){
        Rigidbody rigidbody=collider.gameObject.GetComponent<Rigidbody>();
        Vector3 direction =transform.position-collider.gameObject.transform.position;
        direction.Normalize();
        if(collider.gameObject.tag==activeTag){
            rigidbody.velocity*=0.9f;
            rigidbody.AddForce(direction*rigidbody.mass*20.0f);
        }
        else{
            rigidbody.AddForce(-direction*rigidbody.mass*80.0f);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
