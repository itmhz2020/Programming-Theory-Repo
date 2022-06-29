using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveZ : MonoBehaviour
{
    public float m_Speed = 10;

    // Update is called once per frame
    void Update()
    {
        if (!GameManager.s_Instance.m_IsGameOver)
        {
            transform.Translate(Vector3.back * m_Speed * Time.deltaTime);
        }
    }
}
