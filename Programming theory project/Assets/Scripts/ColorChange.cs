using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    public ShapesColor m_ChangerColor = ShapesColor.Blue;
    public Material[] m_Colors;
    private MeshRenderer m_MeshRender;
    

    // Start is called before the first frame update
    void Awake()
    {
        m_MeshRender = GetComponent<MeshRenderer>();
        //Change Color
        GetRandomColor();
    }

    void GetRandomColor()
    {
        int colorIndex = Random.Range(0,3);
        switch (colorIndex)
        {
            case 0:
                m_ChangerColor = ShapesColor.Blue;
                m_MeshRender.material = m_Colors[0];
                break;
            
            case 1:
                m_ChangerColor = ShapesColor.Green;
                m_MeshRender.material = m_Colors[1];
                break;

            case 2:
                m_ChangerColor = ShapesColor.Red;
                m_MeshRender.material = m_Colors[2];
                break;
        } 
    }
}
