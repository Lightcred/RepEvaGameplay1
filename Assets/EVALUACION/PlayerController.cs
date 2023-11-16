using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using FMODUnity;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    public Rigidbody2D rb2D;
    public StudioEventEmitter sonidito;

    private void FixedUpdate()
    {
        Vector2 input = new Vector2(Input.GetAxisRaw("Horizontal"), 0);
        rb2D.position += input * speed * Time.fixedDeltaTime;

    }
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            Physics2D.gravity *= -1;
            sonidito.Play();
        }
        
    }
    private void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.CompareTag("obstacle"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
