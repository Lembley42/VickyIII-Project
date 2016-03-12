using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	private Vector3 CameraMovement;
	public float cameraSpeed;
	public float zoomSpeed;
	public float minZoom;
	public float maxZoom;
	public ProvinceList provList;

	void Start ()
	{
	
		
	}
	
	void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");
		float zoom = Input.GetAxis("Mouse ScrollWheel");
		
		
		CameraMovement.Set(moveHorizontal, moveVertical, 0f);
		transform.Translate(CameraMovement * cameraSpeed);
		Camera.main.orthographicSize -= zoom * zoomSpeed;
		Camera.main.orthographicSize = Mathf.Clamp(Camera.main.orthographicSize, minZoom, maxZoom);
		if(Camera.main.orthographicSize <= 1)
		{
			foreach(GameObject currProv in provList.allProvinces)
			{
				currProv.GetComponent<SpriteRenderer>().sprite = currProv.GetComponent<ProvinceData>().withBorders;
                if (currProv.GetComponent<ProvinceData>().isCapital == true)
                {
                    //Enable the capital icon.
                    currProv.GetComponent<ProvinceData>().owner.GetComponent<NationData>().capital.SetActive(true);
                }
            }
		}
		else
		{
			foreach(GameObject currProv in provList.allProvinces)
			{
				currProv.GetComponent<SpriteRenderer>().sprite = currProv.GetComponent<ProvinceData>().withoutBorders;
                if(currProv.GetComponent<ProvinceData>().isCapital == true)
                {
                    //Disable the capital icon
                    currProv.GetComponent<ProvinceData>().owner.GetComponent<NationData>().capital.SetActive(false);
                }
			}
		}
	}
}
