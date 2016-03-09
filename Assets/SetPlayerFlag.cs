using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SetPlayerFlag : MonoBehaviour {

    public Text playerName;
    public GameObject player;
    public Image sourceFlag;

	void Start () {
        sourceFlag.GetComponent<Image>().sprite = player.GetComponent<NationData>().flag;
        playerName.text = player.GetComponent<NationData>().nationName;
        
	}
	
}
