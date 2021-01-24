using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		GameObject lightObj;
		var speed = 50;

		if (Input.GetKey(KeyCode.RightArrow))
		{
			this.transform.Rotate(new Vector3(speed * Time.deltaTime, 0, 0));
		}
		if (Input.GetKey(KeyCode.LeftArrow))
		{
			this.transform.Rotate(new Vector3(-speed * Time.deltaTime, 0, 0));
		}
		if (Input.GetKey(KeyCode.DownArrow))
		{
			this.transform.Rotate(new Vector3(0, -speed * Time.deltaTime, 0));
		}
		if (Input.GetKey(KeyCode.UpArrow))
		{
			this.transform.Rotate(new Vector3(0, speed * Time.deltaTime, 0));
		}
		if (Input.GetKey(KeyCode.A))
		{
			this.transform.Rotate(new Vector3(0, 0, speed * Time.deltaTime));
		}
		if (Input.GetKey(KeyCode.Z))
		{
			this.transform.Rotate(new Vector3(0, 0, -speed * Time.deltaTime));
		}


	}
}
//this.transform.Rotate (new Vector3 (5f, 0.001f,0.001f));
    }
}
