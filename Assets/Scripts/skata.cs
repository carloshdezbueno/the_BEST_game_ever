using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skata : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private int number1;
    [SerializeField]
    private int number2;
    void Start()
    {
        number1 = 8;
        // summary(number1, number2);
        increaseNum(ref number1);
        Debug.Log(number1);
    }

    private int summary(int num1, int num2)
    {
        return num1 + num2;
     }

    private void increaseNum(ref int number)
    {
        number += 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
