#pragma strict

function Start () {

 }   
     
function Update()
	{
	transform.Rotate(Vector3.right * 5);
	transform.Rotate(Vector3.up * 3, Space.World);

}

