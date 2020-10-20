using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    class EnemyManger
    {
        List<Enemy> enemyList = new List<Enemy>();
        Texture2D enemyTextur;
        Random rand = new Random();
        float time;
        public EnemyManger(Texture2D enemyTextur)
        {

            time = rand.Next(3, 7);
            this.enemyTextur = enemyTextur;
        }
        public void Update()
        {
           
            time -= 1f / 60f;
            if (time <= 0)
            {
                enemyList.Add(new Enemy(enemyTextur));
                time = rand.Next(3, 7);

            }
        }
        public void Draw(SpriteBatch spriteBatch)
        {

        }


    }
}
