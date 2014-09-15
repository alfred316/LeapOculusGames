#pragma strict

function Start () {

 }   
     
function Update()
	{
	transform.Rotate(Vector3.right * 1);
	transform.Rotate(Vector3.up * 1, Space.World);

}

