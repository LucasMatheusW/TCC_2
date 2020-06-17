using UnityEngine;

public class RangeAttribute : ShowWhenAttribute
{
    public float fMin;
	public float fMax;
    public int iMin;
    public int iMax;

    // float
    public RangeAttribute(float min, float max)
        : base()
    {
        this.fMin = min;
        this.fMax = max;
    }

    public RangeAttribute(float min, float max, string propertyName)
        : base(propertyName)
    {
        this.fMin = min;
        this.fMax = max;
    }

    public RangeAttribute(float min, float max, string propertyName, Condition cond, bool value)
        : base(propertyName, cond, value)
    {
        this.fMin = min;
        this.fMax = max;
    }

    public RangeAttribute(float min, float max, string propertyName, Condition cond, float value)
        : base(propertyName, cond, value)
    {
        this.fMin = min;
        this.fMax = max;
    }

    public RangeAttribute(float min, float max, string propertyName, Condition cond, int value)
        : base(propertyName, cond, value)
    {
        this.fMin = min;
        this.fMax = max;
    }

    public RangeAttribute(float min, float max, string propertyName, Condition cond, Object value)
        : base(propertyName, cond, value)
    {
        this.fMin = min;
        this.fMax = max;
    }

    public RangeAttribute(float min, float max, string propertyName, Condition cond, string value)
        : base(propertyName, cond, value)
    {
        this.fMin = min;
        this.fMax = max;
    }

    // integer
    public RangeAttribute(int min, int max)
        : base()
    {
        this.iMin = min;
        this.iMax = max;
    }

    public RangeAttribute(int min, int max, string propertyName)
        : base(propertyName)
    {
        this.iMin = min;
        this.iMax = max;
    }

    public RangeAttribute(int min, int max, string propertyName, Condition cond, bool value)
        : base(propertyName, cond, value)
    {
        this.iMin = min;
        this.iMax = max;
    }

    public RangeAttribute(int min, int max, string propertyName, Condition cond, float value)
        : base(propertyName, cond, value)
    {
        this.iMin = min;
        this.iMax = max;
    }

    public RangeAttribute(int min, int max, string propertyName, Condition cond, int value)
        : base(propertyName, cond, value)
    {
        this.iMin = min;
        this.iMax = max;
    }

    public RangeAttribute(int min, int max, string propertyName, Condition cond, Object value)
        : base(propertyName, cond, value)
    {
        this.iMin = min;
        this.iMax = max;
    }

    public RangeAttribute(int min, int max, string propertyName, Condition cond, string value)
        : base(propertyName, cond, value)
    {
        this.iMin = min;
        this.iMax = max;
    }
}
