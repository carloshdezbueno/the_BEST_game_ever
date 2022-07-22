using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class merda : MonoBehaviour
{
    [Serializable]
    abstract class Animal
    {
        [SerializeField]
        protected string AnimalName;
        public abstract void MakeSound();
    }

    [Serializable]
    class Dog : Animal
    {
        public override void MakeSound()
        {
            Debug.Log("Bark");
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
