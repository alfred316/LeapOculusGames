#pragma strict

function Start () {

 }   
     
function Update()
	{
	transform.Rotate(Vector3.right * 4);
	transform.Rotate(Vector3.up * 4, Space.World);

}

