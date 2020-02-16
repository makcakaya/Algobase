using System.Collections.Generic;
using System.Linq;

namespace Codility
{
    public sealed class NumberOfDiscIntersections
    {
        public static int Solution(int[] radiuses)
        {
            var points = new Dictionary<long, Point>();
            for (var i = 0L; i < radiuses.Length; i++)
            {
                var r = radiuses[i];
                var discX = new List<long>();
                if (r == 0)
                {
                    discX.Add(i);
                }
                else
                {
                    discX.Add(i - r);
                    discX.Add(i + r);
                }

                foreach (var x in discX)
                {
                    var point = new Point();
                    if (points.ContainsKey(x))
                    {
                        point = points[x];
                    }
                    if (x == i)
                    {
                        point.ZeroRadius = true;
                    }
                    else
                    {
                        var collection = x < i ? point.Starters : point.Enders;
                        collection.Add(i);
                    }
                    points[x] = point;
                }
            }

            var scan = new HashSet<long>();
            var keys = points.Keys.OrderBy(k => k).ToArray();
            var count = 0;
            for (var i = 0; i < keys.Count(); i++)
            {
                var key = keys[i];
                var point = points[key];
                for (var j = 0; j < point.Starters.Count; j++)
                {
                    count += scan.Count;
                    if (count > 10000000)
                    {
                        return -1;
                    }
                    scan.Add(point.Starters[j]);
                }

                if (point.ZeroRadius)
                {
                    count += scan.Count;
                }

                for (var j = 0; j < point.Enders.Count; j++)
                {
                    scan.Remove(point.Enders[j]);
                }
            }
            return count;
        }

        public sealed class Point
        {
            public List<long> Starters { get; set; } = new List<long>();
            public bool ZeroRadius { get; set; }
            public List<long> Enders { get; set; } = new List<long>();
        }
    }
}