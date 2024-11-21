using Microsoft.VisualStudio.TestTools.UnitTesting;

using System;
using NaturalNumsLib;
namespace NaturalNumsTests
{
    [TestClass]
    public class EvenTest
    {
        [TestMethod]
        public void TwoIsEvenNuber() // (eng) "2 - ������ �����"
        {
            // �������� ��� �����, ����� �������� ����������� ���������
            bool Result = NaturalNumbers.IsEven(2);
            // ���������� � ��������� ���������
            Assert.IsTrue(Result);
        }
        [TestMethod]
        public void FiveIsOdd() // 5 - ��������
        {
            bool Result = NaturalNumbers.IsEven(5);
            // �������� ��������!
            // ���������� ������ ������� ������ ���� ��� 5
            // �������� false
            Assert.IsFalse(Result);
        }

        [TestMethod]
        public void Value2020IsEven() // �������� 2020 - ������
        {
            bool Result = NaturalNumbers.IsEven(2020);
            Assert.IsTrue(Result);
        }

    }
    [TestClass]
    public class GcdTests
    {
        [TestMethod]
        public void SameValues()
        {
            // ��������� ��������
            int Expected = 888;
            // ����������� ��������, ��������� ������ �������������� ������
            int Actual = NaturalNumbers.GCD(888, 888);
            // ���� �������, ���� ��� �������
            Assert.AreEqual(Expected, Actual);
        }
        [TestMethod]

        public void Zero()
        {
            Assert.AreEqual(7, NaturalNumbers.GCD(7, 0));
            Assert.AreEqual(0, NaturalNumbers.GCD(0, 0));
            Assert.AreEqual(7, NaturalNumbers.GCD(0, 7));
        }
        [TestMethod] // ���� ������� ����� ��� GCD
        public void Diffrent()
        {
            // ��������� ��������
            int Expected = 8;
            // ����������� ��������, ��������� ������ �������������� ������
            int Actual = NaturalNumbers.GCD(24, 32);
            // ���� �������, ���� ��� �������
            Assert.AreEqual(Expected, Actual);
        }
        [TestMethod]
        public void Values()
        {
            Assert.AreEqual(15, NaturalNumbers.GCD(45, 15));
            Assert.AreEqual(15, NaturalNumbers.GCD(15, 45));
        }

        [TestMethod] // ����� �������� [Test], ����� ����� ��� ����� ��� ��������!
        public void One()
        {
            // ��������� ��������
            int Expected = 1;
            // ����������� ��������, ��������� ������ �������������� ������
            int Actual = NaturalNumbers.GCD(49, 50);
            // ���� �������, ���� ��� �������
            Assert.AreEqual(Expected, Actual);
        }
        [TestMethod]
        public void Negativ()
        {
            Assert.ThrowsException<Exception>(() => NaturalNumbers.GCD(-10, -15));
            Assert.ThrowsException<Exception>(() => NaturalNumbers.GCD(10, -15));
            Assert.ThrowsException<Exception>(() => NaturalNumbers.GCD(-10, 15));

        }
    }
    [TestClass]
    public class IsPrimeTests
    {
        [TestMethod]
        public void IsPrimeTestFirst()
        {

            bool Expected = true;

            bool Actual = NaturalNumbers.IsPrime(11);

            Assert.AreEqual(Expected, Actual);
        }
        [TestMethod]
        public void IsPrimeTestSecond()
        {

            bool Expected = false;

            bool Actual = NaturalNumbers.IsPrime(20);

            Assert.AreEqual(Expected, Actual);
        }
    }
    [TestClass]
    public class LCMTests
    {
        [TestMethod]
        public void PositiveNumbers()
        {
            Assert.AreEqual(20, NaturalNumbers.LCM(4, 5));
            Assert.AreEqual(12, NaturalNumbers.LCM(4, 6));
            Assert.AreEqual(30, NaturalNumbers.LCM(5, 6));
        }

        [TestMethod]
        public void NegativeNumbers()
        {
            Assert.ThrowsException<Exception>(() => NaturalNumbers.LCM(-48, 18));
            Assert.ThrowsException<Exception>(() => NaturalNumbers.LCM(48, -18));
            Assert.ThrowsException<Exception>(() => NaturalNumbers.LCM(-48, -18));
        }

        [TestMethod]
        public void Same()
        {
            Assert.AreEqual(7, NaturalNumbers.LCM(7, 7));
        }

        [TestMethod]
        public void Zero()
        {
            Assert.ThrowsException<Exception>(() => NaturalNumbers.LCM(0, 5));
            Assert.ThrowsException<Exception>(() => NaturalNumbers.LCM(5, 0));
            Assert.ThrowsException<Exception>(() => NaturalNumbers.LCM(0, 0));
        }

        [TestMethod]
        public void One()
        {
            Assert.AreEqual(5, NaturalNumbers.LCM(1, 5));
            Assert.AreEqual(7, NaturalNumbers.LCM(1, 7));
        }
    }
}