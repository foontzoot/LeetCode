using LeetCode;

namespace LeetCodeTests
{
    [TestFixture]
    internal class TwoSumSolutionTests
    {
        [TestCase(new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 1 })]
        [TestCase(new int[] { 3, 2, 4 }, 6, new int[] { 1, 2 })]
        [TestCase(new int[] { 3, 3 }, 6, new int[] { 0, 1 })]
        public void WhenTwoSumCases_ThenReturnCorrectTargetArray(int[] nums, int target, int[] expected)
        {
            // Arrange
            var solution = new TwoSumSolution(nums, target);
            // Act
            var actual = solution.result;
            // Assert
            Assert.That(actual, Is.EquivalentTo(expected));
        }

        [TestCase(new int[] { 4, 8, 13, 5, 7 }, 2, new int[] { 0, 0 })]
        public void WhenTwoSumNoResult_ThenReturnDoubleZeroArray(int[] nums, int target, int[] expected)
        {
            // Arrange
            var solution = new TwoSumSolution(nums, target);
            // Act
            var actual = solution.result;
            // Assert
            Assert.That(actual, Is.EquivalentTo(expected));
        }

        [TestCase(null, 100)]
        public void WhenTwoSumNumsIsNull_TheThrowArgumentNullException(int[] nums, int target)
        {
            _ = Assert.Throws<ArgumentNullException>(() => new TwoSumSolution(nums, target));
        }
    }
}
