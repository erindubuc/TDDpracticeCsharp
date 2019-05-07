using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaunchSequenceChecker_SpaceX
{
    public class LaunchSequence
    {
        public bool LaunchSequenceChecker(string[] systemNames, int[] stepNumbers)
        {
            var kvpList = new List<KeyValuePair<string, int>>();

            foreach (var name in systemNames)
            {
                foreach (var number in stepNumbers)
                {
                    kvpList.Add(new KeyValuePair<string, int> (name, number));
                }
            }

            // gets kvps by key and then filters down to only those groups with kvp > 1
            IEnumerable<IGrouping<string, KeyValuePair<string, int>>> duplicateKvpsByKey = kvpList.GroupBy(kvp => kvp.Key)
                .Where(g => g.Count() > 1);

            

            return false;
           
        }
        /*
        public bool ContainsDuplicates(string[] systemNames)
        {
            int namesLength = systemNames.Length;
            IEnumerable<string> distinctNames = systemNames.Distinct<string>();
            int distinctLength = distinctNames.Count();

            if (namesLength > distinctLength)
                return true;
            return false;
        }
        */
    }
}
