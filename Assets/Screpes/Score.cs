using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] public Text scoreText;
    [SerializeField] private int scoress;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "score")
        {
            scoress++;
            Destroy(other.gameObject);
            scoreText.text = scoress.ToString();
        }
    }
}