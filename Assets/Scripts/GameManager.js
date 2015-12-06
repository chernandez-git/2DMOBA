#pragma strict

var creep : GameObject;
var spawn_position;
var timer = 0.0;

function spawnCreep(){
spawn_position = Vector3(0,0,0);
var temp_spawn = Instantiate(creep,spawn_position, Quaternion.identity);
}
function Start () {

}

function Update () {
	timer+= Time.deltaTime;
	if(timer>15){
		spawnCreep();
		timer = 0.0;
	}
}