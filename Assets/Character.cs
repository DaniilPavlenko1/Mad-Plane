using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;

public class Character : MonoBehaviour
{
    public AddStart interAd;
    public GameManager gameManager;
    public AudioSource tap;
    private Rigidbody2D rb;
    public float velocity = 2;
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        PlayerPrefs.GetInt("Loses", 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            tap.Play();
            rb.velocity = Vector2.up * (velocity + 1);
            anim.SetBool("Tap", true);
        }
        else
        {
            anim.SetBool("Tap", false);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameManager.GameOver();
        GetComponent<AudioSource>().Play();
        PlayerPrefs.SetInt("Loses", PlayerPrefs.GetInt("Loses") + 1);
    }
    public void ShowAdd()
    {
        if (PlayerPrefs.GetInt("Loses") % 5 == 0)
        {
            interAd.ShowAd();
        }
    }
}
