using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    Animator myani;
    Rigidbody myrb;
    public Text scoretext;
    int Score = 0;
    public Text highscoretext;
    public Image[] life;
    int h = 3;
    public AudioClip coinClip;
    AudioSource collectiblesAudio;

    void Start()
    {
        myani = GetComponent<Animator>();
        myrb = GetComponent<Rigidbody>();
        scoretext.text = "Score:" + Score;
        highscoretext.text = "Highscore:" + PlayerPrefs.GetInt("Highscore", Score).ToString();

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.D) && (transform.position.x== 0 || transform.position.x==-2))
        {
            transform.position = new Vector3(transform.position.x + 2, 0.3047604f, 0);
        }
        if(Input.GetKeyDown(KeyCode.A) && (transform.position.x == 0 || transform.position.x == 2))
        {
            transform.position = new Vector3(transform.position.x - 2, 0.3047604f, 0);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            myani.SetTrigger("Roll");
        }
        if (Input.GetKeyDown(KeyCode.W)&& myrb.velocity.y==0)
        {
            myani.SetTrigger("Jump");
            myrb.velocity = new Vector3(0, 3f, 0);

        }
        if(Score>PlayerPrefs.GetInt("Highscore"))
        {
            PlayerPrefs.SetInt("Highscore", Score);
            highscoretext.text = "Highscore" + PlayerPrefs.GetInt("Highscore", Score).ToString();   
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Coin")
        {
            collectiblesAudio = GetComponent<AudioSource>();
            collectiblesAudio.clip = coinClip;
            collectiblesAudio.Play();
            scoretext.text = "Score:" + Score;
            Score++;
            Destroy(other.gameObject);
        }
        if(other.gameObject.tag == "Enemy")
        {
            h--;
            life[h] . enabled = false;
            if(h==0)
            {
                SceneManager.LoadScene("GameOver");
                Destroy(gameObject);
            }
        }
    }
}
