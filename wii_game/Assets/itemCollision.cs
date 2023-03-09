using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemCollision : MonoBehaviour
{
    public void OnCollisionEnter(Collision col)
     {        
         if(col.transform.tag == "Player")
         {
            transform.parent = col.transform;
            //transform.SetParent(col.transform, true);
         }
     }
     void FixedUpdate()
     {
        Debug.Log(transform.position);
     }
}
