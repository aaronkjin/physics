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

    private FlatBody(FlatVector position, float density, float mass, float restitution, float area, bool isStatic, float radius, float width, float height, ShapeType shapeType)
    {
      this.position = position;
      this.linearVelocity = FlatVector.Zero;
      this.rotation = 0f;
      this.rotationalVelocity = 0f;

      this.Density = density;
      this.Mass = mass;
      this.Restitution = restitution;
      this.Area = area;

      this.IsStatic = isStatic;
      this.Radius = radius;
      this.Width = width;
      this.Height = height;
      this.ShapeType = shapeType;
    }
  }
}