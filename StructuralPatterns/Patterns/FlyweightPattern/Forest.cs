using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructualPatterns.FlyweightPattern
{
    internal class Forest
    {
        private List<Tree> _trees = new List<Tree>();

        public void PlantTree(int x, int y, string treeType, string color)
        {
            TreeType type = TreeFactory.GetTreeType(treeType, color);

            Tree tree = new Tree(x, y, type);

            _trees.Add(tree);
        }

        public void PrintTrees()
        {
            foreach (var tree in _trees)
            {
                Console.WriteLine($"Tree on ({tree.X}, {tree.Y})");
                tree.TreeType.Print();
            }
        }
    }
}
