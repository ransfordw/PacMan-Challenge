using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacManChallenge
{
    public class MazeObjectRepository
    {
        private readonly Dictionary<string, int> _mazeObjects = new Dictionary<string, int>();

        public void AddMazeObjectToDictionary(MazeObject mazeObject)
        {
            _mazeObjects.Add(mazeObject.ObjectName, mazeObject.Points);
        }

        public void AddMazeObjectsToDictionary(List<MazeObject> mazeObjects)
        {
            foreach (var mazeObject in mazeObjects)
                _mazeObjects.Add(mazeObject.ObjectName, mazeObject.Points);
        }

        public Dictionary<string, int> GetDictionary()
        {
            return _mazeObjects;
        }
    }
}
