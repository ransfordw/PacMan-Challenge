using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacManChallenge
{
    public class MazeObject
    {
        public MazeObject() {}
        public MazeObject(string name, int points)
        {
            ObjectName = name;
            Points = points;
        }

        public string ObjectName { get; set; }
        public int Points { get; set; }
    }
}
