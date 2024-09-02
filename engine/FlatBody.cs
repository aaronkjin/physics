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

    private float density;
    private float mass;
    private float restitution; // Bounce!
    private float area;
    
    private bool isStatic;

    // For circles
    private float radius;

    // For boxes
    private float width;
    private float height;
  }
}