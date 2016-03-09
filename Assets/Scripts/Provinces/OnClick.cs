using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class OnClick : MonoBehaviour {

	public GameObject provincePanel;
    public Color prevColor;
    public GameObject world;


    void Start()
	{
        //world = GameObject.Find("world");
    }

	void OnMouseDown()
	{
		provincePanel.SetActive(true);
		provincePanel.GetComponent<DisplayInformation>().UpdateProvince(gameObject);
        GetComponent<ProvinceData>().isSelected = !GetComponent<ProvinceData>().isSelected;

        if(GetComponent<ProvinceData>().isSelected == true)
        {
            prevColor = GetComponent<SpriteRenderer>().color;
            GetComponent<SpriteRenderer>().color = new Color(255,255,255,10);
        }
        else
        {
            GetComponent<SpriteRenderer>().color = prevColor;
        }
    }

}
