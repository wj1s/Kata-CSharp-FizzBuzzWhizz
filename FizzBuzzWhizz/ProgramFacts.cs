using Xunit;

namespace FizzBuzzWhizz
{
    public class ProgramFacts
    {
        [Theory]
        [InlineData(1, "1", new[] {3, 5, 7})]
        [InlineData(3, "Fizz", new[] {3, 5, 7})]
        [InlineData(6, "Fizz", new[] {3, 5, 7})]
        [InlineData(5, "Buzz", new[] {3, 5, 7})]
        [InlineData(10, "Buzz", new[] {3, 5, 7})]
        [InlineData(7, "Whizz", new[] {3, 5, 7})]
        [InlineData(14, "Whizz", new[] {3, 5, 7})]
        [InlineData(15, "FizzBuzz", new[] {3, 5, 7})]
        [InlineData(21, "FizzWhizz", new[] {3, 5, 7})]
        [InlineData(60, "FizzBuzzWhizz", new[] {3, 4, 5})]
        [InlineData(13, "Fizz", new[] {3, 4, 5})]
        [InlineData(35, "Fizz", new[] {3, 4, 5})]
        public void should_get_word(int num, string word, int[] keys)
        {
            Assert.Equal(word, Program.GetWord(num, keys));
        }
    }
}