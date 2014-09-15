#pragma strict

var dingle : float = 0;
var distance : float;

function Update () {
	var hit : RaycastHit;
	if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), hit))
	{
		distance = hit.distance;
		Debug.Log("distance is: " + distance);
		hit.transform.SendMessage("changeColor", dingle, SendMessageOptions.DontRequireReceiver);	
		
	}

}