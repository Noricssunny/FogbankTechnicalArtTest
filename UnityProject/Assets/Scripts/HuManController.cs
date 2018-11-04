using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HuManController : MonoBehaviour 
{
	public Animator animator;
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown ("d")) 
		{
			animator.SetTrigger ("moving");
			this.transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
		}
		if (Input.GetKeyDown("s"))
		{
			animator.SetTrigger ("idling");
		}
		if (Input.GetKeyDown ("space")) 
		{
			animator.SetTrigger ("jumping");
		}
		if (Input.GetKeyDown ("w")) 
		{
			animator.SetTrigger ("dying");
		}
		if (Input.GetKeyDown ("a")) 
		{
			animator.SetTrigger ("moving");
			this.transform.rotation = Quaternion.Euler(new Vector3(0, 180, 0));
		}
		if (Input.GetKeyDown("e"))
		{
			animator.SetTrigger ("clapping");
		}
	}
}
