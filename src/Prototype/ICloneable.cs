namespace Prototype
{
    public interface ICloneable
    {
        object Clone(bool deepClone = false);
    }
}
