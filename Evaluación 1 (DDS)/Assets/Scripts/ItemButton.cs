using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ItemButton : MonoBehaviour
{
    public SOItem associatedItem;

    public event System.Action<string> OnItemButtonClicked;

    public void Initialize()
    {
        GetComponentInChildren<TextMeshProUGUI>().text = associatedItem.name;
       
    }

    private void OnClick()
    {
        OnItemButtonClicked?.Invoke(associatedItem.name);
    }
}
