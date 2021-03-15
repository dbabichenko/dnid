using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterController : MonoBehaviour
{
    public GameObject target;
    public float speed = .001f;

    private Vector3 start;
    private Vector3 des;
    private float fraction = 0;
    public bool isActive = false;
    void Start()
    {
        // Debug.Log("Position of Monster: " + gameObject.transform.position);
        // Debug.Log("Position of Human: " + target.transform.position);
        start = gameObject.transform.position;
        des = target.transform.position;
        isActive = true;

    }

    // Update is called once per frame
    void Update()
    {
        

        if (fraction < 1)
        {
            start = gameObject.transform.position;
            des = target.transform.position;

            fraction += Time.deltaTime * speed;
            gameObject.transform.position = Vector3.Lerp(start, des, fraction);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        // Debug.Log(other.gameObject.name);
        if(other.gameObject.name == "Human")
        {
            target.GetComponent<AudioSource>().Play();
        }
    }
}
