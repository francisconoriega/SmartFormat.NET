﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cysharp.Text;
using NUnit.Framework;
using SmartFormat.Core.Output;

namespace SmartFormat.Tests.Core.Output
{
    [TestFixture]
    public class NullOutputTests
    {
        [Test]
        public void Output_Of_Span()
        {
            var so = new NullOutput();
            Assert.DoesNotThrow(() =>so.Write("text".AsSpan(), null));
        }

        [Test]
        public void Output_Of_String()
        {
            var so = new NullOutput();
            Assert.DoesNotThrow(() =>so.Write("text", null));
            Assert.That(so.ToString(), Is.Empty);
        }

        [Test]
        public void Output_Of_ValueStringBuilder()
        {
            using var sb = ZString.CreateStringBuilder();
            sb.Append("text");
            var so = new NullOutput();
            Assert.DoesNotThrow(() =>so.Write(sb, null));
        }
    }
}
