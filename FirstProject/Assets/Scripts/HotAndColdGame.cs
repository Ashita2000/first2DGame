using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HotAndColdGame : MonoBehaviour
{
    // Start is called before the first frame update
    public int randomeNumber;
    public int numberOfAttempts;
    void Start()
    {
        
        randomeNumber = UnityEngine.Random.Range(0, 100); 
        print(randomeNumber);
        string[] myString=new string[] {"abc","def"};
        print(myString[0]);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space")) {
            numberOfAttempts+=1;
            if(randomeNumber==numberOfAttempts) {
                print("YAYYAYAYYA");
            }

        }
    }
}
