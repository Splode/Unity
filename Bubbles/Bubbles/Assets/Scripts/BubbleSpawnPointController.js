#pragma strict

var BubblePrefab : GameObject;
var DelayUpper : float;
var DelayLower : float;
var LeftBoundary : float = -8;
var RightBoundary : float = 8;
var LowerBoundary : float = -4;

private var nextGenTime : float;

function Start () {
	
}

function Update () {
	if(Time.time > nextGenTime) {

		var randomX : float = Random.Range(LeftBoundary, RightBoundary);
		var randomY : float = Random.Range(transform.position.y, LowerBoundary);
		var newPosition : Vector3 = new Vector3(randomX, randomY, transform.position.z);
		transform.position = newPosition;

		Instantiate(BubblePrefab, transform.position, Quaternion.identity);
		var randomDelay : float = Random.Range(DelayLower, DelayUpper);
		nextGenTime = Time.time + randomDelay;

		
	}
	
}
