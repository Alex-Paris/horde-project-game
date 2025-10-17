using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disabler : MonoBehaviour
{
	public EnemyPooling leftEnemyPool;
	public EnemyPooling rightEnemyPool;
	
	private void OnDisable()
	{
		leftEnemyPool.DestroyAllEnemies();
		rightEnemyPool.DestroyAllEnemies();
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		collision.attachedRigidbody.gameObject.SetActive(false);
	}
}
