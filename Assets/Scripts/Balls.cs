using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balls : MonoBehaviour
{
    public int size;
    public GameObject[] capsules;
    private int rand;
    private string str = "RGB";

    // Start is called before the first frame update
    void Start()
    {
        if(capsules == null){
            capsules = GameObject.FindGameObjectsWithTag("Capsule");
        }
        int y = 0;
        foreach(GameObject x in capsules){
            x.GetComponent<Tubes>().id = y;
            y++;
            Debug.Log(x.GetComponent<Tubes>().id);
        }

        /*
        rand = Random.Range(0, 3);
        Debug.Log(str[rand]);*/
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
