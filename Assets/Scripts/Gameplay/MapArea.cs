using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapArea : MonoBehaviour
{
    [SerializeField] List<Entity> enemyEntities;

    public Entity GetRandomEnemy()
    {
        var enemy = enemyEntities[Random.Range(0, enemyEntities.Count)];
        enemy.Init();
        return enemy;
    }
}
