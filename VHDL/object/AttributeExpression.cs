//
//  Copyright (C) 2010-2014  Denis Gavrish
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.
//

using System;

namespace VHDL.Object
{
	using Attribute = VHDL.declaration.Attribute;
	using Expression = VHDL.expression.Expression;
	using Name = VHDL.expression.Name;
	using SubtypeIndication = VHDL.type.ISubtypeIndication;
    using System.Collections.Generic;
   
    /// <summary>
    /// Attribute expression.
    /// </summary>
    [Serializable]
	public class AttributeExpression : Name
	{
        private readonly Name prefix;
		private readonly Attribute attribute;
        private readonly List<Expression> parameters;

        /// <summary>
        /// Creates an attribute expression.
        /// </summary>
        /// <param name="prefix">the prefix of this attribute expression</param>
        /// <param name="attribute">the attribute</param>
        public AttributeExpression(Name prefix, Attribute attribute)
		{
			this.prefix = prefix;
			this.attribute = attribute;
            this.parameters = new List<Expression>();
		}

        /// <summary>
        /// Creates an attribute expression with a parameter.
        /// </summary>
        /// <param name="prefix">the prefix of this attribute expression</param>
        /// <param name="attribute">the attribute</param>
        /// <param name="parameter">the parameter</param>
        public AttributeExpression(Name prefix, Attribute attribute, List<Expression> parameters)
		{
			this.prefix = prefix;
			this.attribute = attribute;
			this.parameters = parameters;
		}

        /// <summary>
        /// Returns the prefix of this attribute expression.
        /// </summary>
        public virtual Name Prefix
		{
            get { return prefix; }
		}

        /// <summary>
        /// Returns the attribute.
        /// </summary>
		public virtual Attribute Attribute
		{
            get { return attribute; }
		}

        /// <summary>
        /// Returns the parameter.
        /// </summary>
        public virtual List<Expression> Parameters
		{
            get { return parameters; }
		}

		public override SubtypeIndication Type
		{
            get
            {
                //TODO: implement corrently
                return attribute.Type;
            }
		}

        public override void accept(VHDL.expression.INameVisitor visitor)
        {
            visitor.visit(this);
        }
	}

}