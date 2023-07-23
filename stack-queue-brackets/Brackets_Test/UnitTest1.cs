using Microsoft.VisualStudio.TestPlatform.TestHost;
using stack_queue_brackets;

namespace Brackets_Test
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("{ } ()kk){ }", false)]      // Invalid brackets
        [InlineData("{ ( ) } { [", false)]     // Unbalanced brackets
        [InlineData("{( [] )}", true)]               // Valid brackets        
        public void Test_ValidateBrackets(string input, bool expectedResult)
        {
            // Act
            bool result = ValidateBrackets(input);

            // Assert
            Assert.Equal(expectedResult, result);
        }
    }
}