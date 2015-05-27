﻿using Astrid;
using Astrid.Core;

namespace HelloWorld
{
    public class Game : GameBase
    {
        private SpriteBatch _spriteBatch;
        private Texture _texture;
        private Vector2 _position;

        public Game(ApplicationBase application)
            : base(application)
        {
        }

        public override void Create()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            _texture = AssetManager.Load<Texture>("AstridLogo.png");
            
            var x = GraphicsDevice.Width / 2 - _texture.Width / 2;
            var y = GraphicsDevice.Height / 2 - _texture.Height / 2;
            _position = new Vector2(x, y);
        }

        public override void Destroy()
        {
        }

        public override void Pause()
        {
        }

        public override void Resume()
        {
        }

        public override void Resize(int width, int height)
        {
        }

        public override void Update(float deltaTime)
        {
        }

        public override void Render(float deltaTime)
        {
            GraphicsDevice.Clear(Color.SkyBlue);

            _spriteBatch.Begin();
            _spriteBatch.Draw(_texture, _position);
            _spriteBatch.End();
        }
    }
}
