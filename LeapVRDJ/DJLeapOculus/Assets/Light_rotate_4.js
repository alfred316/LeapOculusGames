#pragma strict

function Start () {

 }   
     
function Update()
	{
	transform.Rotate(Vector3.right * 2);
	transform.Rotate(Vector3.up * 6, Space.World);

}

