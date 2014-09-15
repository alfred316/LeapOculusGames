#pragma strict

var newColor : Material;
var lightParticles : Transform;

function changeColor (dingle : float)
{
	renderer.material = newColor;
	Instantiate(lightParticles, transform.position, transform.rotation);
	Debug.Log(dingle);
}