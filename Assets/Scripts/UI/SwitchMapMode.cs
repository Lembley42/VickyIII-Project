using UnityEngine;
using System.Collections;

public class SwitchMapMode : MonoBehaviour {

	public GameObject world;
    public GameObject selectedTradeGood;

	public void SwitchToPoliticalMapMode()
	{
       foreach (GameObject curr in world.GetComponent<ProvinceList>().allProvinces)
       {
       	    curr.GetComponent<SpriteRenderer>().color = curr.GetComponent<ProvinceData>().owner.GetComponent<NationData>().nationColor;
       }
	}

    public void SwitchToTerrainMapMode()
    {
        foreach (GameObject curr in world.GetComponent<ProvinceList>().allProvinces)
        {
            curr.GetComponent<SpriteRenderer>().color = curr.GetComponent<ProvinceData>().terrain.GetComponent<TerrainData>().terrainColor;
        }
    }

    public void SwitchToSupplyMapMode()
    {
        foreach (GameObject curr in world.GetComponent<ProvinceList>().allProvinces)
        {
<<<<<<< HEAD
            curr.GetComponent<SpriteRenderer>().color = new Color(0,Mathf.Round(curr.GetComponent<ProvinceData>().supplyLimit),0,255);
        }
    }

    public void SwitchToRGOMapMode()
    {
        foreach (GameObject curr in world.GetComponent<ProvinceList>().allProvinces)
        {
            //curr.GetComponent<ProvinceData>().tradeGood.GetComponent<TradeGoodData>().icon. = curr.transform.position;

            //If the current province is selected
            if (curr.GetComponent<ProvinceData>().isSelected == true){
                //Set the trade good to be highlighted to the tradegood of the current province.
                selectedTradeGood = curr.GetComponent<ProvinceData>().tradeGood;
            }
            //If the current province has the selected trade good
           if (curr.GetComponent<ProvinceData>().tradeGood == selectedTradeGood)
            {
                //Set its color to red
                curr.GetComponent<SpriteRenderer>().color = new Color (100,0,0,255);
            }
            else
            {
                //Set its color to gray
                curr.GetComponent<SpriteRenderer>().color = new Color(50, 50, 50, 255);
            }
=======
            curr.GetComponent<SpriteRenderer>().color = new Vector4(0,curr.GetComponent<ProvinceData>().supplyLimit,0,255);
>>>>>>> origin/master
        }
    }
}
