using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Logic : MonoBehaviour
{
    
    public GameObject cube;

    private bool rotate = true;
    private Color[] colorRgb = { Color.red, Color.green, Color.blue};
    private int colorIndex = 0;

    void Start()
    {
        
    }

    void Update()
    {
        if (rotate)
        {
            cube.transform.Rotate(Vector3.up, 30f * Time.deltaTime);
        }
    }

    //Rotate
    public void ToggleRotate()
    {
        rotate = !rotate;
    }

    //Color
    public void ToggleColor()
    {
        cube.GetComponent<Renderer>().material.color = colorRgb[colorIndex];
        colorIndex = colorIndex++ < colorRgb.Length-1 ? colorIndex : 0;
    }
}
