using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhyllotaxisSimple : MonoBehaviour
{

    public float _degree, _scale;
    public int _numberStart; //position number
    public int _stepSize;
    public int _maxIteration;
    private Material _trailMat;
    public Color _trailColor;

    //Learping
    public bool _userLerping;
    public float _intervalLerp; //duration of one point to the next point
    private bool _isLearping;
    private Vector3 _startPosition, _endPosition;
    private float _timeStartedLerping;

    private int _number; //ordering number of a seed couting outward from the center
    private int _currentIteration;
    private TrailRenderer _trailRender;

    public bool activate = false;

    private void Start()
    {
        _degree = Random.Range(-360.0f, 360.0f);
    }

    private Vector2 CalculatePhyllotaxis(float degree, float scale, int number)
    {
        //Fogle's formula
        double angle = number * (degree * Mathf.Deg2Rad);
        float r = scale * Mathf.Sqrt(number); //radius

        //Polar to cartesian coordinates    
        float x = r * (float)System.Math.Cos(angle);
        float y = r * (float)System.Math.Sin(angle);

        Vector2 vec2 = new Vector2(x, y);
        return vec2;

    }

    private Vector2 _phyllotaxisPosition;

    void StartLerping()
    {
        _isLearping = true;
        _timeStartedLerping = Time.time;
        _phyllotaxisPosition = CalculatePhyllotaxis(_degree, _scale, _number);
        _startPosition = this.transform.localPosition; //current position
        _endPosition = new Vector3(_phyllotaxisPosition.x, _phyllotaxisPosition.y, 0);
    }

    private void Awake()
    {
        _trailRender = GetComponent<TrailRenderer>();
        _trailMat = new Material(_trailRender.material);
        _trailMat.SetColor("_TintColor", _trailColor);
        _trailRender.material = _trailMat;
        _number = _numberStart;
        transform.localPosition = CalculatePhyllotaxis(_degree, _scale, _number); //start at the position of the number start At Phyllotaxis Calculation
        if (_userLerping)
        {
            StartLerping();
        }
    }
    
    private void FixedUpdate()
    {
        if (activate)
        {
            if (_userLerping)
            {
                if (_isLearping)
                {
                    float timeSinceStarted = Time.time - _timeStartedLerping;
                    float percentageComplete = timeSinceStarted / _intervalLerp;
                    transform.localPosition = Vector3.Lerp(_startPosition, _endPosition, percentageComplete);
                    if (percentageComplete >= 0.97f)
                    {
                        transform.localPosition = _endPosition;
                        _number += _stepSize;
                        _currentIteration++;
                        if (_currentIteration <= _maxIteration)
                        {
                            StartLerping();
                        }
                        else
                        {
                            _isLearping = false;
                        }
                    }
                }
            }
            else
            {
                _phyllotaxisPosition = CalculatePhyllotaxis(_degree, _scale, _number);
                transform.localPosition = new Vector3(_phyllotaxisPosition.x, _phyllotaxisPosition.y, 0);
                _number += _stepSize;
                _currentIteration++;
            }
        }
        
        
    } 

}
