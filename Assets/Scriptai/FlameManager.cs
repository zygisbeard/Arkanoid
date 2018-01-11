using UnityEngine;
using System.Collections;

public class FlameManager : MonoBehaviour {
	
}

public interface IFlame{
	
	void ShowFlame();
	void DestroyFlame();
}

public class BlueFlame:MonoBehaviour,IFlame{
			
	private GameObject flame;
	public void ShowFlame(){
	
		GameObject blueFlame = Instantiate(Resources.Load("PS2",typeof(GameObject))) as GameObject;
		flame = blueFlame;
		blueFlame.transform.parent=transform;		
	}
	
	public void DestroyFlame(){
		Destroy(flame);
	}
}

public class RedFlame:MonoBehaviour,IFlame{
	
	private GameObject flame;
	public void ShowFlame(){	
		GameObject redFlame = Instantiate(Resources.Load("PS",typeof(GameObject))) as GameObject;
		flame = redFlame;
		redFlame.transform.parent=transform;		
	}
	
	public void DestroyFlame(){
		Destroy(flame);
	}
}