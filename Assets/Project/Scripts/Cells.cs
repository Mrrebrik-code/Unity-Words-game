using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Cells : MonoBehaviour, IDropHandler
{
	[SerializeField] private GameManager _gameManager;
	[SerializeField] private char _latter;
	[SerializeField] Canvas _canvas;
	[SerializeField] GameObject _panelLatters;
	public void OnDrop(PointerEventData eventData)
	{
		if (_latter == eventData.pointerDrag.GetComponent<Latter>().CurrentLatter)
		{
			eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
			eventData.pointerDrag.GetComponent<Latter>().enabled = false;
			_gameManager.Succes++;
		}
	}

	//private bool on
}
