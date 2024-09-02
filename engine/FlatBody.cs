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

    public readonly float density;
    public readonly float mass;
    public readonly float restitution; // Bounce!
    public readonly float area;
    
    public readonly bool isStatic;

    // For circles
    public readonly float radius;

    // For boxes
    public readonly float width;
    public readonly float height;

    public readonly ShapeType shapeType;
  }
}