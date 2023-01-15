using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class speces : MonoBehaviour
{
    public float speed = 1f;
    public GameObject speace;

    void Update()
    {
        transform.Translate(Vector3.down * NewBehaviourScript.speeds * Time.deltaTime);

        if (transform.position.y < -17.5f)
        {
            Instantiate(speace, new Vector3(0.0165f, 28.5f, 10f), Quaternion.identity);

            Destroy(gameObject);
        }
  
    }
}
