﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace IoC.Framework.Tests.Classes {
    public class TestComponentRecursingArrayDependency : ITestService {
        public TestComponentRecursingArrayDependency(TestComponentWithArrayDependency dependency) {}
    }
}