using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PrintTrigonometry : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print("Degree = " + 60);
        float radian = 60 * (float)Math.PI / 180;
        print($"Sin({60}) = {Math.Sin(radian)}");
        print($"Cosin({60}) = {Math.Cos(radian)}");
    }

}
