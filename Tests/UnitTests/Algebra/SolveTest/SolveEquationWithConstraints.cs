﻿using AngouriMath;
using AngouriMath.Extensions;
using AngouriMath.Core;
using static AngouriMath.Entity.Number;
using Xunit;
using System.Collections.Generic;
using static AngouriMath.Entity;
using System.Linq;

namespace UnitTests.Algebra
{
    public class SolveEquationWithConstraints
    {
        /// <summary>Numerically checks if a root fits an equation</summary>
        internal static void AssertRoots(Entity equation, Variable toSub, Entity varValue, Integer? subValue = null)
        {
            subValue ??= 3;
            string eqNormal = equation.ToString();
            equation = equation.Substitute(toSub, varValue);
            // MUST be integer to correspond to integer coefficient of periodic roots
            var substitutions = new Dictionary<Entity.Variable, Integer>();
            foreach (var vr in equation.Vars)
                substitutions.Add(vr, subValue + substitutions.Count);
            equation = equation.Substitute(substitutions);
            var err = equation.EvalBoolean();
            Assert.True(err, $"\nError = {err}\n{eqNormal}\nWrong root: {toSub} = {varValue}");
        }

        [Theory]
        [InlineData("x + 2 = 0", 1)]
        [InlineData("x2 = 16", 2)]
        [InlineData("x2 = 16 and x = 4", 1)]
        [InlineData("x2 = 16 and x = -4", 1)]
        [InlineData("x2 = 16 and x = 3", 0)]
        [InlineData("x2 = 16 or x = 3", 3)]
        [InlineData("x4 = 16 and x > 0", 1)]
        [InlineData("x4 = 0 and x > 0", 0)]
        [InlineData("x4 = 0 and x >= 0", 1)]
        [InlineData("x = 1 or x = 2 or x = 3", 3)]
        public void TestFinite(string expr, int rootCount)
        {
            var eq = expr.ToEntity();
            var solutions = eq.Solve("x");
            Assert.True(solutions.IsFiniteSet(out var roots));
            Assert.Equal(rootCount, roots.Count());
            foreach (var root in roots)
                AssertRoots(eq, "x", root);
        }

        [Fact(Skip = "Sets require more work")]
        public void TestFiniteIntersection() => TestFinite("x2 = a and x = a", 1);
    }
}