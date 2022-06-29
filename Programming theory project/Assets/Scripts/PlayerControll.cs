using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControll : MonoBehaviour
{
    public ShapesColor m_PlayerColor;
    public float m_Speed = 5.0f;
    private float m_BoundX = 3.0f;
    private Rigidbody m_Rigidbody;
    private MeshRenderer m_PlayerMesh;
    private float m_HorizontalInput;
    // Start is called before the first frame update
    void Start()
    {
        m_PlayerMesh = GetComponent<MeshRenderer>();
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
        if (other.gameObject.CompareTag("Changer"))
        {
            ColorChange changer = other.GetComponent<ColorChange>();
            m_PlayerColor = changer.m_ChangerColor;
            m_PlayerMesh.material = other.GetComponent<ColorChange>().m_Colors[(int) m_PlayerColor];
            Destroy(other.gameObject);
        }
        else
        {
            if (other.GetComponent<Shape>().m_Color == m_PlayerColor)
            {
                GameManager.s_Instance.UpdateScore(other.GetComponent<Shape>().m_ShapeValue);
                //Explosion
                Destroy(other.gameObject);
            }
            else
            {
                other.GetComponent<Shape>().DisplayInfo();
                //Explosion
                Destroy(gameObject);
                GameManager.s_Instance.m_IsGameOver = true;
                GameManager.s_Instance.m_IsRestart = true;
                GameManager.s_Instance.GameOver();
            }
            
        }
       
    }
}
