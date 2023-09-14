using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public int health = 20;
    public int level = 2;
    public int speed = 3;

    // Start is called before the first frame update
    void Start()
    {
        health = health + level;
        print(health);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;
    }
}
