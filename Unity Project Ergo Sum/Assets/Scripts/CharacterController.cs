using UnityEngine;
using System.Collections;

public abstract class CharacterController : MonoBehaviour {
	public int health;
	public string name;
	public int deathTimer;
	public ArrayList<Status> currentStatuses;
	public Environment environment;
	// Use this for initialization
	void Start ();
	
	// Update is called once per frame
	void Update ();
}
