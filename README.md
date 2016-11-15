# 3DPlatformer
CS 4365 3D Platformer Fall 2016

Only the "Hopefully_CollectableAndHealthDrop.unitypackage" should matter. I'll keep trying to get a version up with my changes but in case theres trouble grab that. 

I added a description when I committed so refer to that as a guide of what to do with the scripts and prefabs.

Brief:

   SPAWNER - Add inside the enemy/Gameobject folder that will be destroyed. Spawns the HealthPoints. Assign enemy prefab to the Deadteller position. If there are scripting issues try latter description of below
  
  FixOrbCollectible - Fix version of the orb. If theres any position issues on play, put it in a new Gameobject and move the Float script to parent

  Magnet - Add to the Player Folder, central its collider with the Model
  
  Collect - Same as above^
  
  HealthPoints - You can place this around the prefab around the map if you want but this is the prefab1 SPAWNER should use. Hp_drop.cs goes in here
  
  PlayerController.cs - GUpdate() and Setcount() functions are used for collecting/displaying CollectibleOrb amount info feel free to rip that out of the script if you need a counter Lucas/whoever
