using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
using UnityEngine.UIElements;

public class FlappyDetect : MonoBehaviour
{
    public int life = 3;
    public int points = 0;
    public float Scale = 1;

    public TextMeshProUGUI Lives;
    public TextMeshProUGUI Coins;

    public AudioSource CoinSound;
    public AudioSource LifeLostSound;
    // Start is called before the first frame update
    void Start()
    {
        Lives.text = life.ToString();
        Coins.text = points.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);
        if (other.gameObject.tag == "Obstacle" && life > 0)
        {
            life--;
            Lives.text = life.ToString();
            LifeLostSound.Play();
            if (life == 0)
            {
                RestartGame();
            }
        }

        if(other.gameObject.tag == "Coin")
        {
            points++;
            Coins.text = points.ToString();
            Destroy(other.gameObject);
            CoinSound.Play();
        }

        if(other.gameObject.tag == "Power Up")
        {
            Destroy(other.gameObject);
            Scale = Scale + 0.1f;
            transform.localScale = new Vector3(transform.localScale.x*Scale, transform.localScale.y * Scale, transform.localScale.z * Scale);
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
