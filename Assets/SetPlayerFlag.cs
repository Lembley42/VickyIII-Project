using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SetPlayerFlag : MonoBehaviour {
    //This actually does more than set the flag. I named it before I thought of adding the other stuff.
    public Text playerName;
    public GameObject nations;
    public Image sourceFlag;

	void Start () {
        //Sets the flag on the top bar
        sourceFlag.GetComponent<Image>().sprite = nations.GetComponent<GlobalNationData>().player.GetComponent<NationData>().flag;
        //Sets the name
        playerName.text = nations.GetComponent<GlobalNationData>().player.GetComponent<NationData>().nationName;
        
	}
	
}
