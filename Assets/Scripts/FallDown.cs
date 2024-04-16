using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollDown : MonoBehaviour{
    [SerializeField] // что бы менять значение в unity 
    private float fallSpeed = 3f;
    
    void Update(){
        if(transform.position.y < -6f){
            Destroy(gameObject); 
        } 
         transform.position -= new Vector3(0, fallSpeed * Time.deltaTime, 0); // x, y, z 
    }
}
