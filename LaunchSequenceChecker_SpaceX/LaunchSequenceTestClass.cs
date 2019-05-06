using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaunchSequenceChecker_SpaceX
{
    [TestFixture]
    public class LaunchSequenceTestClass
    {
        /* Return true if all the individual system sequences are in strictly 
         * increasing order, otherwise return false.
        */

        LaunchSequence _launchSequence = new LaunchSequence();

        [Test]
        public void AllIndividualSystemSequencesNotInIncreasingOrder_ReturnFalse()
        {
            string[] systemNames = new string[4] { "stage_1", "stage_1", "stage_2", "dragon" };
            int[] stepNumbers = new int[4] { 2, 1, 12, 111 };

            var output = _launchSequence.LaunchSequenceChecker(systemNames, stepNumbers);
            var expected = false;

            Assert.AreEqual(expected, output);

        }



        [Test]
        public void AllSystemSequencesAreInIncreasingOrder_ReturnTrue()
        {
            string[] systemNames = new string[4] { "stage_1", "stage_1", "stage_2", "dragon" };
            int[] stepNumbers = new int[4] { 1, 2, 12, 111 };

            var output = _launchSequence.LaunchSequenceChecker(systemNames, stepNumbers);
            var expected = true;

            Assert.AreEqual(expected, output);
        }

        /* string[] systemNames = new string[6] { "stage_1", "stage_2", "dragon", "stage_1", "stage_2", "dragon" };
            int[] stepNumbers = new int[6] { 1, 10, 11, 2, 12, 111 };
            */
    }
}
