#pragma strict

var buttonToggle: boolean;
var trueButton : Material;
var falseButton : Material;

function Update () {

	if (buttonToggle)
	{
		if (audio.pitch > 0)
			audio.pitch -= 0.01;
		else
			audio.Pause();
	}
	else
	{
	
		if (audio.pitch < 1){
		
			if(!audio.isPlaying)
				audio.Play();
			audio.pitch += 0.1;
	
		}
	}
	
	

}


function OnCollisionEnter (col : Collision)
{

	if (!buttonToggle)
	{
		buttonToggle = true;
		renderer.material = trueButton;
		}
	else
	{
		buttonToggle = false;
		renderer.material = falseButton;
		}

}