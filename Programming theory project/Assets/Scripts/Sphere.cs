using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Sphere : Shape
{
    public ShapesColor SphereColor
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

    public string SphereName
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
        Debug.Log("Sphere Name: "+ SphereName + " Sphere Color: "+ SphereColor);
    }
}
