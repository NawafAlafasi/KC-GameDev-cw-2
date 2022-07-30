using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    string hero = "homelander";
    float heigt = 189.5f;
    int ageh = 27;
    string powerh = "superstrength";
    string villain = "soldierboy";
    float height = 191.2f;
    int agev = 41;
    bool powerv = false; 
    // Start is called before the first frame update
    void Start()
    {
        print("My hero's name is " + hero);
        float nheigt = heigt + 5;
        print("His height is " + nheigt);
        print("His age is " + ageh);
        print("His power is " + powerh);
        print("My hero's name is " + villain);
        print("His height is " + height);
        print("His age is " + agev);
        if (powerv = true)
            print("He has no power");
        else
            print("His power is superstrength");
        int agedifference = agev - ageh;
        print(agedifference);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
