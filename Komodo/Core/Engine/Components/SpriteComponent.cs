using Komodo.Core.Engine.Entities;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Komodo.Core.Engine.Components
{
    public class SpriteComponent : IComponent
    {
        #region Constructors
        public SpriteComponent(Texture2D texture)
        {
            Parent = null;
            Texture = texture;
        }
        #endregion Constructors

        #region Members

        #region Public Members
        public IEntity Parent {
            get
            {
                return _parent;
            }
            set
            {
                _parent = value;
            }
        }
        public Texture2D Texture { get; set; }
        #endregion Public Members

        #region Protected Members
        protected IEntity _parent { get; set; }
        #endregion Protected Members

        #region Private Members
        #endregion Private Members

        #endregion Members

        #region Member Methods

        #region Public Member Methods
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(
                Texture,
                new Vector2(Parent.Position.X, Parent.Position.Y),
                null,
                Color.White,
                Parent.Rotation,
                Vector2.Zero,
                Parent.Scale,
                SpriteEffects.None,
                Parent.Position.Z
            );
        }

        public void Update(GameTime gameTime)
        {
        }
        #endregion Public Member Methods

        #region Protected Member Methods
        #endregion Protected Member Methods

        #region Private Member Methods
        #endregion Private Member Methods

        #endregion Member Methods
    }
}