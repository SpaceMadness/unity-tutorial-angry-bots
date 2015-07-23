using UnityEngine;
using System.Collections;

using LunarPlugin;

[CCommand("checkpoint")]
class Cmd_checkpoint : CCommand
{
	void Execute(string name)
	{
		// 1. find checkpoint
		// 2. find player
		// 3. move player to checkpoint (if play mode)
	}
}