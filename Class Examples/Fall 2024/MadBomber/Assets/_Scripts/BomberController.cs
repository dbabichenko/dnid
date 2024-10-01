using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BomberController : MonoBehaviour
{
    public float speed;

    private int direction = 1;

    

    void Update()
    {
        if(gameObject.transform.position.x <= -9
            || gameObject.transform.position.x >= 9)
        {
            direction *= -1;
        }

        Vector2 newPos = new Vector2(
            gameObject.transform.position.x + speed * Time.deltaTime * direction,
            gameObject.transform.position.y
            );

        gameObject.transform.position = newPos;
    }
}
