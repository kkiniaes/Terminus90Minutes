using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CustomButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler {
	
	private bool hovered;

	void Update() {
		if (hovered) {
			transform.localScale = Vector3.Lerp (transform.localScale, Vector3.one * 1.3f, Time.deltaTime * 10f);
		} else {
			transform.localScale = Vector3.Lerp (transform.localScale, Vector3.one, Time.deltaTime * 10f);
		}
	}

	public void OnPointerEnter (PointerEventData eventData) {
		hovered = true;
	}

	public void OnPointerExit (PointerEventData eventData) {
		hovered = false;
	}


}
