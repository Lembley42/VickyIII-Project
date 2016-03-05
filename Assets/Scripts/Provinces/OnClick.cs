using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class OnClick : MonoBehaviour {

	public GameObject provincePanel;

	void Start()
	{
	}

	void OnMouseDown()
	{
		provincePanel.SetActive(true);
		provincePanel.GetComponent<DisplayInformation>().UpdateProvince(gameObject);
	}

    public void closePanel()
    {
        provincePanel.SetActive(false);
    }
}
