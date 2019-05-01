using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Third_Person_Perspective : MonoBehaviour
{
    public Transform LookAt;
	public Transform camTransform;
	private Camera cam;
	private float	distance=10.0f;
	private float currentX=0.0f;
	private float currentY=0.0f;
	private float sensivityX =4.0f;
	private float sensivityY=1.0f;

	private void Start(){
		camTransform=transform;
		cam=Camera.main;
	}
	private void LateUpdate(){
		Vector3 dir = new Vector3 (0,0,-distance);
		Quaternion rotation= Quaternion.Euler(currentX,currentY,0);
		camTransform.position = LookAt.position + rotation * dir;
	}
}
