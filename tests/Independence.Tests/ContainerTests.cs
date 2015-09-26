using FluentAssertions;
using Independece;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAttributes;

namespace Independence.Tests
{
    public class ContainerTests
    {
        public class Test : ITest { }
        public interface ITest { }

        internal class Resolve
        {
            [Unit]
            public void WhenServiceIsRegisteredReturnInstance()
            {
                var container = new Container();
                var resolution = container.Resolve<Test>();
                resolution.Should().NotBeNull();
            }

            [Unit]
            public void GivenFactoryActionReturnInstance()
            {

            }
        }
    }
}
