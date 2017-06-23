using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ResponsiveButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler {

	bool hovered;
	
	public void OnPointerEnter (PointerEventData eventData)
	{
		hovered = true;
	}

	public void OnPointerExit (PointerEventData eventData)
	{
		hovered = false;
	}

	void Update() {
		if (hovered) {
			transform.localScale = Vector3.Lerp (transform.localScale, Vector3.one * 1.5f, Time.deltaTime * 20f);
		} else {
			transform.localScale = Vector3.Lerp (transform.localScale, Vector3.one, Time.deltaTime * 20f);
		}
	}


}

