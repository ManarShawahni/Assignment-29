using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment29
{
    public class ObjectTester : MonoBehaviour
    {
        void Start()
        {
            var obj1 = new CustomObject(1, "Mana");
            print(obj1);

            var obj2 = new CustomObject(1, "Mana");
            print("Equal: " + (obj1 == obj2));
            print("Not Equal: " + (obj1 != obj2));
        }
    }
}
