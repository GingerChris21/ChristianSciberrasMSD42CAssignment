using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Objects Wave Config")]

public class WavesConfigs : ScriptableObject

{
    [SerializeField] GameObject objectsPrefab;

    [SerializeField] GameObject pathsPrefab;

    [SerializeField] float timeToRespawn = 1f;

    [SerializeField] float generateRespawnRandomFactor = 0.3f;

    [SerializeField] int numberOfObjects = 5;

    [SerializeField] float objectMoveSpeed;

    public GameObject GetObjectPrefab()
    {
        return objectsPrefab;
    }

    public List<Transform> RetrievePoints()
    {
        var wavePoints = new List<Transform>();

        foreach (Transform child in pathsPrefab.transform)
        {
            wavePoints.Add(child);
        }

        return wavePoints;
    }

    public float GetTimeBetweenReSpawns()
    {
        return timeToRespawn;
    }

    public float GetGenerateRespawnRandomFactor()
    {
        return generateRespawnRandomFactor;
    }

    public int GetNumberOfObjects()
    {
        return numberOfObjects;
    }

    public float GetObjectMoveSpeed()
    {
        return objectMoveSpeed;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
