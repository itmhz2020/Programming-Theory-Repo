using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : Shape
{
    private Color m_SphereColor;
    public Color SphereColor
    {
        set
        {
            m_SphereColor = value;
        }
        get
        {
            return m_SphereColor;
        }
    }

    private string m_SphereName;
    public string SphereName
    {
        set
        {
            if (value.Length < 25)
            {
                m_SphereName = value;
            }
        }

        get
        {
            return m_SphereName;
        }
    }

    public override void DisplayInfo()
    {
        Debug.Log("Sphere Name: "+ SphereName + " Sphere Color: "+ SphereColor);
    }
}
