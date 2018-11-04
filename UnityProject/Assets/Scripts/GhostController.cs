using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Spine.Unity;

public class GhostController : MonoBehaviour {

	public SkeletonAnimation skeletonAnimation;

	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown("space"))
		{
			skeletonAnimation.loop = true;
			skeletonAnimation.AnimationName = "scare";

		}
		if (Input.GetKeyDown ("d")) 
		{
			skeletonAnimation.loop = true;
			skeletonAnimation.AnimationName = "run";

			this.transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
		}
		if (Input.GetKeyDown ("s")) 
		{
			skeletonAnimation.loop = true;
			skeletonAnimation.AnimationName = "idle";

		}
		if (Input.GetKeyDown ("a")) 
		{
			skeletonAnimation.loop = true;
			skeletonAnimation.AnimationName = "run"; 

			this.transform.rotation = Quaternion.Euler(new Vector3(0, 180, 0));
		}
		if (Input.GetKeyDown ("w")) 
		{
			skeletonAnimation.loop = false;
			skeletonAnimation.AnimationName = "death";

		}
	}
}
