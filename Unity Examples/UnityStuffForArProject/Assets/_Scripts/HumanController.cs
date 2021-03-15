using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(PlayerPrefs.GetFloat("MonsterX"));
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Vector3 pos = gameObject.transform.position;
            pos.x--;
            gameObject.transform.position = pos;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Vector3 pos = gameObject.transform.position;
            pos.x++;
            gameObject.transform.position = pos;
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Vector3 pos = gameObject.transform.position;
            pos.z++;
            gameObject.transform.position = pos;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Vector3 pos = gameObject.transform.position;
            pos.z--;
            gameObject.transform.position = pos;
        }

    }
}
