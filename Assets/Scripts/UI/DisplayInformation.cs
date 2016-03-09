using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DisplayInformation : MonoBehaviour {

	private GameObject currProvince;
	public GameObject provinceName;
	public GameObject regionName;
	public GameObject provinceImage;
	public GameObject populationNumber;
    public Image flagMask;
    public GameObject owner;
    public Text supplyLimitNumber;



	public void UpdateProvince(GameObject curr)
	{
		currProvince = curr;
		UpdateInformation();
	}

	void UpdateInformation()
	{
        owner = currProvince.GetComponent<ProvinceData>().owner;
        flagMask.GetComponent<Image>().sprite = owner.GetComponent<NationData>().flag;
		provinceName.GetComponent<Text>().text = currProvince.GetComponent<ProvinceData>().provinceName;
		regionName.GetComponent<Text>().text = currProvince.transform.parent.name;
        supplyLimitNumber.text = " " + currProvince.GetComponent<ProvinceData>().supplyLimit;

    }
}
