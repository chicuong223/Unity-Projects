using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintCircleInformation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int radius = 0;
        double area;

        while (radius <= 5)
        {
            area = (float)Mathf.PI * radius * radius;
            print($"Radius: {radius}, Area: {area,5:N2}");
            radius++;
        }
    }

}
