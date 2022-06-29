using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Shape
{
    //ENCAPSULATION
    public ShapesColor CubeColor
    {
        set
        {
            m_Color = value;
        }
        get
        {
            return m_Color;
        }
    }

    public string CubeName
    {
        set
        {
            if (value.Length < 25)
            {
                m_ShapeName = value;
            }
        }

        get
        {
            return m_ShapeName;
        }
    }

    public override void DisplayInfo()
    {
        Debug.Log("Cube Name: " + CubeName + " Cube Color: " + CubeColor);
    }
}
