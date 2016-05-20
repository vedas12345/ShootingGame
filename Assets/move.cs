using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {
    //public GameObject GO1;
	public GameObject cube;

	// Use this for initialization
	void Start () {
        //GO1 = GameObject.Find("Name_Of_GameObject");
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey (KeyCode.L)) {
			cube.transform.localPosition= new Vector3 (cube.transform.position.x+1,cube.transform.position.y,cube.transform.position.z);
		}

		if (Input.GetKey (KeyCode.R)) {
			cube.transform.localPosition= new Vector3 (cube.transform.position.x-1,cube.transform.position.y,cube.transform.position.z);
		}

	}
}
