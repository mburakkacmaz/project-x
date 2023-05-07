using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PartyMemberUI : MonoBehaviour
{
    [SerializeField] Text nameText;
    [SerializeField] Text levelText;
    [SerializeField] HPBar hpBar;

    [SerializeField] Color highlightedColor;

    Entity _entity;

    public void SetData(Entity entity)
    {
        _entity = entity;

        nameText.text = entity.Base.Name;
        levelText.text = "Lvl " + entity.Level;
        hpBar.SetHP((float)entity.HP / entity.MaxHp);
    }

    public void SetSelected(bool selected)
    {
        if (selected)
            nameText.color = highlightedColor;
        else
            nameText.color = Color.black;
    }
}
