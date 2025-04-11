using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment29
{
    public class UtilityTester : MonoBehaviour
    {
        void Start()
        {
            int result = Utilities.Add(1, 2, 3, 4);
            Debug.Log("Sum: " + result);

            string word = "Hi ";
            Debug.Log(word.RepeatString(3));
        }
    }
}
