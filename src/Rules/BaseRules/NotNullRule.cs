//-----------------------------------------------------------------------------
// <copyright file="NotNullRule.cs" company="http://rulesengine.codeplex.com">
//   Copyright (c) athoma13. See RulesEngine_License.txt. This file is
//   subject to the Microsoft Public License. All other rights reserved.
// </copyright>
// <summary>
//   Created by: athoma13
//   Date      : Fri Sep 30 2011
//   Purpose   : Rule Engine
// </summary>
// <history>
//   Sat Jan 28 2012 by Fastalanasa - Added to WheelMUD.Rules
// </history>
//-----------------------------------------------------------------------------

namespace WheelMUD.Rules
{
    public class NotNullRule<R> : IRule<R> where R : class
    {
        public ValidationResult Validate(R value)
        {
            if (value != null)
                return ValidationResult.Success;

            return ValidationResult.Fail();
        }

        public string RuleKind
        {
            get { return "NotNullRule"; }
        }
    }
}
