using UnityEngine;
using System.Collections;

public enum WeaponType{
	Missile,
	Bullet
}

public enum Flame{
	Blue,
	Red
}

public class ShipControler : MonoBehaviour {
	
	
	public WeaponType weaponType; 
	public Flame flameColor;
	
	private IWeapon iWeapon;
	private IFlame iFlame;	

	
	private void HandleWeaponType(){
	 
		Component c = gameObject.GetComponent<IWeapon>() as Component;
		
		if(c!=null){
				Destroy(c);
		}
	
		// Naudojama Strategy
		switch(weaponType){
		
			case WeaponType.Missile:
				iWeapon = gameObject.AddComponent<Missile> ();
				break;
				
			case WeaponType.Bullet:
				iWeapon = gameObject.AddComponent<Bullet> ();
				break;
				
			default:
				iWeapon = gameObject.AddComponent<Bullet> ();
				break;
		}
		
	}
	
	public void HandleFlameColor(){
	
		Component c = gameObject.GetComponent<IFlame>() as Component;
		
		if(c!=null){
			Destroy(c);
			iFlame.DestroyFlame(); 
		}

        // Naudojama Strategy
        switch (flameColor){
			
		case Flame.Blue:
			iFlame = gameObject.AddComponent<BlueFlame> ();
			break;
			
		case Flame.Red:
			iFlame = gameObject.AddComponent<RedFlame> ();
			break;
			
		default:
			iFlame = gameObject.AddComponent<BlueFlame> ();
			break;
		}
		
		
	}
	
	public void Fire(){	
		iWeapon.Shoot();
	}
	
	void Start(){
		
		HandleWeaponType(); 
		HandleFlameColor();	
		iFlame.ShowFlame();		
	}
		
	void Update () {
	
		if (Input.GetKeyDown(KeyCode.Space)){
			Fire();
		}
		
		
		if(Input.GetKeyDown(KeyCode.C)){
			HandleWeaponType();			
		}	
		
		if (Input.GetKeyDown(KeyCode.F)){			
			HandleFlameColor();							
			iFlame.ShowFlame();
		}
	}
}
