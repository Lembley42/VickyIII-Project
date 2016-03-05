﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class ProvinceData : MonoBehaviour {
    public string provinceName;
    public bool isCapital;
    public GameObject owner;
    public GameObject controller;
    public List<GameObject> cores;
    public GameObject terrain;
    public GameObject climate;
    public GameObject tradeGood;
    public float warValue;
	public Sprite withoutBorders;
	public Sprite withBorders;
	public float supplyLimit = 6f;
    void Start () 
	{
		provinceName = transform.name;
		GetComponent<SpriteRenderer>().sprite = withoutBorders;
		if(owner != null)
		{
			GetComponent<SpriteRenderer>().color = owner.GetComponent<NationData>().nationColor;

		}
		terrain.GetComponent<TerrainData>().AccessTerrainData(gameObject);
    } 
	
	void Update () {
	
	}

}
