using NUnit.Framework;
using System;
using System.ComponentModel;

namespace NetCore3_ClassWithReadonlyProperty {
    [TestFixture]
    public class TestClass {
        [Test]
        public void TypeDescriptorTest() {
            var prop = TypeDescriptor.GetProperties(typeof(ClassWithReadonlyProperty))[0];
            Assert.IsTrue(prop.IsReadOnly);
        }
    }

    public class ClassWithReadonlyProperty {
        public string Name { get; private set; }
    }
}
