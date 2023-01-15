using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveobj : MonoBehaviour
{
    public float speed = 1f;

    private void Start()
    {
        

    }
    void FixedUpdate()
    {
        transform.Translate(Vector3.down * NewBehaviourScript.speedaster * Time.deltaTime);

        if(transform.position.y < -9)
            Destroy(gameObject);
    }
    
}
