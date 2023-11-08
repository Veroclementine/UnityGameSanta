using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    //public GameObject obstacle;
    public static ObstacleSpawner instance;
    public GameObject[] obstacles;
    public bool gameOver = false;
    public float minSpwanTime, maxSpawnTime;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    void Start()
    {
        StartCoroutine("Spawn");
    }
    //faire apparaître un obstacle aleatoire -random
    IEnumerator Spawn()
    {
        float waitTime = 1f;

        yield return new WaitForSeconds(waitTime);

        while (!gameOver)
        {
            
            SpawnObstacle();
            waitTime = Random.Range(minSpwanTime,maxSpawnTime);
            yield return new WaitForSeconds(waitTime);
        }
    }


    void SpawnObstacle()
    {
        //pour créer des obstacles aléatoires, je crée d'abord une variable et je l'instancie ensuite.
        int random = Random.Range(0, obstacles.Length);

        Instantiate(obstacles[random], transform.position, Quaternion.identity);
    }
}
