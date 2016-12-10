﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerInventory : MonoBehaviour
{
	private List<int> keys = new List<int>();


	public bool HasKey(int keyID)
	{
		return keys.Contains(keyID);
	}

	public void AddKey(int keyID)
	{
		keys.Add(keyID);
	}

	public void RemoveKey(int keyID)
	{
		keys.Remove(keyID);
	}
}
