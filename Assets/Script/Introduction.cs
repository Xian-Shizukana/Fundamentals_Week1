using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Introduction : MonoBehaviour
{
    public int STR;
    private int hp;
    public int Damage = 5;

    // Start is called before the first frame update
    void Start()
    {
        hp = 5 * STR;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            takeDamage();
            Debug.Log(hp);
        }

        if (hp <= 0)
        {
            Debug.Log("Skill Issue");
        }

    }

    void takeDamage()
    {
        hp -= Damage;
    }
}
