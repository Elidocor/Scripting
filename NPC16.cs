using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int health = 4;
        int level = 1;
        health += level;
        print("Çהמנמגüו:" + health);           //aaaaaaaaa
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;
        int speed = 3;
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;
    }
}
