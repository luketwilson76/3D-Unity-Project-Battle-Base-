using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Teleport : MonoBehaviour
{
    public Transform object1;
    public Transform object2;


    private void Update()
    {
        if (Input.GetKeyDown("q")){
            Vector3 tempPosition = new Vector3(object1.position.x,object1.position.y, object1.position.z);
            object1.position = object2.position;
            object2.position = tempPosition;
            

        } 
    }
}
