using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerControll : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 dir;

    public AudioClip[] audiosss;
    public AudioSource audioss;
    
    [SerializeField] private int speed;
    [SerializeField] public GameObject losePanel;
    [SerializeField] private Text scoreText;
    [SerializeField] private int scoress;
    [SerializeField] private int coins;
    [SerializeField] private Text coinsText;
    [SerializeField] private Score scoreScript;
    [SerializeField] private GameObject knpause;



    private int lineToMove = 1;
    private float lineDistance = 2.7f;

    void Start()
    {
        controller = GetComponent<CharacterController>();
        Time.timeScale = 1;
        coins = PlayerPrefs.GetInt("coins");
        coinsText.text = coins.ToString();
    }

    private void Update()
    {
        if (SwipeController.swipeRight)
        {
            if (lineToMove < 2)
                lineToMove++;
        }

        if (SwipeController.swipeLeft)
        {
            if (lineToMove > 0)
                lineToMove--;
        }

        

        Vector3 targetPosition = transform.position.z * transform.forward + transform.position.y * transform.up;
        if (lineToMove == 0)
            targetPosition += Vector3.left * lineDistance;
        else if (lineToMove == 2)
            targetPosition += Vector3.right * lineDistance;

        if (transform.position == targetPosition)
            return;
        Vector3 diff = targetPosition - transform.position;
        Vector3 moveDir = diff.normalized * 25 * Time.deltaTime;
        if (moveDir.sqrMagnitude < diff.sqrMagnitude)
            controller.Move(moveDir);
        else
            controller.Move(diff);

    }

    void FixedUpdate()
    {
        dir.x = speed;
        controller.Move(dir * Time.fixedDeltaTime);
        
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.tag == "aster")
        {
            losePanel.SetActive(true);   
            int lastRunScore = int.Parse(scoreText.text.ToString());
            PlayerPrefs.SetInt("lastRunScore", lastRunScore);
            knpause.SetActive(false);
            Time.timeScale = 0;
            audioss.clip = audiosss[0];
            audioss.time = 0.25f;
            audioss.Play();
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "score")
        {
            scoress++;
            Destroy(other.gameObject);
            scoreText.text = scoress.ToString();
        }
        if (other.gameObject.tag == "coin")
        {
            coins++;
            PlayerPrefs.SetInt("coins", coins);
            Destroy(other.gameObject);
            coinsText.text = coins.ToString();
            audioss.clip = audiosss[1];
            audioss.time = 0.1f;
            audioss.Play();
        }
    }
    
}
