using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombController : MonoBehaviour

{
    private bool explode = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.position.y <= -4f)
        {
            if (!explode)
            {
                gameObject.GetComponent<AudioSource>().Play();
                explode = true;
            }
        }

        if (gameObject.transform.position.y <= -20f)
        {
            if (explode)
            {
                Destroy(gameObject);
            }
        }

    }

    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            // Debug.Log("Collided with player");
            Destroy(gameObject);
        }
    }
}
