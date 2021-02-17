using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public abstract class IPanel : MonoBehaviour
{
	[SerializeField]
	private List<string> panel_names;

	public void Show(string _strPanelName)
	{
		bool bShow = false;
		foreach(string pagename in panel_names)
		{
			if(bShow == false)
			{
				if( _strPanelName == pagename)
				{
					bShow = true;
					break;
				}
			}
		}
		gameObject.SetActive(bShow);
	}


}
