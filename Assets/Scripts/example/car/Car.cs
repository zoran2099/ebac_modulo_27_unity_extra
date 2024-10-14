using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    public int speed = 0;
    public int gear = 0;

    public float TotalSpeed()
    {
        
        float result = gear * speed;
        Debug.Log("Resultado "+result);
        return result;
    }

}
