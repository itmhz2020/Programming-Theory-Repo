using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shape : MonoBehaviour
{
    private Color m_ShapeColor;
    public Color ShapeColor
    {
        set
        {
            m_ShapeColor = value;
        }
        get
        {
            return m_ShapeColor;
        }
    }

    private string m_ShapeName;
    public string ShapeName
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

    public virtual void DisplayInfo() 
    {
        Debug.Log("Shape Name: "+ ShapeName +" Shape Color: "+ ShapeColor);
    }

    public virtual void DisplayInfo(Color _Color)
    {
        Debug.Log("Shape Color: "+ _Color);
    }
}
