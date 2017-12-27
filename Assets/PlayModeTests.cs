using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.Timeline;

public class PlayModeTests {


	// A UnityTest behaves like a coroutine in PlayMode
	// and allows you to yield null to skip a frame in EditMode
	[UnityTest]
	public IEnumerator QuickMoveTest()
	{
		GameObject player = new GameObject();
		// Use the Assert class to test conditions.
		// yield to skip a frame

		Vector3 startpos = player.transform.position;
		for (int i = 0; i < 10; i++)
		{
			player.transform.Translate(Vector3.forward*3);
			yield return null;
		}
		
		Assert.AreNotEqual(startpos,player.transform.position);
	}
}
