using System.Collections;
using UnityEngine;
using Spine.Unity;

public class PlayerController : MonoBehaviour {

	public SkeletonAnimation skeletonAnimation;

	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKey("space"))
		{
			skeletonAnimation.AnimationName = "scare";
		}
		if (Input.GetKey ("d")) 
		{
			skeletonAnimation.AnimationName = "run";
			this.transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
		}
		if (Input.GetKey ("s")) 
		{
			skeletonAnimation.AnimationName = "idle";
		}
		if (Input.GetKey ("a")) 
		{
			skeletonAnimation.AnimationName = "run"; 
			this.transform.rotation = Quaternion.Euler(new Vector3(0, 180, 0));
		}
		if (Input.GetKey ("w")) 
		{
			skeletonAnimation.AnimationName = "death";
		}
	}
}
