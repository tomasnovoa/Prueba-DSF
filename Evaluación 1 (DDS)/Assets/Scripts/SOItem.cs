using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Item", menuName = "Game/Item")]
public class SOItem : ScriptableObject
{
	[SerializeField] private string name_;
	[SerializeField] private string description;
	[SerializeField] private Sprite sprite;
	

	public string Name => name;
	public string Description => description;
	public Sprite Icon => sprite;
	

}
