using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UiManager : MonoBehaviour
{
   [SerializeField]private GameObject pb;
    [SerializeField] private Transform tf;
    public SOItem [] ItemDats;
    [SerializeField] private TextMeshProUGUI textName;
    [SerializeField] private TextMeshProUGUI textDescription;
    [SerializeField] private Image Icono;


    private void Start()
    {
        for( int i = 0; i < ItemDats.Length; i++)
        {
            SOItem scriptable = ItemDats[i];

            Boton material = Instantiate(pb, tf).GetComponent<Boton>();
        }
    }
    public void UpdatePanel(SOItem item)
    {
        textName.text = item.name;
        textDescription.text = item.Description;
        Icono.sprite = item.Icon;
    }
}

