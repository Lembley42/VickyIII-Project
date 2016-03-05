using UnityEngine;
using System.Collections;

public class NameDisplay : MonoBehaviour {
	void Start()
	{
		transform.GetComponent<Renderer>().sortingOrder++;
		var text = GetComponent<TextMesh>();
		var pos = transform.parent.position;
		text.text = string.Format("" + transform.parent.GetComponent<ProvinceData>().provinceName, pos.x, pos.y);
	}
}