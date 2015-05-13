using UnityEngine;
using System.Collections;

public class HeartController : MonoBehaviour {

	public SixenseInput.Controller m_controller = null;

	float 		m_fLastTriggerVal;
	Quaternion 	m_initialRotation;
	
	// Use this for initialization
	protected void Start () {
		m_initialPosition = transform.localPosition;
        m_initialRotation = transform.localRotation;
	}
	
	// Update is called once per frame
	protected void Update () {
		if ( m_controller == null )
			m_controller = SixenseInput.GetController( SixenseHands.RIGHT );
        UpdateHeart();
	}

	void UpdateHeart( )
	{
		bool bControllerActive = IsControllerActive( m_controller );
		
		if ( bControllerActive )
			transform.localRotation = m_controller.Rotation * InitialRotation;
		else
			// use the inital position and orientation because the controller is not active
			hand.transform.localRotation  = hand.InitialRotation;
	}
}
