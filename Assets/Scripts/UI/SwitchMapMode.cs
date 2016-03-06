using UnityEngine;
using System.Collections;

public class SwitchMapMode : MonoBehaviour {

	public GameObject world;

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
            curr.GetComponent<SpriteRenderer>().color = new Vector4(0,Mathf.Round(curr.GetComponent<ProvinceData>().supplyLimit),0,255);
        }
    }

    public void SwitchToRGOMapMode()
    {
        foreach (GameObject curr in world.GetComponent<ProvinceList>().allProvinces)
        {
            //curr.GetComponent<SpriteRenderer>().color = 
        }
    }
}
