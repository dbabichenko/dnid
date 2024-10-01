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
        // Debug.Log(Time.deltaTime);
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Vector2 newPos = new Vector2(
                gameObject.transform.position.x + speed * Time.deltaTime,
                gameObject.transform.position.y
                );
            gameObject.transform.position = newPos;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Vector2 newPos = new Vector2(
                gameObject.transform.position.x - speed * Time.deltaTime,
                gameObject.transform.position.y
                );
            gameObject.transform.position = newPos;
        }
    }
}
