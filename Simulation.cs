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
using Flat;
using Flat.Graphics;
using Flat.Input;

namespace FlatPhysics
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
  }
}
