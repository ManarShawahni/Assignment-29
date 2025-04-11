using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment29
{
    public class UnitySpecificScript : MonoBehaviour
    {
        GameObject target;

        void OnEnable()
        {
            print("GameObject Enabled");
        }

        void OnDisable()
        {
            print("GameObject Disabled");
        }

        void Start()
        {
            print("Game started!");

            target = GameObject.Find("TargetObject");
            if (target != null)
                print("Found object by name: " + target.name);
            else
                print("No TargetObject found.");

            GameObject joker = GameObject.FindGameObjectWithTag("Joker");
            if (joker != null)
                print("Found object by tag: " + joker.name);
            else
                print("No Joker object found.");

            Light sceneLight = GameObject.FindObjectOfType<Light>();
            if (sceneLight != null)
                print("Found object of type Light: " + sceneLight.name);
            else
                print("No Light object found.");
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.D) && target != null)
            {
                target.SetActive(false);
                print("TargetObject deactivated!");
            }
        }
    }
}
