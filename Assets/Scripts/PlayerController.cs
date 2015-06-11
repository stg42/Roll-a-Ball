using UnityEngine;
//using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour {
	
	public float speed;
	public GUIText countText;
	public GUIText winText;
	public float bounciness;
	
	private Rigidbody rb;
	private int count;
	
	void Start ()
	{
		rb = GetComponent<Rigidbody>();
		count = 0;
		SetCountText ();
		winText.text = "";
	}
	
	void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		
		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
		
		rb.AddForce (movement * speed);

	}
	
	void OnTriggerEnter(Collider other) 
	{
		if (other.gameObject.CompareTag ( "Pick Up"))
		{
			other.gameObject.SetActive (false);
			count = count + 1;
			SetCountText ();
			transform.localScale += new Vector3(0.2F, 0.2F, 0.2F);

			if (count >= 12)
			{
				transform.position = new Vector3(141, 82, -56);
				collider.material=null;
			}

		}

		if (other.gameObject.CompareTag ( "Pick Up 2"))
		{
			other.gameObject.SetActive (false);
			count = count + 1;
			SetCountText ();
			transform.localScale += new Vector3(0.2F, 0.2F, 0.2F);
			
			if (count >= 24)
			{
				transform.position = new Vector3(141, 82, -56);
				collider.material=null;
			}
			
		}

	}
	
	void SetCountText ()
	{
		countText.text = "Cubes Collected: " + count.ToString ();
		if (count >= 24)
		{
			winText.text = "You Win!";

		}


	}
}