using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public abstract class IPanel : MonoBehaviour
{
	[SerializeField]
	private string panel_name;

	public void Show(string _strPanelName)
	{
		Debug.Log(_strPanelName);
		gameObject.SetActive(_strPanelName == panel_name);
	}


}
