using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandyDestroyer : MonoBehaviour
{
    public CandyHolder candyHolder;
    public int reward;
    public GameObject effectPrefab;
    public Vector3 effectRotation;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider collider){
        if(collider.gameObject.tag=="Candy"){
            candyHolder.AddCandy(reward);
            Destroy(collider.gameObject);
            if(effectPrefab!=null){
                Instantiate(
                    effectPrefab,
                    collider.transform.position,
                    Quaternion.Euler(effectRotation)
                );
            }
        }
    }
}
