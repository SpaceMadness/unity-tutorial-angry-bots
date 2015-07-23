using UnityEngine;

using System;
using System.Collections;
using System.Collections.Generic;

using LunarPlugin;

[CCommand("checkpoint")]
class Cmd_checkpoint : CCommand
{
	void Execute(string name = null)
	{
		// 1. find checkpoint
		IList<SpawnTransform> transforms = FindSpawnTransforms(name);
		foreach (SpawnTransform t in transforms)
		{
			PrintIndent(t.name);
		}

		// 2. find player
		// 3. move player to checkpoint (if play mode)
	}

	IList<SpawnTransform> FindSpawnTransforms (string prefix) // why IList?
	{
		SpawnTransform[] transforms = GameObject.FindObjectsOfType<SpawnTransform> ();

		if (string.IsNullOrEmpty (prefix)) { // nothing to filter?
			return transforms; // all objects
		}

		List<SpawnTransform> filtered = new List<SpawnTransform> ();
		foreach (SpawnTransform t in transforms) {
			if (t.name != null && t.name.StartsWith (prefix, StringComparison.OrdinalIgnoreCase)) {
				filtered.Add (t);
			}
		}

		return filtered;
	}
}