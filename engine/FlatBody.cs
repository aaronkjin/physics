using System;

namespace engine
{
  public enum ShapeType
  {
    Circle = 0, 
    Box = 1
  }

  public sealed class FlatBody
  {
    private FlatVector position;
    private FlatVector linearVelocity;
    private float rotation;
    private float rotationalVelocity;

    public readonly float Density;
    public readonly float Mass;
    public readonly float Restitution; // Bounce!
    public readonly float Area;
    
    public readonly bool IsStatic;

    // For circles
    public readonly float Radius;

    // For boxes
    public readonly float Width;
    public readonly float Height;

    public readonly ShapeType ShapeType;
  }
}