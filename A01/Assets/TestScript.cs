using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    public Vector2 newPos;

    // Start is called before the first frame update
    void Start()
    {
        newPos = Vector2.zero;
    }

    // Update is called once per frame
    void Update()
    {
        while (true)
        {
            GetComponent<Transform>().position = newPos;
            newPos.x += 0.1f;
        }
    }
}


