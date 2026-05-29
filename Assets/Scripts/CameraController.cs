using UnityEngine;

public class CameraController : MonoBehaviour {

	public float panSpeed = 30f;
	public float scrollSpeed = 5f;
	public float minY = 10f;
	public float maxY = 80f;

	Vector3 pos;
	float scroll;
	Transform thisTransform;

	void Awake()
	{
		thisTransform = transform;
	}

	// Update is called once per frame
	void Update () {

		if (GameManager.GameIsOver)
		{
			this.enabled = false;
			return;
		}

		if (Input.GetKey("w"))
		{
            thisTransform.Translate(Vector3.forward * panSpeed * Time.deltaTime, Space.World);
		}
		if (Input.GetKey("s"))
		{
			thisTransform.Translate(Vector3.back * panSpeed * Time.deltaTime, Space.World);
		}
		if (Input.GetKey("d"))
		{
			thisTransform.Translate(Vector3.right * panSpeed * Time.deltaTime, Space.World);
		}
		if (Input.GetKey("a"))
		{
			thisTransform.Translate(Vector3.left * panSpeed * Time.deltaTime, Space.World);
		}

		scroll = Input.GetAxis("Mouse ScrollWheel");

		pos = thisTransform.position;

		pos.y -= scroll * 1000 * scrollSpeed * Time.deltaTime;
		pos.y = Mathf.Clamp(pos.y, minY, maxY);

		thisTransform.position = pos;

	}
}
