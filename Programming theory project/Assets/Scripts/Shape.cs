using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ShapesColor
{
    Blue,
    Red,
    Orange,
    Green,
    Yellow,
    Purple
}

public class Shape : MonoBehaviour
{
    public ShapesColor m_Color = ShapesColor.Blue;
    public string m_ShapeName;

    public virtual void DisplayInfo() 
    {
        Debug.Log("Shape Name: "+ m_Color +" Shape Color: "+ m_ShapeName);
    }

    public virtual void DisplayInfo(Color _Color)
    {
        Debug.Log("Shape Color: "+ _Color);
    }
}
