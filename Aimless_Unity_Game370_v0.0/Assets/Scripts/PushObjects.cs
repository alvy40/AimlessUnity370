using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushObjects : MonoBehaviour
{
	public float distance = 1f;
	public LayerMask boxMask;

	public GameObject box;

	
	void Update()
	{

		Physics2D.queriesStartInColliders = false;
		RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.right * transform.localScale.x, distance, boxMask);

		if (hit.collider != null && hit.collider.gameObject.tag == "pushable" && Input.GetKeyDown(KeyCode.Q))
		{


			box = hit.collider.gameObject;
			box.GetComponent<FixedJoint2D>().connectedBody = this.GetComponent<Rigidbody2D>();
			box.GetComponent<FixedJoint2D>().enabled = true;
			box.GetComponent<boxpull>().beingPushed = true;

		}
		else if (Input.GetKeyUp(KeyCode.Q))
		{
			box.GetComponent<FixedJoint2D>().enabled = false;
			box.GetComponent<boxpull>().beingPushed = false;
			/*Physics2D.queriesStartInColliders = false;
			RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.right * transform.localScale.x, distance, boxMask);
			*/
		}

	}


	void OnDrawGizmos()
	{
		Gizmos.color = Color.yellow;
		/*Gizmos.color = color.yellow;
		Gizmos.DrawLine(transform.position, (Vector2)transform.position + Vector2.right * transform.localScale.x, distance);
		*/
		Gizmos.DrawLine(transform.position, (Vector2)transform.position + Vector2.right * transform.localScale.x * distance);



	}

}
