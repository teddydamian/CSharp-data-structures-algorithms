using System;
using Xunit;
using MultiBracketValidation;
using MultiBracketValidation.Classes;

namespace MultiBracketTest
{
    public class UnitTest1
    {

        /// <summary>
        /// Test to see if Method can check on 3 types of brackets
        /// </summary>
        /// <param name="input"></param>
        [Theory]
        [InlineData("[]")]
        [InlineData("()")]
        [InlineData("{}")]
        public void TheoryToTestEachBracketType(string input)
        {
            Bracket brax = new Bracket();
            Assert.True(brax.Validate(input));
        }

        /// <summary>
        /// Test to see if Method can check multiple brackets in a string
        /// </summary>
        /// <param name="input"></param>
        [Theory]
        [InlineData("[({})]")]
        [InlineData("{[()]}")]
        [InlineData("({[]})")]
        [InlineData("(){}[]")]
        [InlineData("[]{}()")]
        [InlineData("()[]{}")]
        public void TheoryToTestComboBracketType(string input)
        {
            Bracket brax = new Bracket();
            Assert.True(brax.Validate(input));
        }

        /// <summary>
        /// Test to see if Method can run strings with alphabets
        /// </summary>
        /// <param name="input"></param>
        [Theory]
        [InlineData("[({potato})]")]
        [InlineData("[Code({}Fellow)]")]
        [InlineData("[a(b{c}d)e]")]
        [InlineData("[code]{fellow}(isgreat)")]
        public void TestForAlphabetInsideBrackets(string input)
        {
            Bracket brax = new Bracket();
            Assert.True(brax.Validate(input));
        }

        /// <summary>
        /// Test to see if order matters
        /// </summary>
        /// <param name="input"></param>
        [Theory]
        [InlineData("[((})(]")]
        [InlineData("{]}")]
        [InlineData("((}))")]
        public void TestForFail(string input)
        {
            Bracket brax = new Bracket();
            Assert.False(brax.Validate(input));
        }
    }
}
