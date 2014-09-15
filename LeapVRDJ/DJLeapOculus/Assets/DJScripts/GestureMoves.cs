using UnityEngine;
using System.Collections;
using Leap;

public class GestureMoves : MonoBehaviour {

	int score = 0;
	public	bool waitingForUser = false;
	public  bool tapCubeSelect = false;
	public  bool swipeCubeSelect = false;
	public  bool circleCubeSelect = false;
	Controller controller;
	public GameObject tapCube;
	public GameObject swipeCube;
	public GameObject circleCube;
	private GameObject instaniatedTapCube;
	private GameObject instaniatedSwipeCube;
	private GameObject instaniatedCircleCube;

	// Use this for initialization
	void Start () {

		//create the controller
		controller = new Controller();

		//enable gestures and stuff
		controller.EnableGesture (Gesture.GestureType.TYPECIRCLE);
		controller.EnableGesture (Gesture.GestureType.TYPESWIPE);
		controller.EnableGesture (Gesture.GestureType.TYPEINVALID);
		controller.EnableGesture (Gesture.GestureType.TYPESCREENTAP);

	}
	
	// Update is called once per frame
	void Update () {
	
		Frame frame = controller.Frame ();
		if (waitingForUser == false) {
						djHero ();
				}
			if (tapCubeSelect == true)
			{
				foreach(Gesture gesture in frame.Gestures())
				{
					switch(gesture.Type)
					{
					case(Gesture.GestureType.TYPE_SCREEN_TAP):
					{
						score += 10;
						Destroy(instaniatedTapCube);
						waitingForUser = false;
						tapCubeSelect = false;
						break;
					}
					}
				}
			}
			else if (swipeCubeSelect == true)
			{
				foreach(Gesture gesture in frame.Gestures())
				{
					switch(gesture.Type)
					{
					case(Gesture.GestureType.TYPE_SWIPE):
					{
						score += 10;
						Destroy(instaniatedSwipeCube);
						waitingForUser = false;
						swipeCubeSelect =  false;
						break;
					}
					}
				}
			}
			else if (circleCubeSelect == true)
			{
				foreach(Gesture gesture in frame.Gestures())
				{
					switch(gesture.Type)
					{
					case(Gesture.GestureType.TYPE_CIRCLE):
					{
						score += 10;
						Destroy(instaniatedCircleCube);
						waitingForUser = false;
						circleCubeSelect = false;
						break;
					}
					}
				}
			}
		
	}

	void djHero ()
	{
		int randoNum = Random.Range (0, 2);

		switch (randoNum) {
		case(0):
		{
			instaniatedTapCube = (GameObject) Instantiate(tapCube, transform.position, transform.rotation);
			waitingForUser = true;
			tapCubeSelect = true;
				break;
		}
		case(1):
		{
			instaniatedSwipeCube =  (GameObject) Instantiate(swipeCube, transform.position, transform.rotation);
			waitingForUser = true;
			swipeCubeSelect = true;
				break;
		}
		case(2):
		{
			instaniatedCircleCube =  (GameObject) Instantiate(circleCube, transform.position, transform.rotation);
			waitingForUser = true;
			circleCubeSelect = true;
				break;
		}
				}
		}

	void OnGUI () {
		GUI.Box(new Rect(10,10,100,90), "Score");
		GUI.Box(new Rect(20,40,80,20), " " + score);
		}
}
