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
        foreach (GameObject curr in world.GetComponent<ProvinceList>().allProvinces)
        {
            curr.GetComponent<ProvinceData>().isSelected = false;
        }
        GetComponent<ProvinceData>().isSelected = !GetComponent<ProvinceData>().isSelected;
    }

    void Update()
    {
        if (GetComponent<ProvinceData>().isSelected == true)
        {
            GetComponent<SpriteRenderer>().color += new Color(10, 10, 10, 0);
        }
        else
        {
            prevColor = GetComponent<SpriteRenderer>().color;
            GetComponent<SpriteRenderer>().color = GetComponent<SpriteRenderer>().color = prevColor;

        }
    }


}
