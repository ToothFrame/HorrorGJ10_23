using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float speed = 1.0f;
    void FixedUpdate()
    {

            gameObject.transform.position = new Vector3 (gameObject.transform.position.x + speed, 3, gameObject.transform.position.z + speed);
        
    }
}
