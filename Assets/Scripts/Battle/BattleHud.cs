using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BattleHud : MonoBehaviour
{
    [SerializeField] Text nameText;
    [SerializeField] Text levelText;
    [SerializeField] HPBar hpBar;

    Entity _entity;

    public void SetData(Entity entity)
    {
        _entity = entity;

        nameText.text = entity.Base.Name;
        levelText.text = "Lvl " + entity.Level;
        hpBar.SetHP((float) entity.HP / entity.MaxHp);
    }

    public IEnumerator UpdateHP()
    {
        yield return hpBar.SetHPSmooth((float)_entity.HP / _entity.MaxHp);
    }
}
