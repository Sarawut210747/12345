using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public Transform spawnPoint;
    private PlayerController playerController;

    void Start()
    {
        var go = GameObject.Find("Player");
        playerController = go.GetComponent<PlayerController>();
        InvokeRepeating("Spawn", 1, 3);
    }

    void Spawn()
    {
        if (playerController.isGameOver == false)
        {
            GameObject obstacle = ObstacleObjectPool.Instance.Acquire();
            obstacle.transform.position = spawnPoint.position;
            obstacle.transform.rotation = Quaternion.identity;
        }
    }
}
