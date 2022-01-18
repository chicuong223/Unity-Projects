using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : MonoBehaviour
{
    [SerializeField] // allows change value in inspector window
    int radius;
    float area;
    // Start is called before the first frame update
    void Start()
    {
        area = radius * radius * Mathf.PI;
        Vector3 scale = transform.localScale;
        scale.x *= radius;
        scale.y *= radius;
        transform.localScale = scale;
        print($"Radius: {radius}, Area: {area}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
