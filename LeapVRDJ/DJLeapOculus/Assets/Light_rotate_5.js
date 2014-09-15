#pragma strict

function Start () {

 }   
     
function Update()
	{
	transform.Rotate(Vector3.right * 8);
	transform.Rotate(Vector3.up * 10, Space.World);

}

