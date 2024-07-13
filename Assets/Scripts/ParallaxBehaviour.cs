using UnityEngine;

public class ParallaxBehaviour : MonoBehaviour
{
    [SerializeField] private Transform _target;
    [SerializeField, Range(0, 1)] private float _horisontalMovementMultiplier;
    [SerializeField, Range(0, 1)] private float _vertiicalMovementMultiplier;

    private Vector3 _targetPosition => _target.position;
    private Vector3 _lastVectorPosition;

    // Start is called before the first frame update
    private void Start()
    {
        _lastVectorPosition = _targetPosition;
    }

    // Update is called once per frame
    private void Update()
    {
        Vector3 delta = _targetPosition - _lastVectorPosition;
        delta *= new Vector2(_horisontalMovementMultiplier, _vertiicalMovementMultiplier);
        transform.position += delta;
        _lastVectorPosition = _targetPosition;
    }
}
