using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject human;
    public GameObject monster;
    // Start is called before the first frame update
    void Start()
    {
        // human = GameObject.Find("Human");
        // monster = GameObject.Find("Monster");
        PlayerPrefs.SetFloat("HumanX", human.transform.position.x);
        PlayerPrefs.SetFloat("MonsterX", monster.transform.position.x);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
