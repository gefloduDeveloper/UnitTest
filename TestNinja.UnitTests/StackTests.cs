using NUnit.Framework;
using System;
using System.Linq;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    class StackTests
    {
        [Test]
        public void Push_ObjectIsNull_ThrowsArgumentNullException()
        {
            var stack = new Fundamentals.Stack<object>();
            Assert.That(() => stack.Push(null), Throws.ArgumentNullException);
        }

        [Test]
        public void Push_ObjectIsNotNull_StackCountIs1()
        {
            var stack = new Fundamentals.Stack<object>();
            stack.Push(new object());
            Assert.That(stack.Count, Is.EqualTo(1));
        }

        [Test]
        public void Pop_StackIsEmpty_ThrowsInvalidOperationException()
        {
            var stack = new Fundamentals.Stack<object>();
            Assert.That(() => stack.Pop(), Throws.InvalidOperationException);
        }

        [Test]
        public void Pop_StackIsNotEmpty_StackCountIs0()
        {
            var stack = new Fundamentals.Stack<object>();
            stack.Push(new object());
            stack.Pop();
            Assert.That(stack.Count, Is.EqualTo(0));
        }


        [Test]
        public void Peek_StackIsEmpty_ThrowsInvalidOperationException()
        {
            var stack = new Fundamentals.Stack<object>();
            Assert.That(() => stack.Peek(), Throws.InvalidOperationException);
        }

        [Test]
        public void Peek_StackIsNotEmpty_ReturnNotNullObject()
        {
            var stack = new Fundamentals.Stack<object>();
            stack.Push(new object());
            var result = stack.Peek();
            Assert.That(result, Is.Not.Null);
        }

        [Test]
        public void Count_StackIsEmpty_ReturnZero()
        {
            var stack = new Fundamentals.Stack<object>();
            Assert.That(stack.Count, Is.EqualTo(0));
        }

        [Test]
        public void Pop_StackIsNotEmpty_StackReturnsElementOnTheTop()
        {
            var stack = new Fundamentals.Stack<object>();
            stack.Push(new object());
            var result = stack.Pop();
            Assert.That(result, Is.Not.Null);
        }

        public void Peek_StackIsNotEmpty_StackCountRemainsTheSame()
        {
            var stack = new Fundamentals.Stack<object>();
            stack.Push(new object());
            var result = stack.Peek();
            Assert.That(stack.Count, Is.EqualTo(1));
        }
    }
}
