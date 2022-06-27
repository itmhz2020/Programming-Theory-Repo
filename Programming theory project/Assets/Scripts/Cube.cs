using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Shape
{
    private Color m_CubeColor;
    public Color CubeColor
    {
        set
        {
            m_CubeColor = value;
        }
        get
        {
            return m_CubeColor;
        }
    }

    private string m_CubeName;
    public string CubeName
    {
        set
        {
            if (value.Length < 25)
            {
                m_CubeName = value;
            }
        }

        get
        {
            return m_CubeName;
        }
    }

    public override void DisplayInfo()
    {
        Debug.Log("Cube Name: " + CubeName + " Cube Color: " + CubeColor);
    }
}
