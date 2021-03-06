// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Microsoft.CSharp.RuntimeBinder.Semantics
{
    internal sealed class ExprField : ExprWithType, IExprWithObject
    {
        public ExprField(CType type)
            : base(ExpressionKind.Field, type)
        {
        }

        public Expr OptionalObject { get; set; }

        public FieldWithType FieldWithType { get; set; }
    }
}
