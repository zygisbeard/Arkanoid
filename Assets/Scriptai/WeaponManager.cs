using UnityEngine;
using System.Collections;

public class WeaponManager : MonoBehaviour {
}


public interface IWeapon{
	void Shoot(); 
}

public class Bullet: MonoBehaviour, IWeapon{
	public void Shoot(){
	
		Vector3 initialPosition = new Vector3 (this.transform.position.x, this.transform.position.y +1f,0);
		GameObject bullet =  Instantiate(Resources.Load("bullet",typeof(GameObject))) as GameObject;	
		bullet.transform.position = initialPosition;
		bullet.GetComponent<Rigidbody>().velocity = new Vector2(0f,3f);

	} 
}

public class Missile: MonoBehaviour, IWeapon{
	public void Shoot(){
		
		Vector3 initialPosition = new Vector3 (this.transform.position.x, this.transform.position.y + 1f,0);
		GameObject missile =  Instantiate(Resources.Load("missile",typeof(GameObject))) as GameObject;	
		missile.transform.position = initialPosition;
		missile.GetComponent<Rigidbody>().velocity = new Vector2(0f,3f);
		
	}

}

