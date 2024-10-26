/* 
 * Representation of physical bodies in the engine.
 *
 * Supports circle and box shapes, with properties
 * like position, velocity, mass, density, and restitution.
 * Handles body creation and validation, such as ensuring
 * size and density fall within valid ranges.
 */

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

    public static bool CreateCircleBody(float radius, FlatVector position, float density, bool isStatic, float restitution, out FlatBody body, out string errorMessage)
    {
      body = null;
      errorMessage = string.Empty;

      // pi * r^2
      float area = radius * radius * MathF.PI;

      // Edge case: Circle is too small
      if (area < FlatWorld.MinBodySize)
      {
        errorMessage = $"Circle radius is too small. Minimum circle area is {FlatWorld.MinBodySize}.";
        return false;
      }

      // Edge case: Circle is too big
      if (area > FlatBody.MaxBodySize)
      {
        errorMessage = $"Circle radius is too large. Maximum circle area is {FlatWorld.MaxBodySize}.";
        return false;
      }

      // Edge case: Density is too small
      if (density < FlatWorld.MinDensity)
      {
        errorMessage = $"Density is too small. Minimum density is {FlatWorld.MinDensity}";
        return false;
      }

      // Edge case: Density is too big
      if (density > FlatWorld.MaxDensity)
      {
        errorMessage = $"Density is too large. Maximum density is {FlatWorld.MaxDensity}";
        return false;
      }
    }
  }
}