using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Template
{
    class Enemy
    {
        Random rand = new Random();
        Texture2D Bomb;
        float angle = (float)Math.Atan(1);
        Vector2 enemyPos;
        //public void Initialize()
        //{

        //Random rnd = new Random();
        //float yPos = rnd.Next(0, 400);
        //}


        public Enemy(Texture2D Enemy)
        {
            enemyPos = new Vector2(800, rand.Next(0, 400));
            this.Bomb = Enemy;
        }
        public void Update()
        {
            enemyPos.X-=4;
        }
        public void Draw(SpriteBatch spriteBatch)
        {

                spriteBatch.Draw(Bomb, new Rectangle((int)enemyPos.X, (int)enemyPos.Y, 70, 70), null, Color.White, angle, new Vector2() , SpriteEffects.None, 0);

        }
        
    }
}
