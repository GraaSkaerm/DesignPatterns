using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructualPatterns.FlyweightPattern
{
    /// <summary>
    /// FlywieghtFactory
    /// </summary>
    internal class TreeFactory
    {
        public static Dictionary<string, TreeType> _flyweights = new Dictionary<string, TreeType>();


        public static TreeType GetTreeType(string type, string color)
        {
            if (_flyweights.Keys.Contains(type) == false)
            {
                _flyweights.Add(type, new TreeType(type, color));
            }

            return _flyweights[type];
        }
    }
}
