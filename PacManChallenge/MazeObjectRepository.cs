using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacManChallenge
{
    public class MazeObjectRepository
    {
        private Dictionary<string, int> MazeObject = new Dictionary<string, int>();

        public void AddMazeObjectToDictionary (MazeObject mazeObject)
        {
            MazeObject.Add(mazeObject.ObjectName, mazeObject.Points);
        }

        public Dictionary<string, int> GetDictionary()
        {
            return MazeObject;
        }
    }
}
