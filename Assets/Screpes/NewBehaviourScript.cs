using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public static float speedaster = 3f;
    public static float speeds = 1f;
    void Start()
    {
        StartCoroutine(SpeedIncrease());
        StartCoroutine(SpeedIncrease1());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private IEnumerator SpeedIncrease()
    {
        yield return new WaitForSeconds(1);
        if (speedaster < 10)
        {
            speedaster += 0.2f;
            StartCoroutine(SpeedIncrease());
        }
    }

    private IEnumerator SpeedIncrease1()
    {
        yield return new WaitForSeconds(1);
        if (speeds < 4)
        {
            speeds += 0.1f;
            StartCoroutine(SpeedIncrease1());
        }
    }
}
