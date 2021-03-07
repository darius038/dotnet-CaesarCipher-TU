using CaesarCipher;
using FluentAssertions;
using Xunit;

namespace CeasarCipher.Tests
{
    public class CipherServiceTests
    {
        [Theory]
        [InlineData(51, "ABCD", "ZABC")]
        [InlineData(3, "E+3F=8B", "H+3I=8E")]
        public void Encrypt_ExpectedBehavior(int key, string encryptText, string expected)
        {
            // Act
            var result = CipherService.Encrypt(
                encryptText,
                key);

            // Assert
            result.Should().Be(expected);
        }

        [Theory]
        [InlineData(27, "ABCD", "ZABC")]
        [InlineData(3, "DEF123", "ABC123")]
        public void Decrypt_ExpectedBehavior(int key, string decryptText, string expected)
        {
            // Act
            var result = CipherService.Decrypt(
                decryptText,
                key);

            // Assert
            result.Should().Be(expected);
        }
    }
}