using UnityEngine;

public class SpawnerManager : MonoBehaviour
{
    [SerializeField] GameObject Obstacle;
    private Vector3 spawnObj = new Vector3(25, 0, 0);
    private float spawnRate = 2;
    private float startDelay = 2;

    private PlayerController playerControllerScript;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, spawnRate);
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
            
    }

    void SpawnObstacle()
    {
        if (playerControllerScript.gameOver  == false) {
        Instantiate(Obstacle, spawnObj, Obstacle.transform.rotation);
        }
    }

}
