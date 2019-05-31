using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myobject : MonoBehaviour
{
    public Transform red;
    public Transform green;
    public Transform blue;
    public Transform yellow;
    public Transform purple;
    public Transform orange;
    // Start is called before the first frame update
    void Start()
    {
       for (int i = -6; i < 7; i += 2)
        {
                Instantiate(red, new Vector3(i, 3.0f, 0), red.rotation);
                Instantiate(green, new Vector3(i, 1.5f, 0), green.rotation);
                Instantiate(blue, new Vector3(i, 0, 0), blue.rotation);
                Instantiate(yellow, new Vector3(i, -1.5f, 0), yellow.rotation);
                Instantiate(orange, new Vector3(i, -3.0f, 0), orange.rotation);
        }
       
    }

    // Update is called once per frame
    void Update()
    {

    }
}
