using UnityEngine;
using System.Collections;

public class TerrainData : MonoBehaviour {

    public Color terrainColor;
    public float baseTerrainSupply;
    public float farmingEfficiency;
    public float farmSize;
	public float movementCost;
	public float defence;
	public float combatWidth;

    public void AccessTerrainData(GameObject currProvince)
    {
        //This edits the variables in the ProvinceData script
		currProvince.GetComponent<ProvinceData>().supplyLimit += baseTerrainSupply;
    }
}
