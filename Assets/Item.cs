using UnityEngine;

public class Item : MonoBehaviour
{
	private Vector3 screenPoint;
	private Vector3 offset;
	
	private bool inRange;
    void OnTriggerStay(Collider other)
	{
        inRange = true;
    }

	void OnTriggerExit(Collider other)
	{
		inRange = false;
	}

	void OnMouseDown()
	{
		if (inRange)
		{
            screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
			offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint
				(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
		}
	}

	void OnMouseDrag()
	{
		if (inRange)
        {
			Vector3 cursorPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
			Vector3 cursorPosition = Camera.main.ScreenToWorldPoint(cursorPoint) + offset;
			transform.position = cursorPosition;
		}
		
	}
}
