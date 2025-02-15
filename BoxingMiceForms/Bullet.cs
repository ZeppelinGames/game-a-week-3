﻿using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Editor {
    public class Bullet {
        public float x;
        public int X => (int)x;
        public float y;
        public int Y => (int)y;
        public float dx;
        public int dX => (int)dx;
        public float dy;
        public int dY => (int)dy;

        public int playerId;

        public Bullet(Player p) {
            this.playerId = p.id;
            this.x = p.x;
            this.y = p.y;
            this.dx = p.mouseData.nLDX;
            this.dy = p.mouseData.nLDY;
        }

        public void Update(GameTime gameTime) {
            this.x += this.dx;
            this.y += this.dy;
        }
    }
}
