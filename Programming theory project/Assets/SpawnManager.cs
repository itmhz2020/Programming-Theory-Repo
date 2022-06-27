using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] m_RawPrefabs;
    private float m_StartDelay = 0;
    private float m_RepateRate = 3;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRaw",m_StartDelay,m_RepateRate);
    }

    void SpawnRaw()
    {
        int rawIndex = Random.Range(0,m_RawPrefabs.Length);
         Instantiate(m_RawPrefabs[rawIndex], transform.position + new Vector3(0,0,35),transform.rotation);
    }

}
