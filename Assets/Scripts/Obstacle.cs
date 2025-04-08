using UnityEngine;

public class Obstacle : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    void Update()
{
    if (transform.position.x < -9f) 
    {
        ObstacleObjectPool.Instance.Return(gameObject);
    }
}
}
