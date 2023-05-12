using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balls : MonoBehaviour
{
    public int size;
    public GameObject[] capsuls;
    private int rand;
    private string str = "RGB";
    private int y = 0;
    private List<Tubes> capsules = new List<Tubes>();
    private bool repeat = false;

    // Start is called before the first frame update
    void Start()
    {
        capsuls = GameObject.FindGameObjectsWithTag("Capsule");

        foreach(GameObject x in capsuls){
            Tubes tb = x.GetComponent<Tubes>();
            if(tb.id == -1){
                tb.id = y;
            }
            Debug.Log(tb.id);
            capsules.Add(tb);
            y++;
        }

        for(int i = 0; i<capsules.Count; i++){
            foreach(System.Char col in str){
                do{
                    rand = Random.Range(0, capsules.Count);
                    Tubes temp = capsules[rand];
                    if(temp.content.Length>3){
                        repeat=true;
                        continue;
                    }
                    temp.content = System.String.Concat(col, temp.content);
                    repeat=false;
                }while(repeat);
            }
        }

        foreach (Tubes tube in capsules){
            Debug.Log(tube.content);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
