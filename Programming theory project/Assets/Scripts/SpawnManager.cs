using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject m_RawCubesPrefabs;
    public GameObject m_RawSpheresPrefabs;
    public GameObject m_ChangerPrefab;
    public float m_StartDelay = 3.0f;
    // Start is called before the first frame update
    void Start()
    {
        //InvokeRepeating("SpawnRaw",m_StartDelay,m_RepateRate);
        StartCoroutine(SpawnRaw());
    }

    IEnumerator SpawnRaw()
    {
        while (!GameManager.s_Instance.m_IsGameOver)
        {
            //Spawn Changer
            Instantiate(m_ChangerPrefab, transform.position + new Vector3(0, 3, 25), transform.rotation);
            //Spawn Spheres
            Instantiate(m_RawSpheresPrefabs, transform.position + new Vector3(0, 0, 100), transform.rotation);
            //Spawn Cubes
            Instantiate(m_RawCubesPrefabs, transform.position + new Vector3(0, 0, 175), transform.rotation);

            yield return new WaitForSeconds(m_StartDelay);
        }




    }

}
