using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesProgramma
{
    abstract class Base
    {
        public Vector3 position;

        protected Base(Vector3 position)
        {
            this.position = position;
        }

        public abstract void Awake();
        public abstract void Update();
    }
}
