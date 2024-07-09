/*
 * MonoGame to simulate games for the physics engine.
 *
 * Logic for key inputs, movements, camera, and more.
*/

using System;
using System.Diagnostics;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using flat;
using flat.graphics;
using flat.input;

namespace tests
{
  public class Simulation : Game
  {
    private GraphicsDeviceManager graphics;
    private Screen screen;
    private Sprites sprites;
    private Shapes shapes;
    private Camera camera;

    // Constructor for Simulation class
    public Simulation()
    {
      this.graphics = new GraphicsDeviceManager(this);
      this.graphics.SynchronizeWithVerticalRetrace = true;

      this.Content.RootDirectory = "Content";
      this.IsMouseVisible = true;
      this.IsFixedTimeStep = true;

      const double UpdatesPerSecond = 60d;
      this.TargetElapsedTime = TimeSpan.FromTicks((long)Math.Round((double)TimeSpan.TicksPerSecond / UpdatesPerSecond));
    }

    protected override void Initialize()
    {
      FlatUtil.SetRelativeBackBufferSize(this.graphics, 0.85f);

      this.screen = new Screen(this, 1280, 768);
      this.sprites = new Sprites(this);
      this.shapes = new Shapes(this);
      this.camera = new Camera(this.screen);
      this.camera.Zoom = 5;

      base.Initialize();
    }

    protected override void LoadContent()
    {
    }

    protected override void Update(GameTime gameTime)
    {
      FlatKeyboard keyboard = FlatKeyboard.Instance;
      FlatMouse mouse = FlatMouse.Instance;

      keyboard.Update();
      mouse.Update();

      // 2D scene, but camera can move in 3D space
      if (keyboard.IsKeyAvailable)
      {
        // Key to leave simulation
        if (keyboard.IsKeyClicked(Keys.Escape))
        {
          this.Exit();
        }

        // Key to zoom in
        if (keyboard.IsKeyClicked(Keys.A))
        {
          this.camera.IncZoom();
        }

        // Key to zoom out
        if (keyboard.IsKeyClicked(Keys.Z))
        {
          this.camera.DecZoom();
        }
      }

      base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
      this.screen.Set();
      this.GraphicsDevice.Clear(new Color(50, 60, 70));

      this.shapes.Begin(this.camera);
      this.shapes.DrawCircle(0, 0, 32, 32, Color.White);  // Circle to test that imports work
      this.shapes.End();

      this.screen.Unset();
      this.screen.Present(this.sprites);

      base.Draw(gameTime);
    }
  }
}
