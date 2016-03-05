using UnityEngine;
using System.Collections;

public class TerrainData : MonoBehaviour {

    public Color terrainColor;
    public float supplyLimitModifier;
    public float farmingEfficiency;
    public float farmSize;

    public void accessTerrainData()
    {
        //This edits the variables in the ProvinceData script
        GetComponent<ProvinceData>().supplyLimit *= supplyLimitModifier;
    }
}
