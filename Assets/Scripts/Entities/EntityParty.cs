using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class EntityParty : MonoBehaviour
{
    [SerializeField] List<Entity> entities;


    public List<Entity> Entities { get { return entities; } }

    private void Start()
    {
        foreach (var entity in entities)
        {
            entity.Init();
        }
    }

    public Entity GetHealtyEntity()
    {
        return entities.Where(x => x.HP > 0).FirstOrDefault();
    }
}
