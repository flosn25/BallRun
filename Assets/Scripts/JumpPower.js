var Rotation : float = 35.0; //Geschwindigkeit der Rotation
function Start () {

}
function Update ()//Standard-Animation von PowerUps	
{
	transform.Rotate (0.0,Rotation * Time.deltaTime, 0.0); //Time.deltaTime für ständige Rotation
}