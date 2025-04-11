using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Assignment29
{
    public class BasicsScript : MonoBehaviour
    {
        void Start()
        {
            var number = 7;
            var message = "Testing";
            var isReady = true;

            string result = (number % 2 == 0) ? "even" : "odd";
            Debug.Log($"The number {number} is {result}.");

            Debug.Log("Date: " + DateTime.Now.ToShortDateString());
            Debug.Log("Time: " + DateTime.Now.ToLongTimeString());
            Debug.Log("Day: " + DateTime.Now.DayOfWeek);
        }
    }
}
