﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleGenerator : MonoBehaviour
{
    [SerializeField] List<WavesConfigs> waveConfigList;
    [SerializeField] bool looping = false;

    int origWave = 0;
    // Start is called before the first frame update
    IEnumerator Start()
    {
        do
        {
            yield return StartCoroutine(MakeAllWaves());
        } while (looping);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator GenerateAllObjectsInWave(WavesConfigs wavesConfigs)
    {
        for (int objectExist = 1; objectExist <= wavesConfigs.GetNumberOfObjects(); objectExist ++)
        {
            var newObject = Instantiate(wavesConfigs.GetObjectPrefab(), wavesConfigs.RetrievePoints()[0].transform.position, Quaternion.identity);


            newObject.GetComponent<ObstacleWave>().SetWavesConfig(wavesConfigs);

            yield return new WaitForSeconds(wavesConfigs.GetTimeBetweenReSpawns());
        }
        
    }

    private IEnumerator MakeAllWaves()
    {
        foreach(WavesConfigs presentWave in waveConfigList)
        {
            yield return StartCoroutine(GenerateAllObjectsInWave(presentWave));
        }
    }

}
