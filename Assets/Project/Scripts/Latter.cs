using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Latter : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{
	public char CurrentLatter;

	private RectTransform _rectTransform = new RectTransform();
	[SerializeField] Canvas _canvas;
	private CanvasGroup _canvaseGroupe;
	public GameObject _panel;
	public Vector2 StartPosition;

	private void Awake()
	{
		StartPosition = GetComponent<RectTransform>().anchoredPosition;
		_rectTransform = GetComponent<RectTransform>();
		_canvaseGroupe = GetComponent<CanvasGroup>();
	}
	public void OnBeginDrag(PointerEventData eventData)
	{
		_canvaseGroupe.blocksRaycasts = false;
	}

	public void OnDrag(PointerEventData eventData)
	{
		_rectTransform.anchoredPosition += eventData.delta / _canvas.scaleFactor / _panel.GetComponent<RectTransform>().localScale;
	}

	public void OnEndDrag(PointerEventData eventData)
	{
		_canvaseGroupe.blocksRaycasts = true;
	}
}
