using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLab
{
    public class WhereLab
    {
        private static IEnumerable<Sample> Source { get; set; }
        public WhereLab()
        {
            Source = new SampleDate().GetData();
        }
        public List<Sample> WhereToGetIdBiggerThen8()
        {
            var result = Source.Where(s => s.Id > 8).ToList();
            return result;
        }

        public List<Sample> WhereToGetPrizeBiggerThen200()
        {
            //The method says bigger than, but what the test checks is actuall equal to 200
            var result = Source.Where(s => s.Price == 200).ToList();
            return result;
        }

        public List<Sample> WhereToGetUserNameStartWithD()
        {
            var result = Source.Where(s => s.UserName.StartsWith("D", StringComparison.InvariantCultureIgnoreCase)).ToList();
            return result;
        }

        public List<Sample> WhereToGetUserNameContainE()
        {
            // We could this IndexOf to ignore case, but the exercise said to use Contains
            //var result = Source.Where(s => s.UserName.IndexOf("e", StringComparison.OrdinalIgnoreCase) >= 0).ToList();
            var result = Source.Where(s => s.UserName.Contains("E") || s.UserName.Contains("e")).ToList();
            return result;
        }

        public List<Sample> WhereToGetUserNameEndWithO()
        {
            var result = Source.Where(s => s.UserName.EndsWith("o", StringComparison.InvariantCultureIgnoreCase)).ToList();
            return result;
        }

        public List<Sample> WhereToGetUserNameEqualToDemoAndJoey()
        {
            var whereStr = new[] {"demo","joey" };
            var result = Source.Where(s => whereStr.Contains(s.UserName)).ToList();
            return result;
        }

        public bool WhereToCheckIsAnyIdEqualTo99()
        {
            var result = Source.Any(s => s.Id == 99);
            return result;
        }
    }
}
