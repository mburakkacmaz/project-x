using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PartyScreen : MonoBehaviour
{
    [SerializeField] Text messageText;

    PartyMemberUI[] memberSlots;
    List<Entity> entities;

    public void Init()
    {
        memberSlots = GetComponentsInChildren<PartyMemberUI>();
    }

    public void SetPartyData(List<Entity> entities)
    {
        this.entities = entities;

        for (int i = 0; i < memberSlots.Length; i++)
        {
            if (i < entities.Count)
                memberSlots[i].SetData(entities[i]);
            else 
                memberSlots[i].gameObject.SetActive(false);
        }

        messageText.text = "Takým Üyesini Seçiniz";
    }

    public void UpdateMemberSelection(int selectedMember)
    {
        for (int i = 0; i < entities.Count; i++)
        {
            if (i == selectedMember)
                memberSlots[i].SetSelected(true);
            else
                memberSlots[i].SetSelected(false);
        }
    }

    public void SetMessageText(string message)
    {
        messageText.text = message;
    }
}
