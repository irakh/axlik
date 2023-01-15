using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spounaster : MonoBehaviour
{
    public GameObject[] aster;
    public GameObject[] scorebar;
    public GameObject[] coin;
    private float[] positions = { -2.7f, 0f, 2.7f };
    private float time = 3;
    private int flag = 0;

    void Start()
    {
        StartCoroutine(spawn());
    }
    IEnumerator spawn()
    {
        while (true)
        {
            Instantiate(aster[Random.Range(0, aster.Length)], new Vector3(positions[Random.Range(0, 3)], 9f, 0f), Quaternion.identity);
            Instantiate(aster[Random.Range(0, aster.Length)], new Vector3(positions[Random.Range(0, 3)], 9f, 0f), Quaternion.identity);
            Instantiate(scorebar[Random.Range(0, scorebar.Length)], new Vector3(positions[Random.Range(1, 1)], 9f, 0f), Quaternion.identity);
            if (flag == 0 || flag == 1)
            {
                flag++;
            }
            else
            {
                flag = 0;
                Instantiate(coin[Random.Range(0, coin.Length)], new Vector3(positions[Random.Range(0, 3)], 9.22f, 2f), Quaternion.identity);
            }

            yield return new WaitForSeconds(time);
            if (time > 1.2f)
            {
                time -= 0.1f;
            }
        }
    }
}
