using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintTemperature : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int originalFarenheit;
        int celcius;
        int farenheit;

        originalFarenheit = 0;
        celcius = (5 / 9) * (originalFarenheit - 32);
        farenheit = (9 / 5) * celcius + 32;
        print($"Original Farenheit: {originalFarenheit}");
        print($"Celcius: {celcius}");
        print($"Farenheit: {farenheit}");

        originalFarenheit = 32;
        celcius = (5 / 9) * (originalFarenheit - 32);
        farenheit = (9 / 5) * celcius + 32;
        print($"Original Farenheit: {originalFarenheit}");
        print($"Celcius: {celcius}");
        print($"Farenheit: {farenheit}");

        originalFarenheit = 212;
        celcius = (5 / 9) * (originalFarenheit - 32);
        farenheit = (9 / 5) * celcius + 32;
        print($"Original Farenheit: {originalFarenheit}");
        print($"Celcius: {celcius}");
        print($"Farenheit: {farenheit}");
    }
}
