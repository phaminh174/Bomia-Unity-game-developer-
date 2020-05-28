using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObtacles : MonoBehaviour
{
    public GameObject[] obstaclePatterns;
    //speed adjustment
    public float defauftSpeed = 2f;
    public float maxSpeed;
    public float increaseSpeed;
    private MovingObtacles obstacle;
    //time adjustment
    float timeBtwSpawn = 0;
    public float startTimeSpawn;
    public float minTime;
    public float decreaseTime;
    //lifeTime
    public float lifeTime;

    // Update is called once per frame
    void Update()
    {
        if (timeBtwSpawn <= 0) 
        {
            int rand = Random.Range(0, obstaclePatterns.Length);
            obstacle = obstaclePatterns[rand].GetComponent<MovingObtacles>();
            obstacle.Speed = defauftSpeed;
            Destroy(Instantiate(obstaclePatterns[rand], transform.position, Quaternion.identity), lifeTime);
            timeBtwSpawn = startTimeSpawn;
            if (defauftSpeed < maxSpeed)
            {
                defauftSpeed += increaseSpeed;
            }
            if (startTimeSpawn > minTime)
            {
                startTimeSpawn -= decreaseTime;
            }
        } else
        {
            timeBtwSpawn -= Time.deltaTime;
        }
    }
}
