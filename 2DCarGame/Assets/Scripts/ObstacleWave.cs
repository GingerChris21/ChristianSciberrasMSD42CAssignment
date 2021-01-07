using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleWave : MonoBehaviour
{
    [SerializeField] List<Transform> waypoints;

    [SerializeField] float ObstacleMoveSpeed = 1.5f;

    [SerializeField] WavesConfigs waveConfig;
    // Start is called before the first frame update

    int PositionIndex = 0;
    void Start()
    {
        waypoints = waveConfig.RetrievePoints();

        transform.position = waypoints[PositionIndex].transform.position;


    }

    // Update is called once per frame
    void Update()
    {
        ObstacleMove();
    }

    private void ObstacleMove()
    {
        if (PositionIndex <= waypoints.Count - 1)
        {
            var objectivePosition = waypoints[PositionIndex].transform.position;

            objectivePosition.z = 0f;

            var obstacleMovment = ObstacleMoveSpeed * Time.deltaTime;

           transform.position = Vector2.MoveTowards(transform.position, objectivePosition, obstacleMovment);

            if (transform.position == objectivePosition)
            {
                PositionIndex++;
            }
        }

        else
        {
            Destroy(gameObject);
        }

    }

}
