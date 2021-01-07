using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleGenerator : MonoBehaviour
{
    [SerializeField] List<WavesConfigs> waveConfigList;

    int origWave = 0;
    // Start is called before the first frame update
    void Start()
    {
        var presentWave = waveConfigList[origWave];

        StartCoroutine(GenerateAllObjectsInWave(presentWave));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator GenerateAllObjectsInWave(WavesConfigs wavesConfigs)
    {
        Instantiate(wavesConfigs.GetObjectPrefab(), wavesConfigs.RetrievePoints()[0].transform.position, Quaternion.identity);

        yield return new WaitForSeconds(wavesConfigs.GetTimeBetweenReSpawns());
    }

}
