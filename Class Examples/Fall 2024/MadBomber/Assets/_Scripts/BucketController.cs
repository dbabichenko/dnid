using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BucketController : MonoBehaviour
{
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Vector2 newPos = new Vector2(
                gameObject.transform.position.x + speed,
                gameObject.transform.position.y
                );
            gameObject.transform.position = newPos;
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Vector2 newPos = new Vector2(
                gameObject.transform.position.x - speed,
                gameObject.transform.position.y
                );
            gameObject.transform.position = newPos;
        }
    }
}
