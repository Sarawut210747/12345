using System.Collections.Generic;
using UnityEngine;

public class ObstacleObjectPool : MonoBehaviour
{
    public static ObstacleObjectPool Instance;
    public GameObject obstaclePrefab;
    public int poolSize = 10;
    private List<GameObject> pool = new List<GameObject>();

    void Awake()
    {
        Instance = this;

        for (int i = 0; i < poolSize; i++)
        {
            GameObject obj = Instantiate(obstaclePrefab);
            obj.SetActive(false);
            pool.Add(obj);
        }
    }
    

    public GameObject Acquire()
    {
        foreach (var obj in pool)
        {
            if (!obj.activeInHierarchy)
            {
                obj.SetActive(true);
                return obj;
            }
        }

        GameObject objNew = Instantiate(obstaclePrefab);
        objNew.SetActive(true);
        pool.Add(objNew);
        return objNew;
    }

    public void Return(GameObject obj)
    {
        obj.SetActive(false);
    }
}
