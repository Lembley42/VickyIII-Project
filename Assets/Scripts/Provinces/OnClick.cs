using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class OnClick : MonoBehaviour {

	public GameObject provincePanel;
    public Color prevColor;
    public GameObject world;


    void Start()
	{
        prevColor = GetComponent<SpriteRenderer>().color;
    }

	void OnMouseDown()
	{
		provincePanel.SetActive(true);
		provincePanel.GetComponent<DisplayInformation>().UpdateProvince(gameObject);
        // 4/10 needs work.
        foreach (GameObject curr in world.GetComponent<ProvinceList>().allProvinces)
        {
            curr.GetComponent<ProvinceData>().isSelected = false;
            GetComponent<SpriteRenderer>().color = prevColor;
        }
        //Sets isSelected to its oppisite
        GetComponent<ProvinceData>().isSelected = !GetComponent<ProvinceData>().isSelected;
        //Sets the color to white. It's supposed to add 10 to each color >:(
        GetComponent<SpriteRenderer>().color += new Color(10, 10, 10, 0);
    }

    void Update()//Don't get rid of this stuff yet. I might need it.
    {
        if (GetComponent<ProvinceData>().isSelected == true)
        {
            //GetComponent<SpriteRenderer>().color += new Color(10, 10, 10, 0);
        }
        else
        {
            //prevColor = GetComponent<SpriteRenderer>().color;
            //GetComponent<SpriteRenderer>().color = prevColor;

        }
    }


}
