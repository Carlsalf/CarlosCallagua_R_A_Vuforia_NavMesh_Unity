using UnityEngine;
using UnityEngine.AI;

public class TouchNavigation : MonoBehaviour
{
    public NavMeshAgent[] agents;
    public Camera arCamera;

    void Update()
    {
        bool isPressed = false;
        Vector3 pos = Vector3.zero;

#if UNITY_EDITOR || UNITY_STANDALONE
        if (Input.GetMouseButtonDown(0))
        {
            isPressed = true;
            pos = Input.mousePosition;
        }
#elif UNITY_IOS || UNITY_ANDROID
        if (Input.touchCount > 0)
        {
            Touch t = Input.GetTouch(0);
            if (t.phase == TouchPhase.Stationary ||
               (t.phase == TouchPhase.Moved && t.deltaPosition.magnitude < 1.5f))
            {
                isPressed = true;
                pos = t.position;
            }
        }
#endif

        if (isPressed)
        {
            Ray ray = arCamera.ScreenPointToRay(pos);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                foreach (var agent in agents)
                {
                    agent.SetDestination(hit.point);
                }
            }
        }
    }
}