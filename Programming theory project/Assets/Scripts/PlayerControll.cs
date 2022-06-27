using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControll : MonoBehaviour
{
    public float m_Speed = 5.0f;
    private float m_BoundX = 3.0f;
    private Rigidbody m_Rigidbody;
    private float m_HorizontalInput;
    // Start is called before the first frame update
    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        m_HorizontalInput = Input.GetAxis("Horizontal");

        //Make bound for player
        if (transform.position.x > m_BoundX)
        {
            transform.position = new Vector3(m_BoundX, transform.position.y, transform.position.z);
        }

        if (transform.position.x < -m_BoundX)
        {
            transform.position = new Vector3(-m_BoundX, transform.position.y, transform.position.z);
        }

        //Player Move
        //m_Rigidbody.AddForce(Vector3.right * m_HorizontalInput * m_Speed );

        transform.Translate(Vector3.right * m_HorizontalInput * m_Speed * Time.deltaTime);


    }

    /// <summary>
    /// OnTriggerEnter is called when the Collider other enters the trigger.
    /// </summary>
    /// <param name="other">The other Collider involved in this collision.</param>
    void OnTriggerEnter(Collider other)
    {
        other.GetComponent<Shape>().DisplayInfo();
    }
}
