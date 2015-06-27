using UnityEngine;
using System.Collections;

public class mainS_v1 : MonoBehaviour {
	
	public GameObject box;
	public GameObject hero;
	public GameObject win;
	
	public Vector3 current_hero_position;
	public Vector3 current_box_position;

	void Start () {
	}
	void Update () {
		
		current_hero_position = hero.transform.position;
		current_box_position = box.transform.position;

		if (Input.GetKeyDown ("w")) {
			if (hero.transform.position == new Vector3 (box.transform.position.x , 0.875f , box.transform.position.z - 1)){
			current_box_position += new Vector3 (0, 0, 1);
			}
			current_hero_position += new Vector3 (0, 0, 1);

			if (CheckCollision(current_box_position))
			{
				if (CheckCollision(current_hero_position)) {
					hero.transform.position = current_hero_position;
					box.transform.position = current_box_position;
				}
			}
		}


		if (Input.GetKeyDown ("s")) {
			if (hero.transform.position == new Vector3 (box.transform.position.x , 0.875f , box.transform.position.z + 1)){
				current_box_position -= new Vector3 (0, 0, 1);
			}
			current_hero_position -= new Vector3 (0, 0, 1);
			
			if (CheckCollision(current_box_position))
			{
				if (CheckCollision(current_hero_position)) {
					hero.transform.position = current_hero_position;
					box.transform.position = current_box_position;
				}
			}
		}


		if (Input.GetKeyDown ("a")) {
			if (hero.transform.position == new Vector3 (box.transform.position.x + 1 , 0.875f , box.transform.position.z)){
				current_box_position -= new Vector3 (1, 0, 0);
			}
			current_hero_position -= new Vector3 (1, 0, 0);
			
			if (CheckCollision(current_box_position))
			{
				if (CheckCollision(current_hero_position)) {
					hero.transform.position = current_hero_position;
					box.transform.position = current_box_position;
				}
			}
		}


		if (Input.GetKeyDown ("d")) {
			if (hero.transform.position == new Vector3 (box.transform.position.x - 1 , 0.875f , box.transform.position.z)){
				current_box_position += new Vector3 (1, 0, 0);
			}
			current_hero_position += new Vector3 (1, 0, 0);
			
			if (CheckCollision(current_box_position))
			{
				if (CheckCollision(current_hero_position)) {
					hero.transform.position = current_hero_position;
					box.transform.position = current_box_position;
				}
			}
		}


		if (Input.GetKeyDown ("r")) {

			hero.transform.position = new Vector3 (-3,0.875f,-4);
			box.transform.position = new Vector3 (-3,0.875f,-3);
			win.transform.position = new Vector3 (0, -2 , 0);

		}

		if ((box.transform.position) == (new Vector3 (4, 0.875f, 4))) {

			win.transform.position = new Vector3 (0, 2, 0);

		}
		
	}
	bool CheckCollision(Vector3 curPos)
	{   
    return 
		    (curPos != new Vector3 (1, 0.875f, 1)) &&
			(curPos != new Vector3 (0, 0.875f, 0)) &&
			(curPos != new Vector3 (3, 0.875f, 4)) &&
			(curPos != new Vector3 (-3, 0.875f, 4)) &&
			(curPos != new Vector3 (3, 0.875f, -2)) &&
			(curPos != new Vector3 (3, 0.875f, -3)) &&
		//top edge
			(curPos != new Vector3 (-4, 0.875f, 5)) &&
			(curPos != new Vector3 (-3, 0.875f, 5)) &&
			(curPos != new Vector3 (-2, 0.875f, 5)) &&
			(curPos != new Vector3 (-1, 0.875f, 5)) &&
			(curPos != new Vector3 (0, 0.875f, 5)) &&
			(curPos != new Vector3 (1, 0.875f, 5)) &&
			(curPos != new Vector3 (2, 0.875f, 5)) &&
			(curPos != new Vector3 (3, 0.875f, 5)) &&
			(curPos != new Vector3 (4, 0.875f, 5)) &&
		//bottom edge
			(curPos != new Vector3 (-4, 0.875f, -5)) &&
			(curPos != new Vector3 (-3, 0.875f, -5)) &&
			(curPos != new Vector3 (-2, 0.875f, -5)) &&
			(curPos != new Vector3 (-1, 0.875f, -5)) &&
			(curPos != new Vector3 (0, 0.875f, -5)) &&
			(curPos != new Vector3 (1, 0.875f, -5)) &&
			(curPos != new Vector3 (2, 0.875f, -5)) &&
			(curPos != new Vector3 (3, 0.875f, -5)) &&
			(curPos != new Vector3 (4, 0.875f, -5)) &&
		//right edge
			(curPos != new Vector3 (5, 0.875f, 4)) &&
			(curPos != new Vector3 (5, 0.875f, 3)) &&
			(curPos != new Vector3 (5, 0.875f, 2)) &&
			(curPos != new Vector3 (5, 0.875f, 1)) &&
			(curPos != new Vector3 (5, 0.875f, 0)) && 
			(curPos != new Vector3 (5, 0.875f, -1)) &&
			(curPos != new Vector3 (5, 0.875f, -2)) &&
			(curPos != new Vector3 (5, 0.875f, -3)) &&
			(curPos != new Vector3 (5, 0.875f, -4)) &&
		//left edge
			(curPos != new Vector3 (-5, 0.875f, 4)) &&
			(curPos != new Vector3 (-5, 0.875f, 3)) &&
			(curPos != new Vector3 (-5, 0.875f, 2)) &&
			(curPos != new Vector3 (-5, 0.875f, 1)) &&
			(curPos != new Vector3 (-5, 0.875f, 0)) &&
			(curPos != new Vector3 (-5, 0.875f, -1)) &&
			(curPos != new Vector3 (-5, 0.875f, -2)) &&
			(curPos != new Vector3 (-5, 0.875f, -3)) &&
			(curPos != new Vector3 (-5, 0.875f, -4));
	}
}
